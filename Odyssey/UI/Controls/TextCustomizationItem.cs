using System.Windows.Forms;

namespace Odyssey.controls
{
    internal class TextCustomizationItem : ToolStripMenuItem
    {
        public int TextSize { get; set; }

        public ExtendedRichTextBox.RichTextAlign TextAlignment { get; set; } =
            ExtendedRichTextBox.RichTextAlign.Unknown;
    }
}