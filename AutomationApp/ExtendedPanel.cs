using System;
using System.Drawing;
using System.Windows.Forms;

namespace AutomationApp
{
    [System.ComponentModel.DesignerCategory("")]
    public class ExtendedPanel : Panel
    {
        private const int WS_EX_TRANSPARENT = 0x20;
        private int _opacity;

        public ExtendedPanel()
        {
            SetStyle(ControlStyles.Opaque, true);
        }

        public int Opacity
        {
            get
            {
                return this._opacity;
            }

            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException("Значение должнл быть от 0 до 100");
                this._opacity = value;
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= WS_EX_TRANSPARENT;
                return cp;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (var brush = new SolidBrush(Color.FromArgb(this._opacity * 255 / 100, Color.Black)))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
            base.OnPaint(e);
        }

    }
}
