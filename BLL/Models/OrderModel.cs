using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
namespace BLL.Models
{
    public class OrderModel
    {
        public int ID { get; set; }

        public int ProductID { get; set; }

        public DateTime? OrderDate { get; set; }

        public decimal? TotalCost { get; set; }

        public OrderModel() { }
        public OrderModel(Order o)
        {
            ID = o.ID;
            ProductID = o.ProductID;
            OrderDate = o.OrderDate;
            TotalCost = o.TotalCost;
        }
    }
}
