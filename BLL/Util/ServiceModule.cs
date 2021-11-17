using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repository.Abstract;
using DAL.Repository.Concrete;
namespace BLL.Util
{
  public  class ServiceModule : NinjectModule
    {
        private string constring; 
        public ServiceModule(string connection)
        {
            constring = connection; 
        }

        public override void Load()
        {
            Bind<IDbRepository>().To<DbRepository>().InSingletonScope().WithConstructorArgument(constring);
        }
    }
}
