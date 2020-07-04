namespace Odyssey.UI
{
    partial class FormStart
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStart));
            this.chkDisableClipboard = new System.Windows.Forms.CheckBox();
            this.chkPreventExit = new System.Windows.Forms.CheckBox();
            this.chkExcludeGibberish = new System.Windows.Forms.CheckBox();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnFromDraft = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.groupOptions = new System.Windows.Forms.GroupBox();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblWords = new System.Windows.Forms.Label();
            this.numWordGoal = new System.Windows.Forms.NumericUpDown();
            this.numTimePeriod = new System.Windows.Forms.NumericUpDown();
            this.rbWordGoal = new System.Windows.Forms.RadioButton();
            this.rbTimeGoal = new System.Windows.Forms.RadioButton();
            this.pnlActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWordGoal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimePeriod)).BeginInit();
            this.SuspendLayout();
            // 
            // chkDisableClipboard
            // 
            this.chkDisableClipboard.AutoSize = true;
            this.chkDisableClipboard.Location = new System.Drawing.Point(26, 74);
            this.chkDisableClipboard.Name = "chkDisableClipboard";
            this.chkDisableClipboard.Size = new System.Drawing.Size(107, 17);
            this.chkDisableClipboard.TabIndex = 0;
            this.chkDisableClipboard.Tag = "word_group";
            this.chkDisableClipboard.Text = "Disable clipboard";
            this.chkDisableClipboard.UseVisualStyleBackColor = true;
            // 
            // chkPreventExit
            // 
            this.chkPreventExit.AutoSize = true;
            this.chkPreventExit.Location = new System.Drawing.Point(11, 185);
            this.chkPreventExit.Name = "chkPreventExit";
            this.chkPreventExit.Size = new System.Drawing.Size(96, 17);
            this.chkPreventExit.TabIndex = 1;
            this.chkPreventExit.Text = "Prevent exiting";
            this.chkPreventExit.UseVisualStyleBackColor = true;
            // 
            // chkExcludeGibberish
            // 
            this.chkExcludeGibberish.AutoSize = true;
            this.chkExcludeGibberish.Location = new System.Drawing.Point(26, 97);
            this.chkExcludeGibberish.Name = "chkExcludeGibberish";
            this.chkExcludeGibberish.Size = new System.Drawing.Size(126, 17);
            this.chkExcludeGibberish.TabIndex = 2;
            this.chkExcludeGibberish.Tag = "word_group";
            this.chkExcludeGibberish.Text = "Don\'t count gibberish";
            this.chkExcludeGibberish.UseVisualStyleBackColor = true;
            // 
            // pnlActions
            // 
            this.pnlActions.BackColor = System.Drawing.Color.White;
            this.pnlActions.Controls.Add(this.btnFromDraft);
            this.pnlActions.Controls.Add(this.btnStart);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlActions.Location = new System.Drawing.Point(0, 367);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(361, 52);
            this.pnlActions.TabIndex = 3;
            // 
            // btnFromDraft
            // 
            this.btnFromDraft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFromDraft.Location = new System.Drawing.Point(155, 12);
            this.btnFromDraft.Name = "btnFromDraft";
            this.btnFromDraft.Size = new System.Drawing.Size(109, 29);
            this.btnFromDraft.TabIndex = 1;
            this.btnFromDraft.Text = "Start from draft";
            this.btnFromDraft.UseVisualStyleBackColor = true;
            this.btnFromDraft.Click += new System.EventHandler(this.btnFromDraft_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(274, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 29);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Odyssey.Properties.Resources.roman_helmet;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(154, 52);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(186, 55);
            this.lblLogo.TabIndex = 5;
            this.lblLogo.Text = "Odyssey";
            // 
            // groupOptions
            // 
            this.groupOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupOptions.Controls.Add(this.lblMinutes);
            this.groupOptions.Controls.Add(this.lblWords);
            this.groupOptions.Controls.Add(this.numWordGoal);
            this.groupOptions.Controls.Add(this.numTimePeriod);
            this.groupOptions.Controls.Add(this.rbWordGoal);
            this.groupOptions.Controls.Add(this.rbTimeGoal);
            this.groupOptions.Controls.Add(this.chkDisableClipboard);
            this.groupOptions.Controls.Add(this.chkPreventExit);
            this.groupOptions.Controls.Add(this.chkExcludeGibberish);
            this.groupOptions.Location = new System.Drawing.Point(12, 150);
            this.groupOptions.Name = "groupOptions";
            this.groupOptions.Size = new System.Drawing.Size(337, 211);
            this.groupOptions.TabIndex = 6;
            this.groupOptions.TabStop = false;
            this.groupOptions.Text = "Session Options";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Enabled = false;
            this.lblMinutes.Location = new System.Drawing.Point(152, 150);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(43, 13);
            this.lblMinutes.TabIndex = 10;
            this.lblMinutes.Tag = "time_group";
            this.lblMinutes.Text = "minutes";
            // 
            // lblWords
            // 
            this.lblWords.AutoSize = true;
            this.lblWords.Location = new System.Drawing.Point(152, 44);
            this.lblWords.Name = "lblWords";
            this.lblWords.Size = new System.Drawing.Size(35, 13);
            this.lblWords.TabIndex = 9;
            this.lblWords.Tag = "word_group";
            this.lblWords.Text = "words";
            // 
            // numWordGoal
            // 
            this.numWordGoal.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numWordGoal.Location = new System.Drawing.Point(26, 42);
            this.numWordGoal.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numWordGoal.Name = "numWordGoal";
            this.numWordGoal.Size = new System.Drawing.Size(120, 20);
            this.numWordGoal.TabIndex = 8;
            this.numWordGoal.Tag = "word_group";
            // 
            // numTimePeriod
            // 
            this.numTimePeriod.Enabled = false;
            this.numTimePeriod.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTimePeriod.Location = new System.Drawing.Point(26, 148);
            this.numTimePeriod.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numTimePeriod.Name = "numTimePeriod";
            this.numTimePeriod.Size = new System.Drawing.Size(120, 20);
            this.numTimePeriod.TabIndex = 6;
            this.numTimePeriod.Tag = "time_group";
            // 
            // rbWordGoal
            // 
            this.rbWordGoal.AutoSize = true;
            this.rbWordGoal.Checked = true;
            this.rbWordGoal.Location = new System.Drawing.Point(11, 19);
            this.rbWordGoal.Name = "rbWordGoal";
            this.rbWordGoal.Size = new System.Drawing.Size(164, 17);
            this.rbWordGoal.TabIndex = 4;
            this.rbWordGoal.TabStop = true;
            this.rbWordGoal.Text = "Use a word count-based goal";
            this.rbWordGoal.UseVisualStyleBackColor = true;
            this.rbWordGoal.CheckedChanged += new System.EventHandler(this.rbWordGoal_CheckedChanged);
            // 
            // rbTimeGoal
            // 
            this.rbTimeGoal.AutoSize = true;
            this.rbTimeGoal.Location = new System.Drawing.Point(11, 129);
            this.rbTimeGoal.Name = "rbTimeGoal";
            this.rbTimeGoal.Size = new System.Drawing.Size(130, 17);
            this.rbTimeGoal.TabIndex = 3;
            this.rbTimeGoal.Text = "Use a time-based goal";
            this.rbTimeGoal.UseVisualStyleBackColor = true;
            this.rbTimeGoal.CheckedChanged += new System.EventHandler(this.rbTimeGoal_CheckedChanged);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 419);
            this.Controls.Add(this.groupOptions);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlActions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormStart";
            this.Text = "Odyssey - Start Session";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormStart_FormClosed);
            this.pnlActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupOptions.ResumeLayout(false);
            this.groupOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWordGoal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimePeriod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkDisableClipboard;
        private System.Windows.Forms.CheckBox chkPreventExit;
        private System.Windows.Forms.CheckBox chkExcludeGibberish;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Button btnFromDraft;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.GroupBox groupOptions;
        private System.Windows.Forms.NumericUpDown numTimePeriod;
        private System.Windows.Forms.RadioButton rbWordGoal;
        private System.Windows.Forms.RadioButton rbTimeGoal;
        private System.Windows.Forms.Label lblWords;
        private System.Windows.Forms.NumericUpDown numWordGoal;
        private System.Windows.Forms.Label lblMinutes;
    }
}