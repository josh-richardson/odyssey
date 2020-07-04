using Odyssey.controls;

namespace Odyssey.UI.Controls
{
    partial class OdysseyToolStrip
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdysseyToolStrip));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.BtnAlignLeft = new Odyssey.UI.Controls.TextCustomizationButton();
            this.btnAlignCenter = new Odyssey.UI.Controls.TextCustomizationButton();
            this.btnAlignRight = new Odyssey.UI.Controls.TextCustomizationButton();
            this.btnAlignJustify = new Odyssey.UI.Controls.TextCustomizationButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBold = new Odyssey.UI.Controls.TextCustomizationButton();
            this.btnItalic = new Odyssey.UI.Controls.TextCustomizationButton();
            this.btnUnderline = new Odyssey.UI.Controls.TextCustomizationButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnToggleIndent = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnTextStyle = new System.Windows.Forms.ToolStripDropDownButton();
            this._titleItem = new Odyssey.controls.TextCustomizationItem();
            this._subtitleItem = new Odyssey.controls.TextCustomizationItem();
            this._paragraphItem = new Odyssey.controls.TextCustomizationItem();
            this.cbxFonts = new System.Windows.Forms.ToolStripComboBox();
            this.btnDarkMode = new System.Windows.Forms.ToolStripButton();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnAlignLeft,
            this.btnAlignCenter,
            this.btnAlignRight,
            this.btnAlignJustify,
            this.toolStripSeparator1,
            this.btnBold,
            this.btnItalic,
            this.btnUnderline,
            this.toolStripSeparator3,
            this.btnToggleIndent,
            this.toolStripSeparator2,
            this.btnTextStyle,
            this.cbxFonts,
            this.btnDarkMode});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(731, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // BtnAlignLeft
            // 
            this.BtnAlignLeft.CheckOnClick = true;
            this.BtnAlignLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnAlignLeft.FontStyle = null;
            this.BtnAlignLeft.Image = ((System.Drawing.Image)(resources.GetObject("BtnAlignLeft.Image")));
            this.BtnAlignLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAlignLeft.Name = "BtnAlignLeft";
            this.BtnAlignLeft.Size = new System.Drawing.Size(23, 22);
            this.BtnAlignLeft.Text = "Align Left";
            this.BtnAlignLeft.TextAlignment = ExtendedRichTextBox.RichTextAlign.Left;
            this.BtnAlignLeft.ToolTipText = "Align Left";
            // 
            // btnAlignCenter
            // 
            this.btnAlignCenter.CheckOnClick = true;
            this.btnAlignCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAlignCenter.FontStyle = null;
            this.btnAlignCenter.Image = ((System.Drawing.Image)(resources.GetObject("btnAlignCenter.Image")));
            this.btnAlignCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlignCenter.Name = "btnAlignCenter";
            this.btnAlignCenter.Size = new System.Drawing.Size(23, 22);
            this.btnAlignCenter.Text = "Align Center";
            this.btnAlignCenter.TextAlignment = ExtendedRichTextBox.RichTextAlign.Center;
            this.btnAlignCenter.ToolTipText = "Align Center";
            // 
            // btnAlignRight
            // 
            this.btnAlignRight.CheckOnClick = true;
            this.btnAlignRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAlignRight.FontStyle = null;
            this.btnAlignRight.Image = ((System.Drawing.Image)(resources.GetObject("btnAlignRight.Image")));
            this.btnAlignRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlignRight.Name = "btnAlignRight";
            this.btnAlignRight.Size = new System.Drawing.Size(23, 22);
            this.btnAlignRight.Text = "Align Right";
            this.btnAlignRight.TextAlignment = ExtendedRichTextBox.RichTextAlign.Right;
            this.btnAlignRight.ToolTipText = "Align Right";
            // 
            // btnAlignJustify
            // 
            this.btnAlignJustify.CheckOnClick = true;
            this.btnAlignJustify.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAlignJustify.FontStyle = null;
            this.btnAlignJustify.Image = ((System.Drawing.Image)(resources.GetObject("btnAlignJustify.Image")));
            this.btnAlignJustify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlignJustify.Name = "btnAlignJustify";
            this.btnAlignJustify.Size = new System.Drawing.Size(23, 22);
            this.btnAlignJustify.Text = "Align Justify";
            this.btnAlignJustify.TextAlignment = ExtendedRichTextBox.RichTextAlign.Justify;
            this.btnAlignJustify.ToolTipText = "Align Justify";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnBold
            // 
            this.btnBold.CheckOnClick = true;
            this.btnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBold.FontStyle = System.Drawing.FontStyle.Bold;
            this.btnBold.Image = ((System.Drawing.Image)(resources.GetObject("btnBold.Image")));
            this.btnBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(23, 22);
            this.btnBold.Text = "Align Unknown";
            this.btnBold.TextAlignment = ExtendedRichTextBox.RichTextAlign.Unknown;
            this.btnBold.ToolTipText = "Align Unknown";
            // 
            // btnItalic
            // 
            this.btnItalic.CheckOnClick = true;
            this.btnItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnItalic.FontStyle = System.Drawing.FontStyle.Italic;
            this.btnItalic.Image = ((System.Drawing.Image)(resources.GetObject("btnItalic.Image")));
            this.btnItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(23, 22);
            this.btnItalic.Text = "Align Unknown";
            this.btnItalic.TextAlignment = ExtendedRichTextBox.RichTextAlign.Unknown;
            this.btnItalic.ToolTipText = "Align Unknown";
            // 
            // btnUnderline
            // 
            this.btnUnderline.CheckOnClick = true;
            this.btnUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUnderline.FontStyle = System.Drawing.FontStyle.Underline;
            this.btnUnderline.Image = ((System.Drawing.Image)(resources.GetObject("btnUnderline.Image")));
            this.btnUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(23, 22);
            this.btnUnderline.Text = "Align Unknown";
            this.btnUnderline.TextAlignment = ExtendedRichTextBox.RichTextAlign.Unknown;
            this.btnUnderline.ToolTipText = "Align Unknown";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnToggleIndent
            // 
            this.btnToggleIndent.Checked = true;
            this.btnToggleIndent.CheckOnClick = true;
            this.btnToggleIndent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnToggleIndent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnToggleIndent.Image = ((System.Drawing.Image)(resources.GetObject("btnToggleIndent.Image")));
            this.btnToggleIndent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnToggleIndent.Name = "btnToggleIndent";
            this.btnToggleIndent.Size = new System.Drawing.Size(23, 22);
            this.btnToggleIndent.Text = "Toggle Indent";
            this.btnToggleIndent.Click += new System.EventHandler(this.btnToggleIndent_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnTextStyle
            // 
            this.btnTextStyle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._titleItem,
            this._subtitleItem,
            this._paragraphItem});
            this.btnTextStyle.Image = ((System.Drawing.Image)(resources.GetObject("btnTextStyle.Image")));
            this.btnTextStyle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTextStyle.Name = "btnTextStyle";
            this.btnTextStyle.Size = new System.Drawing.Size(90, 22);
            this.btnTextStyle.Text = "Paragraph";
            this.btnTextStyle.ToolTipText = "Font Size";
            // 
            // _titleItem
            // 
            this._titleItem.Image = ((System.Drawing.Image)(resources.GetObject("_titleItem.Image")));
            this._titleItem.Name = "_titleItem";
            this._titleItem.Size = new System.Drawing.Size(128, 22);
            this._titleItem.Text = "Title";
            this._titleItem.TextAlignment = ExtendedRichTextBox.RichTextAlign.Unknown;
            this._titleItem.TextSize = 48;
            // 
            // _subtitleItem
            // 
            this._subtitleItem.Image = ((System.Drawing.Image)(resources.GetObject("_subtitleItem.Image")));
            this._subtitleItem.Name = "_subtitleItem";
            this._subtitleItem.Size = new System.Drawing.Size(128, 22);
            this._subtitleItem.Text = "Subtitle";
            this._subtitleItem.TextAlignment = ExtendedRichTextBox.RichTextAlign.Unknown;
            this._subtitleItem.TextSize = 30;
            // 
            // _paragraphItem
            // 
            this._paragraphItem.Image = ((System.Drawing.Image)(resources.GetObject("_paragraphItem.Image")));
            this._paragraphItem.Name = "_paragraphItem";
            this._paragraphItem.Size = new System.Drawing.Size(128, 22);
            this._paragraphItem.Text = "Paragraph";
            this._paragraphItem.TextAlignment = ExtendedRichTextBox.RichTextAlign.Unknown;
            this._paragraphItem.TextSize = 14;
            // 
            // cbxFonts
            // 
            this.cbxFonts.Name = "cbxFonts";
            this.cbxFonts.Size = new System.Drawing.Size(200, 25);
            this.cbxFonts.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFonts_SelectedIndexChanged);
            // 
            // btnDarkMode
            // 
            this.btnDarkMode.CheckOnClick = true;
            this.btnDarkMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDarkMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDarkMode.Name = "btnDarkMode";
            this.btnDarkMode.Size = new System.Drawing.Size(69, 22);
            this.btnDarkMode.Text = "Dark Mode";
            // 
            // OdysseyToolStrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip);
            this.Name = "OdysseyToolStrip";
            this.Size = new System.Drawing.Size(731, 25);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private TextCustomizationButton BtnAlignLeft;
        private TextCustomizationButton btnAlignCenter;
        private TextCustomizationButton btnAlignRight;
        private TextCustomizationButton btnAlignJustify;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private TextCustomizationButton btnBold;
        private TextCustomizationButton btnItalic;
        private TextCustomizationButton btnUnderline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton btnTextStyle;
        private TextCustomizationItem _titleItem;
        private TextCustomizationItem _subtitleItem;
        private TextCustomizationItem _paragraphItem;
        private System.Windows.Forms.ToolStripComboBox cbxFonts;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnToggleIndent;
        private System.Windows.Forms.ToolStripButton btnDarkMode;
    }
}
