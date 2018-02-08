using System;
using System.Collections.Generic;
using System.Text;

namespace CanEastVending
{
    // MSDN Resource reference used: VistaAPI
    internal class VistaApi
    {
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        internal static extern void DwmExtendFrameIntoClientArea(System.IntPtr hWnd, ref Margins pMargins);

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        internal static extern void DwmIsCompositionEnabled(ref bool isEnabled);

        internal struct Margins
        {
            public int Left, Right, Top, Bottom;
        }
    }
}
