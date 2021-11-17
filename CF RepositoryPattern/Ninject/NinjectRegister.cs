using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using BLL.Interfaces;
using BLL;
using BLL.Models;
using BLL.Util;
namespace CF_RepositoryPattern
{
    public class NinjectRegister:NinjectModule
    {
        public override void Load()
        {
            Bind<IDbCrud>().To<DbOperations>();
        }
    }
}
