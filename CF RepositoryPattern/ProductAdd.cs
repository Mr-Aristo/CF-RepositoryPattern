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
    public partial class ProductAdd : Form
    {
        IDbCrud db;
        ProductModel productModel = new ProductModel();
        public ProductAdd(IDbCrud dbCrud) 
        { 
            InitializeComponent();
            db = dbCrud;
            
        }

        

        public void button1_Click(object sender, EventArgs e)
        {
           


            productModel.ID = Convert.ToInt32(ProductIDBox.Text);
            productModel.ProductName = ProductNameBox.Text;
            productModel.SuplierID = Convert.ToInt32(SuplierIDBox.Text);
            productModel.UnitPrice = Convert.ToInt32(UnitPriceBox.Text);
            productModel.Amount = Convert.ToInt32(AmountBox.Text);
            db.CreateProduct(productModel);

        }

        private void ProductDeletebtn_Click(object sender, EventArgs e)
        {
            db.DeleteProduct(Convert.ToInt32(ProductIDBox.Text));
        }

        private void ProductAddbtn_Click(object sender, EventArgs e)
        {
            productModel.ID = Convert.ToInt32(ProductIDBox.Text);
            productModel.ProductName = ProductNameBox.Text;
            productModel.SuplierID = Convert.ToInt32(SuplierIDBox.Text);
            productModel.UnitPrice = Convert.ToInt32(UnitPriceBox.Text);
            productModel.Amount = Convert.ToInt32(AmountBox.Text);
            db.UpdateProduct(productModel);

        }
    }
}
