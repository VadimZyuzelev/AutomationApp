using System.Runtime.InteropServices;

namespace AutomationApp
{
    public class FormDragSettings
    {
        private readonly System.IntPtr _hWnd;
        private readonly int _wMsg;
        private readonly int _wParam;
        private readonly int _lParam; 

        public FormDragSettings(System.IntPtr hWnd, int wMsg, int wParam, int lParam)
        {
            this._hWnd = hWnd;
            this._wMsg = wMsg;
            this._wParam = wParam;
            this._lParam = lParam;

            ReleaseCapture();
            SendMessage(_hWnd, _wMsg, _wParam, _lParam);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
    }
}
