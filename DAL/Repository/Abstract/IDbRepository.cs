using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Abstract
{
   public  interface IDbRepository
    {
        IRepository<Product> Product { get; }
        IRepository<Order> Order { get; }
        IRepository<Suplier> Suplier { get; }
   

        int Save();
    }
}
