using ProdHelper.Models;
using ProdHelper.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProdHelper.ObserverClient
{
    public class BorderPanel : Panel
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Shape DrawShape { get; set; }

        public BorderPanel()
        {
            BorderStyle = BorderStyle.None;
            BackColor = Color.Transparent;
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Parent.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        protected override void OnClick(EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;

            if (me.Button == MouseButtons.Right)
            {
                if ((int)DrawShape + 1 >= Enum.GetValues<Shape>().Length)
                {
                    DrawShape = 0;
                }
                else
                {
                    DrawShape++;
                }
            }
            else if (me.Button == MouseButtons.Middle)
            {
                string newSize = Prompt.ShowDialog("New Icon Size", "Size Selection", Parent.Width.ToString());

                if (int.TryParse(newSize, out int size))
                {
                    Parent.Width = size;
                    Parent.Height = size;
                    Width = Parent.Width;
                    Height = Parent.Height;
                    Invalidate();
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            TallyLightForm parent = Parent as TallyLightForm;
            Color camColor = TallyLightCam.ColorFromState(parent.LastCamState);

            if (parent.HasProcess)
            {
                int width = 5;

                ControlPaint.DrawBorder(e.Graphics, parent.ClientRectangle, camColor, width, ButtonBorderStyle.Solid, camColor, width, ButtonBorderStyle.Solid, camColor, width, ButtonBorderStyle.Solid, camColor, width, ButtonBorderStyle.Solid);
            }
            else
            {
                SolidBrush brush = new SolidBrush(camColor);

                if (DrawShape == Shape.Circle)
                {
                    e.Graphics.FillEllipse(brush, parent.ClientRectangle);
                }
                else if (DrawShape == Shape.Square)
                {
                    e.Graphics.FillRectangle(brush, parent.ClientRectangle);
                }
            }
        }

        public enum Shape
        {
            Square,
            Circle
        }
    }
}
