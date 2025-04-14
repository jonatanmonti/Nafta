using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nafta.Styles
{
    public static class CueBanner
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, string lParam);

        private const int EM_SETCUEBANNER = 0x1501;

        /// <summary>
        /// Asigna un texto placeholder (cue banner) a un TextBox.
        /// </summary>
        /// <param name="tb">TextBox de destino</param>
        /// <param name="text">Texto a mostrar</param>
        /// <param name="showWhenFocused">
        /// true  → se muestra incluso con foco  
        /// false → desaparece al recibir foco (comportamiento típico)
        /// </param>
        public static void Set(TextBox tb, string text, bool showWhenFocused = false)
        {
            // wParam = 1 → mostrar incluso con foco, 0 → ocultar con foco
            SendMessage(tb.Handle, EM_SETCUEBANNER, showWhenFocused ? 1 : 0, text);
        }
    }
}
