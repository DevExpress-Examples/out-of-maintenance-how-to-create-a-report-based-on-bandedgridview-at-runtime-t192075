// Developer Express Code Central Example:
// How to convert an XtraGrid to an XtraReport at runtime
// 
// This example demonstrates how to dynamically create a report based upon the
// GridControl at runtime. This means that all filtering and sorting conditions
// selected in the grid are also applied in a report. To accomplish this task, it
// is necessary to create a report with all the necessary bands, bind it to a data
// source and adjust all the necessary options.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E108

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace dxKB17175
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