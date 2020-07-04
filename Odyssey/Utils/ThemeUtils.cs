using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;
using MoreLinq.Extensions;

namespace Odyssey.Utils
{
    internal class ThemeUtils
    {
        public static void ToggleDarkMode(Form form)
        {
            foreach (var control in GetAllChildren(form).Concat(new Control[] {form}))
            {
                InvertColors(control);
                if (control is ToolStrip strip) strip.Items.Cast<ToolStripItem>().ForEach(InvertToolStripItem);
            }
        }

        private static void InvertToolStripItem(ToolStripItem item)
        {
            if (item is ToolStripDropDownItem dropDown)
                dropDown.DropDownItems.Cast<ToolStripItem>().ForEach(InvertToolStripItem);

            if (item.Image != null) item.Image = InvertImage(new Bitmap(item.Image));
            if (string.IsNullOrWhiteSpace(item.GetCurrentParent().Name)) InvertColors(item);
        }

        public static Bitmap InvertImage(Bitmap source)
        {
            var newBitmap = new Bitmap(source.Width, source.Height);
            var g = Graphics.FromImage(newBitmap);
            var colorMatrix = new ColorMatrix(new[]
            {
                new float[] {-1, 0, 0, 0, 0},
                new float[] {0, -1, 0, 0, 0},
                new float[] {0, 0, -1, 0, 0},
                new float[] {0, 0, 0, 1, 0},
                new float[] {1, 1, 1, 0, 1}
            });
            var attributes = new ImageAttributes();
            attributes.SetColorMatrix(colorMatrix);
            g.DrawImage(source, new Rectangle(0, 0, source.Width, source.Height),
                0, 0, source.Width, source.Height, GraphicsUnit.Pixel, attributes);
            g.Dispose();
            return newBitmap;
        }

        private static void InvertColors(ToolStripItem item)
        {
            item.BackColor = InvertColor(item.BackColor);
            item.ForeColor = InvertColor(item.ForeColor);
        }

        private static void InvertColors(Control control)
        {
            control.BackColor = InvertColor(control.BackColor);
            control.ForeColor = InvertColor(control.ForeColor);
        }

        private static Color InvertColor(Color color)
        {
            return Color.FromArgb(color.ToArgb() ^ 0xffffff);
        }

        private static IEnumerable<Control> GetAllChildren(Control control)
        {
            var controls = control.Controls.Cast<Control>();
            var enumerable = controls.ToList();
            return enumerable.SelectMany(GetAllChildren).Concat(enumerable);
        }
    }
}