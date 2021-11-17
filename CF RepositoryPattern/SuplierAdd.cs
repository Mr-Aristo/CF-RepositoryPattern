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
    public partial class SuplierAdd : Form
    {
        IDbCrud db;
        SuplierModel s = new SuplierModel();
        public SuplierAdd(IDbCrud dbCrud)
        {
            InitializeComponent();
            db = dbCrud;
        }

        private void SuplierAddbtn_Click(object sender, EventArgs e)
        {
            s.ID = Convert.ToInt32(SuplierIDBox.Text);
            s.CompanyName = CompanyNameBox.Text;
            s.ContactName = ContactNameBox.Text;
            db.CreateSuplier(s);
        }

        private void SuplierUpdatebtn_Click(object sender, EventArgs e)
        {
            s.ID = Convert.ToInt32(SuplierIDBox.Text);
            s.CompanyName = CompanyNameBox.Text;
            s.ContactName = ContactNameBox.Text;
            db.UpdateSuplier(s);
        }

        private void SuplierDeletebtn_Click(object sender, EventArgs e)
        {
            db.DeleteSuplier(Convert.ToInt32(SuplierIDBox.Text));
        }
    }
}
