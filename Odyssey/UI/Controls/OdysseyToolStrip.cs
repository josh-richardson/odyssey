using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MoreLinq;
using Odyssey.controls;

namespace Odyssey.UI.Controls
{
    public partial class OdysseyToolStrip : UserControl
    {
        private IEnumerable<TextCustomizationButton> _alignmentItems;
        private IEnumerable<TextCustomizationButton> _fontStyleItems;
        private List<Panel> _indentPanels;
        private bool _initialized;
        private ExtendedRichTextBox _textBox;

        public OdysseyToolStrip()
        {
            InitializeComponent();
        }

        public void Initialize(ExtendedRichTextBox textBox, List<Panel> indentPanels, Func<bool> toggleDarkMode)
        {
            _indentPanels = indentPanels;
            _textBox = textBox;
            _textBox.SelectionChanged += TextBox_SelectionChanged;

            cbxFonts.Visible = false;
            cbxFonts.ComboBox.DataSource = FontFamily.Families.ToList();
            cbxFonts.ComboBox.DisplayMember = "Name";
            cbxFonts.ComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            cbxFonts.ComboBox.DrawItem += (sender, e) =>
            {
                var comboBox = (ComboBox) sender;
                var fontFamily = (FontFamily) comboBox.Items[e.Index];
                var font = new Font(fontFamily, comboBox.Font.SizeInPoints);
                e.DrawBackground();
                e.Graphics.DrawString(font.Name, font, Brushes.Black, e.Bounds.X, e.Bounds.Y);
            };

            btnTextStyle.DropDownItems.Cast<ToolStripItem>().ForEach(item =>
            {
                item.Click += (sender, e) =>
                {
                    var castSender = (TextCustomizationItem) sender;
                    _textBox.SelectionFont = new Font(_textBox.SelectionFont.Name, castSender.TextSize,
                        _textBox.SelectionFont.Style);
                    btnTextStyle.Text = castSender.Text;
                    btnTextStyle.Image = castSender.Image;
                };
            });

            _alignmentItems = toolStrip.Items.Cast<ToolStripItem>().OfType<TextCustomizationButton>()
                .Where(i => i.TextAlignment != ExtendedRichTextBox.RichTextAlign.Unknown);

            _fontStyleItems = toolStrip.Items.Cast<ToolStripItem>().OfType<TextCustomizationButton>()
                .Where(i => i.FontStyle != null);

            _alignmentItems.ForEach(item =>
            {
                item.Click += (sender, e) =>
                {
                    var button = (TextCustomizationButton) sender;
                    _textBox.SelectionAlignment = button.TextAlignment;
                    _alignmentItems.ForEach(j => j.Checked = false);
                    button.Checked = true;
                };
            });

            _fontStyleItems.ForEach(item =>
            {
                item.Click += (sender, e) =>
                {
                    var button = (TextCustomizationButton) sender;
                    _textBox.SelectionFont = new Font(_textBox.SelectionFont,
                        _textBox.SelectionFont.Style | (button.FontStyle ?? FontStyle.Regular));
                    button.Checked = true;
                };
            });

            btnDarkMode.Click += (sender, e) => toggleDarkMode();

            _initialized = true;
        }

        private void ComboBoxFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_initialized || cbxFonts.SelectedItem == null) return;
            cbxFonts.Visible = true;
            _textBox.SelectionFont = new Font((FontFamily) cbxFonts.SelectedItem,
                _textBox.SelectionFont.SizeInPoints);
        }


        private void TextBox_SelectionChanged(object sender, EventArgs e)
        {
            Enabled = _textBox.SelectionFont != null;
            if (_textBox.SelectionFont == null) return;

            cbxFonts.SelectedIndex = cbxFonts.FindStringExact(_textBox.SelectionFont.Name);

            var relevantButton = btnTextStyle.DropDownItems.Cast<TextCustomizationItem>()
                .FirstOrDefault(i => Math.Abs(_textBox.SelectionFont.Size - i.TextSize) < 1);

            btnTextStyle.Text = relevantButton?.Text ?? "Custom";
            btnTextStyle.Image = relevantButton?.Image;

            _alignmentItems.ForEach(i => i.Checked = false);

            var checkedItem = _alignmentItems.FirstOrDefault(i => i.TextAlignment == _textBox.SelectionAlignment);
            if (checkedItem != null) checkedItem.Checked = true;

            _fontStyleItems.ForEach(i => { i.Checked = _textBox.SelectionFont.Style.HasFlag(i.FontStyle); });


            BeginInvoke(new Action(() => { cbxFonts.Select(0, 0); }));
        }

        private void btnToggleIndent_Click(object sender, EventArgs e)
        {
            _indentPanels.ForEach(i => i.Visible = !i.Visible);
        }


        private static IEnumerable<string> SplitIntoLines(string input, int maxLineLength)
        {
            //SplitIntoLines(_textBox.Text, 120).ForEach(i => Console.WriteLine(i + ", " + GibberishClassification.GibberishClassifier.Classify(i)));
            var charCount = 0;
            return input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .GroupBy(w => (charCount += w.Length + 1) / maxLineLength)
                .Select(g => Regex.Replace(string.Join(" ", g), @"\r\n?|\n", " ")).ToArray();
        }
    }
}