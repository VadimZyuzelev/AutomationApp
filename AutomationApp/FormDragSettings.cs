using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AutomationApp
{
    public class FormDragSettings
    {
        private System.IntPtr _hWnd;
        private int _wMsg;
        private int _wParam;
        private int _lParam; 

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
