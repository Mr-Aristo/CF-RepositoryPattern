using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
namespace DAL.Repository.Concrete
{
    public class SuplierRepository: IRepository<Suplier>
    {
        private MonitorsContext db;

        public SuplierRepository(MonitorsContext context)
        {
            this.db = context;
        }
        public void Add(Suplier entity)
        {
            db.Supliers.Add(entity);
        }

        public List<Suplier> GetAll()
        {
            return db.Supliers.ToList();
        }

        public Suplier GetByID(int id)
        {
            return db.Supliers.Find(id);
            
        }

        public void Remove(int id)
        {
           db.Supliers.Remove(GetByID(id));
        }

    
        public void Update(Suplier entity)
        {
            db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
