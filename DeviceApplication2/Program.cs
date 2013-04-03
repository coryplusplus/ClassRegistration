using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Data.Common;


namespace DeviceApplication2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            Application.Run(new LoginScreen());
        
        }
    }


}