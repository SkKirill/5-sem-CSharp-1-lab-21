﻿using System;
using System.Windows.Forms;
using Lb6.Forms;

namespace Lb6
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainDataForm());
        }
    }
}
