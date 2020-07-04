﻿using System.Drawing;
using System.Windows.Forms;

namespace Odyssey.UI.Controls
{
    internal class TextCustomizationButton : ToolStripButton
    {
        private FontStyle? _fontStyle;
        private ExtendedRichTextBox.RichTextAlign _textAlignment = ExtendedRichTextBox.RichTextAlign.Unknown;

        public ExtendedRichTextBox.RichTextAlign TextAlignment
        {
            get => _textAlignment;
            set
            {
                _textAlignment = value;
                if (value == ExtendedRichTextBox.RichTextAlign.Unknown) return;
                ToolTipText = Text = $"Align {value}";
            }
        }

        public FontStyle? FontStyle
        {
            get => _fontStyle;
            set
            {
                _fontStyle = value;
                ToolTipText = Text = value.ToString();
            }
        }
    }
}