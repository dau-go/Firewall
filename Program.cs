﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SharpPcap;

namespace WinformsExample
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
            Application.Run(new AddRuleForm());
            //var mainCaptureForm = new CaptureForm();
            //Application.Run(mainCaptureForm);
        }
    }
}
