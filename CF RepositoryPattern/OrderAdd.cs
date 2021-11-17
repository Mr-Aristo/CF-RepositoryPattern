using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Interfaces;
using BLL.Models;
namespace CF_RepositoryPattern
{
    public partial class OrderAdd : Form
    {
        IDbCrud db;
        OrderModel o = new OrderModel();
        public OrderAdd(IDbCrud dbCrud)
        {
            InitializeComponent();
            db = dbCrud;
        }

        private void OrderAddbtn_Click(object sender, EventArgs e)
        {
           
            o.ID = Convert.ToInt32(OrderIDBox.Text);
            o.ProductID = Convert.ToInt32(ProductIDBox.Text);
            o.OrderDate = Convert.ToDateTime(DateBox.Text);
            o.TotalCost = Convert.ToInt32(CostBox.Text);
            db.CreateOrder(o);


        }

        private void OrderUpdatebtn_Click(object sender, EventArgs e)
        {
            o.ID = Convert.ToInt32(OrderIDBox.Text);
            o.ProductID = Convert.ToInt32(ProductIDBox.Text);
            o.OrderDate = Convert.ToDateTime(DateBox.Text);
            o.TotalCost = Convert.ToInt32(CostBox.Text);
            db.UpdateOrder(o);

        }

        private void OrderDeletebtn_Click(object sender, EventArgs e)
        {
            db.DeleteOrder(Convert.ToInt32(OrderIDBox.Text));
        }
    }
}
