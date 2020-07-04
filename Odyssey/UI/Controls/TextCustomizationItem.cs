using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
