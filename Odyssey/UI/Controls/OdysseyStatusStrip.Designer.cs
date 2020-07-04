namespace Odyssey.UI.Controls
{
    partial class OdysseyStatusStrip
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblWordCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbGoalProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.lblCurrentGoal = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblWordCount,
            this.pbGoalProgress,
            this.lblCurrentGoal});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(695, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblWordCount
            // 
            this.lblWordCount.Name = "lblWordCount";
            this.lblWordCount.Size = new System.Drawing.Size(53, 17);
            this.lblWordCount.Text = "Words: 0";
            // 
            // pbGoalProgress
            // 
            this.pbGoalProgress.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.pbGoalProgress.Name = "pbGoalProgress";
            this.pbGoalProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // lblCurrentGoal
            // 
            this.lblCurrentGoal.Name = "lblCurrentGoal";
            this.lblCurrentGoal.Size = new System.Drawing.Size(75, 17);
            this.lblCurrentGoal.Text = "Words Left: ?";
            // 
            // OdysseyStatusStrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Name = "OdysseyStatusStrip";
            this.Size = new System.Drawing.Size(695, 22);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblWordCount;
        private System.Windows.Forms.ToolStripProgressBar pbGoalProgress;
        private System.Windows.Forms.ToolStripStatusLabel lblCurrentGoal;
    }
}
