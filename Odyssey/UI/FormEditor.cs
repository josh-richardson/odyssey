using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
        private string _status;

        public FormEditor()
        {
            InitializeComponent();
        }

        public OdysseyOptions Options { get; private set; }

        private void FormEditor_Load(object sender, EventArgs e)
        {
            odysseyToolStrip1.Initialize(textBox, new List<Panel> {panelLeftIndent, panelRightIndent}, ToggleDarkMode);
            odysseyStatusStrip1.Initialize(textBox, () => _status);
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
            WindowState = FormWindowState.Maximized;
            if (Options.PreventExit)
            {
                odysseyToolStrip1.Padding = new Padding(0, 10, 0, 0);
                TopMost = true;
                FormBorderStyle = FormBorderStyle.None;
                tmrEnsureNoClose.Start();
                _mGlobalHook = Hook.GlobalEvents();
                _mGlobalHook.KeyDown += (sender, e) =>
                {
                    if (!Options.PreventExit) return;
                    if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.LWin || e.KeyCode == Keys.RWin) e.Handled = true;
                };
            }

            if (Options.InitialFile != null) textBox.LoadFile(Options.InitialFile);

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
            if (Options.TimeGoal != null)
            {
                _status = _startTime.Add(Options.TimeGoal.Value).Subtract(DateTime.Now).TotalMinutes.ToString("N0") +
                          " minutes left";
                if (DateTime.Now > _startTime.Add(Options.TimeGoal.Value))
                {
                    tmrCheckCompletion.Stop();
                    GoalFinished();
                }
            }

            if (Options.WordGoal != null)
            {
                var wordCount = CompletionUtils.GetWordCount(textBox.Text, Options.ExcludeGibberish);
                _status = $"{Options.WordGoal - wordCount} words left";
                if (wordCount >=
                    Options.WordGoal)
                {
                    tmrCheckCompletion.Stop();
                    GoalFinished();
                }
            }
        }

        private void GoalFinished()
        {
            WindowState = FormWindowState.Normal;

            if (Options.PreventExit)
            {
                odysseyToolStrip1.Padding = new Padding(0, 0, 0, 0);
                tmrEnsureNoClose.Stop();
                FormBorderStyle = FormBorderStyle.Sizable;
                Options.PreventExit = false;
                TopMost = false;
            }

            MessageBox.Show(
                "Congratulations! You reached your goal! Press the close button to save your work & quit, or just keep writing!");
        }

        private void FormEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Options.PreventExit && e.CloseReason != CloseReason.WindowsShutDown)
            {
                e.Cancel = true;
                return;
            }

            var sfd = new SaveFileDialog {Filter = "RichText File (.rtf)|*.rtf", Title = "Save your work"};
            if (sfd.ShowDialog() == DialogResult.OK)
                textBox.SaveFile(sfd.FileName);
            else
                e.Cancel = true;
        }

        private void tmrEnsureNoClose_Tick(object sender, EventArgs e)
        {
            Process.GetProcessesByName("taskmgr").ForEach(p => p.Kill());
            BringToFront();
            WindowState = FormWindowState.Maximized;
        }

        private void tmrAutoSave_Tick(object sender, EventArgs e)
        {
            var odysseyHome =
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Odyssey");
            if (!Directory.Exists(odysseyHome)) Directory.CreateDirectory(odysseyHome);
            textBox.SaveFile(Path.Combine(odysseyHome, $"Odyssey_Autosave_{DateTime.Now:yy-dd-MM-HH-mm-ss}.rtf"));
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '"' || textBox.Lines.Length == 0 || textBox.SelectionStart != textBox.Text.Length) return;
            try
            {
                var currentLine = textBox.Lines[textBox.Lines.Length - 1];
                if (!currentLine.Contains("\"")) return;
                var lines = textBox.Lines;
                var indexOfFirstQuote = currentLine.LastIndexOf("\"", StringComparison.Ordinal);
                var completedQuote = currentLine.Substring(indexOfFirstQuote).Replace("\"", "“") + "”";
                lines[textBox.Lines.Length - 1] = currentLine.Substring(0, indexOfFirstQuote) + completedQuote;
                textBox.Lines = lines;
                textBox.SelectionStart = textBox.Text.Length;
                e.Handled = true;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
    }
}