﻿using System;
using System.Windows.Forms;

namespace NomadGameAgain
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            StartForm mainMenu = new StartForm();
            Application.Run(mainMenu);
        }
    }
}
