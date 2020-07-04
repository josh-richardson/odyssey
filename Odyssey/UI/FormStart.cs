using MoreLinq.Extensions;
using Odyssey.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Odyssey.UI
{
    public partial class FormStart : Form
    {
        public FormStart() {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e) {
            var editor = new FormEditor();
            editor.Show();
            var options = new OdysseyOptions {
                PreventExit = chkPreventExit.Checked,
                ExcludeGibberish = chkExcludeGibberish.Checked,
                DisableClipboard = chkDisableClipboard.Checked
            };

            if (rbTimeGoal.Checked) {
                options.TimeGoal = TimeSpan.FromMinutes((int)numTimePeriod.Value);
            }

            if (rbWordGoal.Checked) {
                options.WordGoal = (int)numWordGoal.Value;
            }

            editor.SetOptions(options);
            Close();
        }

        private void FormStart_FormClosed(object sender, FormClosedEventArgs e) {
            if (Application.OpenForms.Count == 0) {
                Application.Exit();
            }
        }

        private void rbWordGoal_CheckedChanged(object sender, EventArgs e) {
            groupOptions.Controls.Cast<Control>().Where(it => (string)it.Tag == "word_group")
                .ForEach(it => it.Enabled = rbWordGoal.Checked);
        }

        private void rbTimeGoal_CheckedChanged(object sender, EventArgs e) {
            groupOptions.Controls.Cast<Control>().Where(it => (string)it.Tag == "time_group")
                .ForEach(it => it.Enabled = rbTimeGoal.Checked);
        }
    }
}