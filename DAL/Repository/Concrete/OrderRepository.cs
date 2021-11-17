using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Repository.Concrete
{
    public class OrderRepository : IRepository<Order>
    {
        private MonitorsContext db;

        public OrderRepository(MonitorsContext context)
        {
            this.db = context;
        }

        public void Add(Order entity)
        {
            db.Orders.Add(entity);
        }

        public List<Order> GetAll()
        {
            return db.Orders.ToList();
        }

        public Order GetByID(int id)
        {
            return db.Orders.Find(id);
        }

        public void Remove(int id)
        {
            db.Orders.Remove(GetByID(id));
        }

        public void Update(Order entity)
        {
            db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
