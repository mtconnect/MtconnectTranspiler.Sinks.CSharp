using Scriban.Runtime;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System;
using System.Linq;
using MtconnectTranspiler.Xmi.UML;
using MtconnectTranspiler.Contracts;
using System.Text;

namespace MtconnectTranspiler.Sinks.CSharp.Models
{
    /// <summary>
    /// Helper methods to process content for scriban templates
    /// </summary>
    public class ScribanHelperMethods : ScriptObject
    {
        /// <summary>
        /// The default replacement character for converting invalid code characters.
        /// </summary>
        public const string DEFAULT_CODE_SAFE_REPLACEMENT = "_";

        private static Dictionary<string, Type> umlDataTypeToCSharp = new Dictionary<string, Type>()
        {
            { "boolean", typeof(bool) },
            { "ID", typeof(string) },
            { "string", typeof(string) },
            { "float", typeof(float) },
            { "datetime", typeof(DateTime) },
            { "integer", typeof(int) },
            { "xlinktype", typeof(string) },
            { "xslang", typeof(string) },
            { "SECOND", typeof(float) },
            { "IDREF", typeof(string) },
            { "xlinkhref", typeof(string) },
            { "MILLIMETER", typeof(float) },
            { "DEGREE", typeof(float) },
            { "x509", typeof(string) },
            { "CUBIC_MILLIMETER", typeof(float) },
            { "int32", typeof(int) },
            { "int64", typeof(long) },
            { "version", typeof(string) },
            { "uint32", typeof(uint) },
            { "uint64", typeof(ulong) },
            { "double", typeof(double) },
            
        };
        /// <summary>
        /// Gets the C# equivalant of the <see cref="UmlDataType"/>.
        /// </summary>
        /// <param name="source">Reference to the packaged UML DataType</param>
        /// <returns>Primitive type. Returns null if unrecognizes or unhandled DataType</returns>
        public static Type ToPrimitiveType(UmlDataType source)
        {
            if (umlDataTypeToCSharp.TryGetValue(source.Name, out Type type))
                return type;
            return null;
        }
        /// <summary>
        /// Gets the C# equivalant of the <see cref="UmlProperty"/>.
        /// </summary>
        /// <param name="model">Reference to the source XMI document</param>
        /// <param name="source">Reference to the packaged UML Property</param>
        /// <returns>Primitive type. Returns null if unrecognizes or unhandled Property</returns>
        public static Type ToPrimitiveType(Xmi.XmiDocument model, UmlProperty source)
        {
            var umlDataType = model.LookupDataType(source.PropertyType);
            if (umlDataType == null)
                return null;
            return ToPrimitiveType(umlDataType);
        }

        /// <summary>
        /// Converts Markdown into C# <c>&lt;summary /&gt;</c> formatted text.
        /// </summary>
        /// <param name="markdown">Markdown text</param>
        /// <returns><c>&lt;summary /&gt; formatted text.</c></returns>
        public static string ToSummary(string markdown)
        {
            if (string.IsNullOrEmpty(markdown)) return markdown;

            Dictionary<Regex, Func<string, string>> rules = new Dictionary<Regex, Func<string, string>>()
            {
                { new Regex(@"(.*?)(?<block>&#10;)(.*?)"), (string s) => $"<br/>" },
                { new Regex(@"(.*?)(?<block>`(?<contents>.*?)`)(.*?)"), (string s) => $"<c>{s}</c>" },
                { new Regex(@"(.*?)(?<block>\*\*(?<contents>.*?)\*\*)(.*?)"), (string s) => $"<b>{s}</b>" },
                { new Regex(@"(.*?)(?<block>\{\{block\((?<contents>.*?)\)\}\})(.*?)"), (string s) => $"<see cref=\"{s}\">{s}</see>" },
                { new Regex(@"(.*?)(?<block>\{\{term\((?<contents>.*?)\)\}\})(.*?)"), (string s) => $"<i>{s}</i>" },
                { new Regex(@"(.*?)(?<block>\{\{termplural\((?<contents>.*?)\)\}\})(.*?)"), (string s) =>$"<i>{s}</i>s" },
                { new Regex(@"(.*?)(?<block>\*(?<contents>.*?)\*)(.*?)"), (string s) => $"<i>{s}</i>" },
                { new Regex(@"(.*?)(?<block>\{\{url\((?<contents>.*?)\)\}\}(.*?))(.*?)"), (string s) => $"<see href=\"{s}\">{s}</see>" },
                { new Regex(@"(.*?)(?<block>\{\{def\((?<contents>.*?)\)\}\}(.*?))(.*?)"), (string s) => $"<see cref=\"{s.Replace(":", ".")}\" />" },
                { new Regex(@"(.*?)(?<block>\{\{property\((?<contents>.*?)\)\}\}(.*?))(.*?)"), (string s) =>
                    {
                        string[] parts = s.Split(',');
                        if (parts.Length > 1)
                            return $"<see cref=\"{s.Replace(",", ".")}\">{parts[parts.Length - 1]} in {parts[0]}</see>";
                        else
                            return $"<see cref=\"{s}\" />";
                    }
                },
                // NOTE: This uses Google's "I'm feeling lucky" URL parameter
                { new Regex(@"(.*?)(?<block>\{\{cite\((?<contents>.*?)\)\}\})(.*?)"), (string s) => $"<seealso href=\"https://www.google.com/search?q={s}&btnI=I\">{s}</seealso>" },
                { new Regex(@"(.*?)(?<block>\{\{sect\((?<contents>.*?)\)\}\})(.*?)"), (string s) => $"<see cref=\"{s}\">{s}</see>" },
                { new Regex(@"(.*?)(?<block>\{\{package\((?<contents>.*?)\)\}\})(.*?)"), (string s) => $"<see cref=\"{s}\">{s}</see>" },
                { new Regex(@"(.*?)(?<block>\$\$(?<contents>.*?)\$\$)(.*?)"), (string s) => $"<i>{s}</i>" },
                { new Regex(@"(.*?)(?<block>\{\{newpage\(\)\}\}(?<contents>.*?))(.*?)"), (string s) => $"<!-- UNHANDLED MARKDOWN: newpage({s}) -->" },
                { new Regex(@"(.*?)(?<block>\{\{newacronym\{(?<acronym1>.*?)\}\{(?<contents>.*?)\}\{(?<definition>.*?)\}\(\)\}\})(.*?)"), (string s) => $"<i>{s}</i>" },
                { new Regex(@"(.*?)(?<block>\{\{appendix\((?<contents>.*?)\)\}\})(.*?)"), (string s) => $"<!-- UNHANDLED MARKDOWN: appendix({s}) -->" },
                { new Regex(@"(.*?)(?<block>\{\{section\*\((?<contents>.*?)\)\}\})(.*?)"), (string s) => $"<!-- UNHANDLED MARKDOWN: section*({s}) -->" },
                { new Regex(@"(.*?)(?<block>\{\{addcontentsline(?<contents>.*?)\}\})(.*?)"), (string s) => $"<!-- UNHANDLED MARKDOWN: addcontentsline{s} -->" },
                { new Regex(@"(.*?)(?<block>\{\{input(?<contents>.*?)\}\})(.*?)"), (string s) => $"<!-- UNHANDLED MARKDOWN: input{s} -->" },
                { new Regex(@"(.*?)(?<block>\{\{renewcommand(?<contents>.*?)\}\})(.*?)"), (string s) => $"<!-- UNHANDLED MARKDOWN: renewcommand{s} -->" },
            };

            string output = markdown;

            foreach (var rule in rules)
            {
                var matches = rule.Key.Matches(output);
                foreach (Match match in matches)
                {
                    string block = match.Groups["block"].Value;
                    string contents = match.Groups["contents"].Value;
                    output = output.Replace(block, rule.Value(contents));
                }
            }

            return output;
        }

        /// <summary>
        /// Array of invalid characters for C# types. Initialized with those returned from <see cref="System.IO.Path.GetInvalidFileNameChars"/>.
        /// </summary>
        public static char[] InvalidCharacters { get; set; } = System.IO.Path
            .GetInvalidFileNameChars()
            .Concat(new char[] { ' ' })
            .ToArray();
        /// <summary>
        /// Regular expression to replace the <see cref="InvalidCharacters"/>
        /// </summary>
        public static Regex ReplaceInvalidChars { get; set; } = new Regex(@"\" + String.Join(@"|\", InvalidCharacters), RegexOptions.Compiled);
        /// <summary>
        /// Replaces invalid filename characters with the <paramref name="replaceBy"/> character
        /// </summary>
        /// <param name="input">Input string</param>
        /// <param name="replaceBy">Character to replace invalid characters</param>
        /// <returns>String considered to be code-safe</returns>
        public static string ToCodeSafe(string input, string replaceBy = DEFAULT_CODE_SAFE_REPLACEMENT) => ReplaceInvalidChars.Replace(input, replaceBy);

        /// <inheritdoc cref="string.ToUpper()"/>
        public static string ToUpperCase(string input) => input.ToUpper();

        /// <inheritdoc cref="string.ToLower()"/>
        public static string ToLowerCase(string input) => input.ToLower();

        /// <summary></summary>
        /// <param name="input"></param>
        /// <returns><c>"The Quick Brown Fox"</c> => <c>"TheQuickBrownFox"</c></returns>
        public static string ToPascalCase(string input) => CaseExtensions.StringExtensions.ToPascalCase(input);

        /// <inheritdoc cref="ToPascalCase(string)" />
        /// <remarks><inheritdoc cref="ToCodeSafe(string, string)" path="/summary"/></remarks>
        public static string ToPascalCode(string input, string replaceBy = DEFAULT_CODE_SAFE_REPLACEMENT) => ToCodeSafe(ToPascalCase(input), replaceBy);

        /// <summary></summary>
        /// <param name="input"></param>
        /// <returns><c>"The Quick Brown Fox"</c> => <c>"theQuickBrownFox"</c></returns>
        public static string ToCamelCase(string input) => CaseExtensions.StringExtensions.ToCamelCase(input);

        /// <inheritdoc cref="ToCamelCase(string)" />
        /// <remarks><inheritdoc cref="ToCodeSafe(string, string)" path="/summary"/></remarks>
        public static string ToCamelCode(string input, string replaceBy = DEFAULT_CODE_SAFE_REPLACEMENT) => ToCodeSafe(ToCamelCase(input), replaceBy);

        /// <summary></summary>
        /// <param name="input"></param>
        /// <returns><c>"The Quick Brown Fox"</c> => <c>"the_quick_brown_fox"</c></returns>
        public static string ToSnakeCase(string input)
        {
            const string MTConnect = "MTConnect";
            if (string.IsNullOrEmpty(input)) return input;

            var sb = new StringBuilder();

            int startIndex = 1;
            if (input.StartsWith(MTConnect, StringComparison.OrdinalIgnoreCase))
            {
                startIndex = MTConnect.Length;
                sb.Append(MTConnect);
            }
            else
            {
                sb.Append(char.ToLower(input[0]));
            }

            for (var i = startIndex; i < input.Length; i++)
            {
                if (char.IsUpper(input[i]))
                {
                    if (i > 1 && !char.IsUpper(input[i - 1]))
                    {
                        sb.Append("_");
                    }
                    else if (i < input.Length - 1 && !char.IsUpper(input[i + 1]))
                    {
                        sb.Append("_");
                    }
                }
                sb.Append(char.ToLower(input[i]));
            }

            return sb.ToString();
        }

        /// <inheritdoc cref="ToSnakeCase(string)" />
        /// <remarks><inheritdoc cref="ToCodeSafe(string, string)" path="/summary"/></remarks>
        public static string ToSnakeCode(string input, string replaceBy = DEFAULT_CODE_SAFE_REPLACEMENT) => ToCodeSafe(ToSnakeCase(input), replaceBy);

        /// <inheritdoc cref="ToSnakeCode(string, string)" />
        /// <remarks><inheritdoc cref="ToCodeSafe(string, string)" path="/summary"/> and <inheritdoc cref="ToUpperCase(string)" path="/summary"/> </remarks>
        public static string ToUpperSnakeCode(string input, string replaceBy = DEFAULT_CODE_SAFE_REPLACEMENT) => ToSnakeCode(input, replaceBy).ToUpper();

        /// <inheritdoc cref="ToSnakeCode(string, string)" />
        /// <remarks><inheritdoc cref="ToCodeSafe(string, string)" path="/summary"/> and <inheritdoc cref="ToLowerCase(string)" path="/summary"/> </remarks>
        public static string ToLowerSnakeCode(string input, string replaceBy = DEFAULT_CODE_SAFE_REPLACEMENT) => ToSnakeCode(input, replaceBy).ToLower();

        /// <summary></summary>
        /// <param name="input"></param>
        /// <returns><c>"The Quick Brown Fox"</c> => <c>"the-quick-brown-fox"</c></returns>
        public static string ToKebabCase(string input) => CaseExtensions.StringExtensions.ToKebabCase(input);

        /// <inheritdoc cref="ToKebabCase(string)" />
        /// <remarks><inheritdoc cref="ToCodeSafe(string, string)" path="/summary"/></remarks>
        public static string ToKebabCode(string input, string replaceBy = DEFAULT_CODE_SAFE_REPLACEMENT) => ToCodeSafe(ToKebabCase(input), replaceBy);

        /// <inheritdoc cref="ToKebabCode(string, string)" />
        /// <remarks><inheritdoc cref="ToCodeSafe(string, string)" path="/summary"/> and <inheritdoc cref="ToUpperCase(string)" path="/summary"/> </remarks>
        public static string ToUpperKebabCode(string input, string replaceBy = DEFAULT_CODE_SAFE_REPLACEMENT) => ToKebabCode(input, replaceBy).ToUpper();

        /// <inheritdoc cref="ToKebabCode(string, string)" />
        /// <remarks><inheritdoc cref="ToCodeSafe(string, string)" path="/summary"/> and <inheritdoc cref="ToLowerCase(string)" path="/summary"/> </remarks>
        public static string ToLowerKebabCode(string input, string replaceBy = DEFAULT_CODE_SAFE_REPLACEMENT) => ToKebabCode(input, replaceBy).ToLower();

        /// <summary></summary>
        /// <param name="input"></param>
        /// <returns><c>"The Quick Brown Fox"</c> => <c>"The-Quick-Brown-Fox"</c></returns>
        public static string ToTrainCase(string input) => CaseExtensions.StringExtensions.ToTrainCase(input);

        /// <inheritdoc cref="ToTrainCase(string)" />
        /// <remarks><inheritdoc cref="ToCodeSafe(string, string)" path="/summary"/></remarks>
        public static string ToTrainCode(string input, string replaceBy = DEFAULT_CODE_SAFE_REPLACEMENT) => ToCodeSafe(ToTrainCase(input), replaceBy);

        /// <inheritdoc cref="ToTrainCode(string, string)" />
        /// <remarks><inheritdoc cref="ToCodeSafe(string, string)" path="/summary"/> and <inheritdoc cref="ToUpperCase(string)" path="/summary"/> </remarks>
        public static string ToUpperTrainCode(string input, string replaceBy = DEFAULT_CODE_SAFE_REPLACEMENT) => ToTrainCode(input, replaceBy).ToUpper();

        /// <inheritdoc cref="ToTrainCode(string, string)" />
        /// <remarks><inheritdoc cref="ToCodeSafe(string, string)" path="/summary"/> and <inheritdoc cref="ToLowerCase(string)" path="/summary"/> </remarks>
        public static string ToLowerTrainCode(string input, string replaceBy = DEFAULT_CODE_SAFE_REPLACEMENT) => ToTrainCode(input, replaceBy).ToLower();
    }
}
