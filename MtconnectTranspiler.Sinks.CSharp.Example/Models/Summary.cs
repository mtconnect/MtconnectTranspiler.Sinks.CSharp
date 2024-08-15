using MtconnectTranspiler.CodeGenerators.ScribanTemplates;
using MtconnectTranspiler.Interpreters;
using MtconnectTranspiler.Xmi;
using System.Text;
using System.Text.RegularExpressions;

namespace MtconnectTranspiler.Sinks.CSharp.Models
{
    /// <summary>
    /// Represents a code documentation block <c>&lt;summary /&gt;</c>
    /// </summary>
    [ScribanTemplate("UmlCommentsSummaryContent.scriban")]
    public class Summary
    {
        /// <summary>
        /// Collection of separate <c>&lt;summary /&gt;</c> contents
        /// </summary>
        public SummaryItem[] Items { get; }

        public string OriginalValue { get; }

        /// <summary>
        /// Constructs a <c>&lt;summary /&gt;</c>
        /// </summary>
        /// <param name="comments"><inheritdoc cref="OwnedComment" path="/summary"/></param>
        public Summary(OwnedComment[] comments)
        {
            Items = comments?.Select(o => new SummaryItem(o))?.ToArray();

            StringBuilder sb = new StringBuilder();
            foreach (var item in Items)
            {
                sb.AppendLine(composeComment(item._source));
            }
            OriginalValue = sb.ToString();
        }

        private string composeComment(OwnedComment comment)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("&#10;" + comment.Name + "&#10;");
            sb.AppendLine("&#10;" + comment.Body + "&#10;");
            if (comment.SubComment != null)
            {
                sb.AppendLine(composeComment(comment.SubComment));
            }
            return sb.ToString();
        }

        public string ToXmlSummary(VisualStudioSummaryInterpreter interpreter)
            => interpreter.Interpret(Items.Select(o => o._source).ToArray());

        /// <inheritdoc />
        public override string ToString()
            => OriginalValue;
    }
}
