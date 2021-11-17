using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
namespace BLL.Models
{
    public  class SuplierModel
    {
        public int ID { get; set; }

        public string CompanyName { get; set; }

        public string ContactName { get; set; }

        public SuplierModel() { }

        public SuplierModel(Suplier s)
        {
            ID = s.ID;
            CompanyName = s.CompanyName;
            ContactName = s.ContactName;
        }
    }
}
