using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Interfaces;
using Ninject;
using BLL.Util;
using System.Reflection;

namespace CF_RepositoryPattern
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var kernel = new StandardKernel(new NinjectRegister(), new ServiceModule("MonitorsContext"));
           
            IDbCrud dbCrud = kernel.Get<IDbCrud>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run( new Menu(dbCrud));
        }
    }
}
