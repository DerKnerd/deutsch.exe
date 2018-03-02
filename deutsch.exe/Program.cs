using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deutsch.exe
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var td = new TaskDialog
            {
                ProgressBar = new TaskDialogProgressBar
                {
                    State = TaskDialogProgressBarState.Marquee
                },
                Caption = "deutsch.exe",
                InstructionText = "deutsch.exe läuft heute nicht",
                Text = "Bitte warten, während das Problem von Jenny an Kirk und Reemt übermittelt wird…",
                StandardButtons = TaskDialogStandardButtons.Cancel
            };
            td.Show();
        }
    }
}
