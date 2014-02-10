using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Fitness_M
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
            var frmUserIdent = new UserIdentification();
            //if (frmUserIdent.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new BrowseForm());
            }


        }
    }
}
