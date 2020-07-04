using System.Linq;
using System.Windows.Forms;

namespace Odyssey.UI.Controls
{
    public partial class OdysseyStatusStrip : UserControl
    {
        private ExtendedRichTextBox _textBox;


        public OdysseyStatusStrip() {
            InitializeComponent();
        }

        public void Initialize(ExtendedRichTextBox textBox)
        {
            _textBox = textBox;

            _textBox.TextChanged += (sender, e) =>
            {
                lblWordCount.Text = $"Words: {_textBox.Text.Split(' ').Where(i => i.Length != 0).ToArray().Length}";
            };
        }
    }
}
