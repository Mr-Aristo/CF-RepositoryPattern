using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
namespace BLL.Models
{
   public class ProductModel
    {
        public int ID { get; set; }

        public string ProductName { get; set; }

        public int SuplierID { get; set; }

        public int? UnitPrice { get; set; }

        public int? Amount { get; set; }

        public ProductModel() { }
        public ProductModel(Product p)
        {
            ID = p.ID;
            ProductName = p.ProductName;
            SuplierID = p.SuplierID;
            UnitPrice = p.UnitPrice;
            Amount = p.Amount;

        }


    }
}
