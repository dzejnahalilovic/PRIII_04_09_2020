﻿using cSharpIntroWinForms.P9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using cSharpIntroWinForms.ISPIT_PRIII_04_09_2020;

namespace cSharpIntroWinForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPretragaBrojIndeksa());
        }
    }
}
