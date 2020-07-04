using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using Gma.System.MouseKeyHook;
using MoreLinq;
using Odyssey.Data;
using Odyssey.Utils;

namespace Odyssey.UI
{
    public partial class FormEditor : Form
    {
        private IKeyboardMouseEvents _mGlobalHook;
        private DateTime _startTime;

        public FormEditor()
        {
            InitializeComponent();
        }

        public OdysseyOptions Options { get; private set; }

        private void FormEditor_Load(object sender, EventArgs e)
        {
            odysseyToolStrip1.Initialize(textBox, new List<Panel> {panelLeftIndent, panelRightIndent}, ToggleDarkMode);
            odysseyStatusStrip1.Initialize(textBox);
        }

        private void FormEditor_Resize(object sender, EventArgs e)
        {
            var widthPercentage = Width > 1000 ? Width > 1400 ? 0.25 : 0.2 : 0.1;
            panelLeftIndent.Width = (int) (Width * widthPercentage);
            panelRightIndent.Width = (int) (Width * widthPercentage);
        }

        public void SetOptions(OdysseyOptions odysseyOptions)
        {
            Options = odysseyOptions;
            if (Options.TimeGoal != null) _startTime = DateTime.Now;
            if (Options.PreventExit)
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                TopMost = true;
                tmrEnsureNoClose.Start();
                _mGlobalHook = Hook.GlobalEvents();
                _mGlobalHook.KeyDown += (sender, e) =>
                {
                    if (!Options.PreventExit) return;
                    if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.LWin || e.KeyCode == Keys.RWin) e.Handled = true;
                };
            }

            tmrCheckCompletion.Start();
        }

        private void ToggleDarkMode()
        {
            ThemeUtils.ToggleDarkMode(this);
        }

        private void FormEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0) Application.Exit();
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (Options.DisableClipboard && e.Control && (e.KeyCode & Keys.V) == Keys.V) e.Handled = true;
        }

        private void tmrCheckCompletion_Tick(object sender, EventArgs e)
        {
            if (Options.TimeGoal != null && DateTime.Now > _startTime.Add(Options.TimeGoal ?? TimeSpan.Zero))
            {
                tmrCheckCompletion.Stop();
                GoalFinished();
            }

            if (Options.WordGoal != null && CompletionUtils.GetWordCount(textBox.Text, Options.ExcludeGibberish) >=
                Options.WordGoal)
            {
                tmrCheckCompletion.Stop();
                GoalFinished();
            }
        }

        private void GoalFinished()
        {
            if (Options.PreventExit)
            {
                tmrEnsureNoClose.Stop();
                Options.PreventExit = false;
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                TopMost = false;
            }

            MessageBox.Show(
                "Congratulations! You reached your goal! Press the close button to save your work & quit, or just keep writing!");
        }

        private void FormEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Options.PreventExit && e.CloseReason != CloseReason.WindowsShutDown) e.Cancel = true;
        }

        private void tmrEnsureNoClose_Tick(object sender, EventArgs e)
        {
            //Process.GetProcessesByName("explorer").ForEach(p => p.Kill());
            Process.GetProcessesByName("taskmgr").ForEach(p => p.Kill());
            BringToFront();
            WindowState = FormWindowState.Maximized;
        }
    }
}