using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FichaMedica
{
    internal class Separador : Control
    {
        private int grosor = 1;
        private bool vertical;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var sz = vertical ? Height / 2: Width /2 ;
            e.Graphics.TranslateTransform(Width/2f, Height/2f);

            using (var pen = new Pen(ForeColor,grosor))
            {
                if (!vertical)
                {
                    e.Graphics.DrawLine(pen, -sz + Padding.Left, 0, sz - Padding.Right, 0);
                }
                else
                {
                    e.Graphics.DrawLine(pen, 0, -sz+Padding.Top, 0, sz-Padding.Bottom);
                }
            }
        }
        protected override void OnPaddingChanged(EventArgs e)
        {
            base.OnPaddingChanged(e);
            Invalidate();
        }

        public bool esVertical
        {
            get => vertical;
            set{
                vertical = value;
                Invalidate();
            }
        }
        public int leGrosor
        {
            get => grosor;
            set
            {
                grosor = value;
                if (Height < grosor)
                {
                    Height = grosor;
                }
                else
                {
                    Invalidate();
                }
            }
        }
    }
}
