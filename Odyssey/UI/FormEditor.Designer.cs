using Odyssey.UI.Controls;

namespace Odyssey.UI
{
    partial class FormEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ExtendedRichTextBox.CharStyle charStyle1 = new ExtendedRichTextBox.CharStyle();
            ExtendedRichTextBox.ParaLineSpacing paraLineSpacing1 = new ExtendedRichTextBox.ParaLineSpacing();
            ExtendedRichTextBox.ParaListStyle paraListStyle1 = new ExtendedRichTextBox.ParaListStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditor));
            this.panelLeftIndent = new System.Windows.Forms.Panel();
            this.panelRightIndent = new System.Windows.Forms.Panel();
            this.panelTextContainer = new System.Windows.Forms.Panel();
            this.textBox = new ExtendedRichTextBox();
            this.odysseyToolStrip1 = new Odyssey.UI.Controls.OdysseyToolStrip();
            this.odysseyStatusStrip1 = new Odyssey.UI.Controls.OdysseyStatusStrip();
            this.panelTextContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeftIndent
            // 
            this.panelLeftIndent.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftIndent.Location = new System.Drawing.Point(0, 25);
            this.panelLeftIndent.Name = "panelLeftIndent";
            this.panelLeftIndent.Size = new System.Drawing.Size(80, 514);
            this.panelLeftIndent.TabIndex = 4;
            // 
            // panelRightIndent
            // 
            this.panelRightIndent.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRightIndent.Location = new System.Drawing.Point(704, 25);
            this.panelRightIndent.Name = "panelRightIndent";
            this.panelRightIndent.Size = new System.Drawing.Size(80, 514);
            this.panelRightIndent.TabIndex = 5;
            // 
            // panelTextContainer
            // 
            this.panelTextContainer.AutoSize = true;
            this.panelTextContainer.BackColor = System.Drawing.Color.White;
            this.panelTextContainer.Controls.Add(this.textBox);
            this.panelTextContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTextContainer.Location = new System.Drawing.Point(80, 25);
            this.panelTextContainer.Name = "panelTextContainer";
            this.panelTextContainer.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panelTextContainer.Size = new System.Drawing.Size(624, 514);
            this.panelTextContainer.TabIndex = 8;
            // 
            // textBox
            // 
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(0, 10);
            this.textBox.Name = "textBox";
            charStyle1.Bold = false;
            charStyle1.Italic = false;
            charStyle1.Link = false;
            charStyle1.Strikeout = false;
            charStyle1.Underline = false;
            this.textBox.SelectionCharStyle = charStyle1;
            this.textBox.SelectionFont2 = new System.Drawing.Font("Calibri", 3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch);
            paraLineSpacing1.ExactSpacing = 0;
            paraLineSpacing1.SpacingStyle = ExtendedRichTextBox.ParaLineSpacing.LineSpacingStyle.Unknown;
            this.textBox.SelectionLineSpacing = paraLineSpacing1;
            paraListStyle1.BulletCharCode = ((short)(0));
            paraListStyle1.NumberingStart = ((short)(0));
            paraListStyle1.Style = ExtendedRichTextBox.ParaListStyle.ListStyle.NumberAndParenthesis;
            paraListStyle1.Type = ExtendedRichTextBox.ParaListStyle.ListType.None;
            this.textBox.SelectionListType = paraListStyle1;
            this.textBox.SelectionOffsetType = ExtendedRichTextBox.OffsetType.None;
            this.textBox.SelectionSpaceAfter = 0;
            this.textBox.SelectionSpaceBefore = 0;
            this.textBox.Size = new System.Drawing.Size(624, 494);
            this.textBox.TabIndex = 8;
            this.textBox.Text = "";
            // 
            // odysseyToolStrip1
            // 
            this.odysseyToolStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.odysseyToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.odysseyToolStrip1.Name = "odysseyToolStrip1";
            this.odysseyToolStrip1.Size = new System.Drawing.Size(784, 25);
            this.odysseyToolStrip1.TabIndex = 3;
            // 
            // odysseyStatusStrip1
            // 
            this.odysseyStatusStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.odysseyStatusStrip1.Location = new System.Drawing.Point(0, 539);
            this.odysseyStatusStrip1.Name = "odysseyStatusStrip1";
            this.odysseyStatusStrip1.Size = new System.Drawing.Size(784, 22);
            this.odysseyStatusStrip1.TabIndex = 6;
            // 
            // FormEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panelTextContainer);
            this.Controls.Add(this.panelRightIndent);
            this.Controls.Add(this.panelLeftIndent);
            this.Controls.Add(this.odysseyToolStrip1);
            this.Controls.Add(this.odysseyStatusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEditor";
            this.Text = "Odyssey";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEditor_FormClosed);
            this.Load += new System.EventHandler(this.FormEditor_Load);
            this.Resize += new System.EventHandler(this.FormEditor_Resize);
            this.panelTextContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private OdysseyToolStrip odysseyToolStrip1;
        private System.Windows.Forms.Panel panelLeftIndent;
        private System.Windows.Forms.Panel panelRightIndent;
        private OdysseyStatusStrip odysseyStatusStrip1;
        private ExtendedRichTextBox textBox;
        private System.Windows.Forms.Panel panelTextContainer;
    }
}

