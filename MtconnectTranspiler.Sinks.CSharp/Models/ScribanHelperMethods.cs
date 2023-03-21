using CE = CaseExtensions;
using Scriban.Runtime;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System;
using System.Linq;
using MtconnectTranspiler.Xmi.UML;

namespace MtconnectTranspiler.Sinks.CSharp.Models
{
    public class ScribanHelperMethods : ScriptObject
    {
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
        /// Gets the C# equivalant of the UmlDataType.
        /// </summary>
        /// <param name="dataType">Reference to the packaged UML DataType</param>
        /// <returns>Primitive type. Returns null if unrecognizes or unhandled DataType</returns>
        public static Type ToPrimitiveType(UmlDataType dataType)
        {
            if (umlDataTypeToCSharp.TryGetValue(dataType.Name, out Type type))
                return type;
            return null;
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
                { new Regex(@"(.*?)(?<block>`(?<contents>.*?)`)(.*?)"), (string s) => $"<c>{s}</c>" },
                { new Regex(@"(.*?)(?<block>\*\*(?<contents>.*?)\*\*)(.*?)"), (string s) => $"<b>{s}</b>" },
                { new Regex(@"(.*?)(?<block>\{\{block\((?<contents>.*?)\)\}\})(.*?)"), (string s) => $"<see cref=\"{s}\">{s}</see>" },
                { new Regex(@"(.*?)(?<block>\{\{term\((?<contents>.*?)\)\}\})(.*?)"), (string s) => $"<i>{s}</i>" },
                { new Regex(@"(.*?)(?<block>\*(?<contents>.*?)\*)(.*?)"), (string s) => $"<i>{s}</i>" }
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

        public static char[] InvalidCharacters { get; set; } = System.IO.Path
            .GetInvalidFileNameChars()
            .Concat(new char[] { ' ' })
            .ToArray();
        public static Regex ReplaceInvalidChars { get; set; } = new Regex(@"\" + String.Join(@"|\", InvalidCharacters), RegexOptions.Compiled);
        public static string ToCodeSafe(string input, string replaceBy = "_") => ReplaceInvalidChars.Replace(input, replaceBy);

        public static string ToUpperCase(string input) => input.ToUpper();

        public static string ToLowerCase(string input) => input.ToLower();

        /// <summary></summary>
        /// <param name="input"></param>
        /// <returns><c>"The Quick Brown Fox"</c> => <c>"TheQuickBrownFox"</c></returns>
        public static string ToPascalCase(string input) => CaseExtensions.StringExtensions.ToPascalCase(input);

        public static string ToPascalCode(string input) => ToCodeSafe(ToPascalCase(input));

        /// <summary></summary>
        /// <param name="input"></param>
        /// <returns><c>"The Quick Brown Fox"</c> => <c>"theQuickBrownFox"</c></returns>
        public static string ToCamelCase(string input) => CaseExtensions.StringExtensions.ToCamelCase(input);

        public static string ToCamelCode(string input) => ToCodeSafe(ToCamelCase(input));

        /// <summary></summary>
        /// <param name="input"></param>
        /// <returns><c>"The Quick Brown Fox"</c> => <c>"the_quick_brown_fox"</c></returns>
        public static string ToSnakeCase(string input) => CaseExtensions.StringExtensions.ToSnakeCase(input);

        public static string ToSnakeCode(string input) => ToCodeSafe(ToSnakeCase(input));

        public static string ToUpperSnakeCode(string input) => ToSnakeCode(input).ToUpper();

        public static string ToLowerSnakeCode(string input) => ToSnakeCode(input).ToLower();

        /// <summary></summary>
        /// <param name="input"></param>
        /// <returns><c>"The Quick Brown Fox"</c> => <c>"the-quick-brown-fox"</c></returns>
        public static string ToKebabCase(string input) => CaseExtensions.StringExtensions.ToKebabCase(input);

        public static string ToKebabCode(string input) => ToCodeSafe(ToKebabCase(input));

        public static string ToUpperKebabCode(string input) => ToKebabCode(input).ToUpper();

        public static string ToLowerKebabCode(string input) => ToKebabCode(input).ToLower();

        /// <summary></summary>
        /// <param name="input"></param>
        /// <returns><c>"The Quick Brown Fox"</c> => <c>"The-Quick-Brown-Fox"</c></returns>
        public static string ToTrainCase(string input) => CaseExtensions.StringExtensions.ToTrainCase(input);

        public static string ToTrainCode(string input) => ToCodeSafe(ToTrainCase(input));

        public static string ToUpperTrainCode(string input) => ToTrainCode(input).ToUpper();

        public static string ToLowerTrainCode(string input) => ToTrainCode(input).ToLower();
    }
}
