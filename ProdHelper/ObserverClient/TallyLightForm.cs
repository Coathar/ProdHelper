using ProdHelper.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProdHelper.ObserverClient
{
    public class TallyLightForm : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        private const int HTTRANSPARENT = (-1);

        const int GWL_EXSTYLE = -20;
        const int WS_EX_LAYERED = 0x80000;
        const int WS_EX_TRANSPARENT = 0x20;

        private Process targetProcess;
        private Panel targetProcessPanel;

        public CamState LastCamState
        {
            get
            {
                return ((TallyLightForm)Parent).LastCamState;
            }
        }

        public bool HasProcess 
        {
            get
            {
                return targetProcess != null;
            }
        }

       

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        public TallyLightForm()
        {
            targetProcessPanel = new BorderPanel();

            Controls.Add(targetProcessPanel);

            Width = 128;
            Height = 128;

            targetProcessPanel.Left = 0;
            targetProcessPanel.Top = 0;
            targetProcessPanel.Width = Width;
            targetProcessPanel.Height = Height;

            FormBorderStyle = FormBorderStyle.None;
            BackColor = Color.LimeGreen;
            TransparencyKey = Color.LimeGreen;
            Opacity = 1;
            TopLevel = true;
            TopMost = true;
            ShowInTaskbar = false;

            Show();
        }

        public TallyLightForm(Process process)
            : this()
        {
            targetProcess = process;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        public void UpdateForm()
        {
            targetProcessPanel.Invalidate();
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    if (HasProcess)
                    {
                        m.Result = (IntPtr)HTTRANSPARENT;
                        return;
                    }

                    if ((int)m.Result == HTCLIENT)
                        m.Result = (IntPtr)HTCAPTION;
                    return;
            }

            base.WndProc(ref m);
        }

        

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TallyLightForm
            // 
            this.ClientSize = new System.Drawing.Size(128, 128);
            this.Name = "TallyLightForm";
            this.ResumeLayout(false);

        }
    }
}
