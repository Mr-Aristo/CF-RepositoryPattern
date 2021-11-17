using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Repository.Abstract;

namespace DAL.Repository.Concrete
{
    public class ProductRepository : IRepository<Product>
    {
        private MonitorsContext db;
        public ProductRepository(MonitorsContext context)
        {
            this.db = context;
        }
        public void Add(Product entity)
        {
            db.Products.Add(entity);
        }

        public List<Product> GetAll()
        {
            return db.Products.ToList();
        }

        public Product GetByID(int id)
        {
            return db.Products.Find(id);
            //return db.Products.SingleOrDefault(m=> m.ID == id);
        }

        public void Remove(int id)
        {
            db.Products.Remove(GetByID(id));
        }

        public void Update(Product entity)
        {
            db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }
    }
    
   
}
