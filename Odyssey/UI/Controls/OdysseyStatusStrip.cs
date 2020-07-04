using System;
using System.Windows.Forms;
using Odyssey.Utils;

namespace Odyssey.UI.Controls
{
    public partial class OdysseyStatusStrip : UserControl
    {
        private Func<string> _getStatus;
        private ExtendedRichTextBox _textBox;


        public OdysseyStatusStrip()
        {
            InitializeComponent();
        }

        public void Initialize(ExtendedRichTextBox textBox, Func<string> getStatus)
        {
            _textBox = textBox;
            _getStatus = getStatus;

            _textBox.TextChanged += (sender, e) =>
            {
                lblWordCount.Text = $"Words: {CompletionUtils.GetWordCount(_textBox.Text, false)}";
            };
        }

        private void tmrUpdateStatus_Tick(object sender, EventArgs e)
        {
            lblStatus.Text = "Status: " + _getStatus();
        }
    }
}