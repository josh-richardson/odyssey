using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MoreLinq.Extensions;
using Odyssey.Data;

namespace Odyssey.UI
{
    public partial class FormEditor : Form
    {
        private OdysseyOptions _odysseyOptions;

        public FormEditor()
        {
            InitializeComponent();
        }

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
            this._odysseyOptions = odysseyOptions;
        }



        private bool ToggleDarkMode()
        {
            Theming.ToggleDarkMode(this);
            return false;
        }

        private void FormEditor_FormClosed(object sender, FormClosedEventArgs e) {
            if (Application.OpenForms.Count == 0) {
                Application.Exit();
            }
        }
    }
}