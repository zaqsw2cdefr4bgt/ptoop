﻿using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Oop3.PL
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
            Application.Run(new Form1());
        }

    }
}