using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Models;
using BLL.Interfaces;

namespace CF_RepositoryPattern
{
    public partial class Menu : Form
    {
        IDbCrud db; //Data base operations

        List<ProductModel> productModels;
        List<SuplierModel> suplierModels;
        List<OrderModel> orderModels;
        public Menu(IDbCrud dbCrud)
        {
             db = dbCrud;
            InitializeComponent();
           
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            productModels = db.GetAllProducts();
            comboBox1.DataSource = productModels;
            comboBox1.DisplayMember = "ProductName";
            comboBox1.ValueMember = "ID";
        }

        #region LoadFunctions

        private void LoadProduct()
        {
            productModels = db.GetAllProducts().ToList();
            dataGridView1.DataSource = productModels;
            
        }
        private void LoadSupliers() 
        {
            
                suplierModels = db.GetAllSuplier().ToList();
                dataGridView1.DataSource = suplierModels.ToList();

        }

        private void LoadOrders()
        {
            orderModels = db.GetOrderModels().ToList();
            dataGridView1.DataSource = orderModels.ToList();

        }

        private void ListFromCombobox()
        {
            dataGridView1.DataSource = db.GetProductsPrice((int)comboBox1.SelectedValue);
        }

        #endregion

        
        

        #region Operation Buttons
        private void OptProductbtn_Click(object sender, EventArgs e)
        {
            ProductAdd p = new ProductAdd(db);
            p.Show();

           
        }

        private void OptOrderbtn_Click(object sender, EventArgs e)
        {
            OrderAdd orderAdd = new OrderAdd(db);
            orderAdd.Show();
        }

        private void OptSuplierbtn_Click(object sender, EventArgs e)
        {
            SuplierAdd suplierAdd = new SuplierAdd(db);
            suplierAdd.Show();
        }
        #endregion


        #region ListButtons
        private void ListProductbtn_Click(object sender, EventArgs e)
        {
            LoadProduct();
        }
        private void ListSuplierbtn_Click(object sender, EventArgs e)
        {
            LoadSupliers();
        }

        private void ListOrderbtn_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

  
        private void Selectbtn_Click(object sender, EventArgs e)
        {
            ListFromCombobox();
        }

        #endregion


    }

}
