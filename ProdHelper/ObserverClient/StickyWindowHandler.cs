using GameOverlay.Windows;
using ProdHelper.Models;
using ProdHelper.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static ProdHelper.ObserverClient.TallyLightForm;

namespace ProdHelper.ObserverClient
{
    public class StickyWindowHandler : IDisposable
    {
        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hwnd, ref Rect rectangle);

        private Process _targetProcess;
        private TallyLightObserver _parent;

        private StickyWindow _processWindow;

        private GameOverlay.Drawing.SolidBrush stickyWindowBrush;
        private GameOverlay.Drawing.SolidBrush transparentBrush;

        private GlobalKeyboardHook _keyboardHook;

        public StickyWindowHandler(Process targetProcess, TallyLightObserver parent, Keys fullscreenKey)
        {
            _targetProcess = targetProcess;
            _parent = parent;

            _keyboardHook = new GlobalKeyboardHook(new Keys[] { fullscreenKey });
            _keyboardHook.KeyboardPressed += OnKeyPressed;

            IntPtr ptr = _targetProcess.MainWindowHandle;
            Rect processRect = new Rect();
            GetWindowRect(ptr, ref processRect);

            GameOverlay.Drawing.Graphics gfx = new GameOverlay.Drawing.Graphics()
            {
                MeasureFPS = false,
                PerPrimitiveAntiAliasing = true,
                TextAntiAliasing = true,
                WindowHandle = IntPtr.Zero
            };

            _processWindow = new StickyWindow(0, 0, processRect.Right - processRect.Left, processRect.Bottom - processRect.Top, ptr, gfx)
            {
                IsTopmost = true,
                FPS = 15,
                IsVisible = true,
                AttachToClientArea = true,
            };

            _processWindow.SetupGraphics += StickyWindowSetupGraphics;
            _processWindow.DrawGraphics += StickyWindowDrawGraphics;
            _processWindow.DestroyGraphics += StickyWindowDestroyGraphics;

            _processWindow.Create();
        }

        

        private void OnKeyPressed(object? sender, GlobalKeyboardHookEventArgs e)
        {
            if (WindowHelper.GetForegroundWindow() != _processWindow.Handle)
            {
                WindowHelper.EnableBlurBehind(_targetProcess.MainWindowHandle);
                _processWindow.Recreate();
                WindowHelper.MakeTopmost(_processWindow.Handle);
            }
        }

        private void StickyWindowSetupGraphics(object sender, SetupGraphicsEventArgs e)
        {
            GameOverlay.Drawing.Graphics gfx = e.Graphics;

            Color camStateColor = TallyLightCam.ColorFromState(_parent.LastCamState);

            stickyWindowBrush = gfx.CreateSolidBrush(camStateColor.R, camStateColor.G, camStateColor.B, camStateColor.A);
            transparentBrush = gfx.CreateSolidBrush(GameOverlay.Drawing.Color.Transparent);

        }

        private void StickyWindowDrawGraphics(object sender, DrawGraphicsEventArgs e)
        {
            StickyWindow window = sender as StickyWindow;

            GameOverlay.Drawing.Graphics gfx = e.Graphics;

            // gfx.ClearScene();

            gfx.DrawBox2D(stickyWindowBrush, transparentBrush, 0, 0, window.Width, window.Height, 50);
        }

        private void StickyWindowDestroyGraphics(object? sender, DestroyGraphicsEventArgs e)
        {
            stickyWindowBrush.Dispose();
            transparentBrush.Dispose();
        }

        public void Dispose()
        {
            _processWindow.Dispose();
            stickyWindowBrush.Dispose();
            transparentBrush.Dispose();
        }

        public struct Rect
        {
            public int Left { get; set; }
            public int Top { get; set; }
            public int Right { get; set; }
            public int Bottom { get; set; }
        }
    }
}
