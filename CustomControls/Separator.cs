﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastmanApp.CustomControls
{
    internal class Separator : Control
    {
        private int _thick;
        private bool _isVertical;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var sz = _isVertical ? Height / 2 : Width / 2;
            e.Graphics.TranslateTransform(Width / 2f, Height / 2f);

            using (var pen = new Pen(ForeColor,_thick))
            {
                if (!_isVertical)
                {
                    e.Graphics.DrawLine(pen, -sz + Padding.Left, 0, sz - Padding.Right, 0);
                }
                else
                {
                    e.Graphics.DrawLine(pen,0 , -sz + Padding.Top, 0, sz - Padding.Bottom);
                }

            }
        }

        protected override void OnPaddingChanged(EventArgs e)
        {
            base.OnPaddingChanged(e);
            Invalidate();
        }

        public bool isVertical 
        {
            get => _isVertical;
            set 
            {
                _isVertical = value;
                Invalidate();
            }
        }

        public int thickness
        {
            get => _thick;
            set 
            {
                _thick = value;
                if (Height < _thick)
                {
                    Height = _thick;
                }
                else
                {
                    Invalidate();
                }
            }
        }
    }
}
