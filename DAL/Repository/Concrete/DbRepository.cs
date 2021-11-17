using DAL.Entities;
using DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Concrete
{
    public class DbRepository : IDbRepository
    {
        private MonitorsContext db;
        private ProductRepository productRepository;
        private OrderRepository orderRepository;
        private SuplierRepository suplierRepository;


        public DbRepository()
        {
            db = new MonitorsContext();
        }

        public IRepository<Product> Product
        {
            get
            {
                if (productRepository == null)
                    productRepository = new ProductRepository(db);
                return productRepository;
            }
        }

        public IRepository<Order> Order
        {
            get
            {
                if (orderRepository == null)
                    orderRepository = new OrderRepository(db);
                return orderRepository;
            }
        }

      

        public IRepository<Suplier> Suplier
        {
            get
            {
                if (suplierRepository == null)
                    suplierRepository = new SuplierRepository(db);


                return suplierRepository;
                    
            }
        }

       
        public int Save()
        {
            return db.SaveChanges();
        }
    }
}
