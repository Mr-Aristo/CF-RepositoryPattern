using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repository.Abstract;
using BLL.Interfaces;
using BLL.Models;
using DAL.Entities;
namespace BLL
{
    public class DbOperations:IDbCrud
    {
        IDbRepository db;
        
        
        public DbOperations(IDbRepository repos)
        {
            db = repos;
        }
        public bool Save()
        {
            if (db.Save() > 0) return true;
            return false;
        }

        #region Product


        public List<ProductModel> GetAllProducts()
        {
            return db.Product.GetAll().Select(i => new ProductModel(i)).ToList();
        }

        public void CreateProduct(ProductModel p)
        {
            db.Product.Add(new Product
            {
                ID = p.ID,
                ProductName = p.ProductName,
                SuplierID = p.SuplierID,
                UnitPrice = p.UnitPrice,
                Amount = p.Amount
            });
            Save();

        }
        public void UpdateProduct(ProductModel pm)
        {
            Product product = db.Product.GetByID(pm.ID);
            product.ProductName = pm.ProductName;
            product.SuplierID = pm.SuplierID;
            product.UnitPrice = pm.UnitPrice;
            product.Amount = pm.Amount;
            db.Product.Update(product);
            db.Save();

        }
        public void DeleteProduct(int p)
        {
            db.Product.Remove(p);
        }
        #endregion
       

        #region Suplier
        public List<SuplierModel> GetAllSuplier()
        {
            return db.Suplier.GetAll().Select(i => new SuplierModel(i)).ToList();
        }

    
       
        public void CreateSuplier(SuplierModel s)
        {
            db.Suplier.Add(new Suplier
            {
                ID = s.ID,
                CompanyName = s.CompanyName,
                ContactName = s.ContactName
            });
            Save();
            
        }

        public void UpdateSuplier(SuplierModel s)
        {
            Suplier suplier = db.Suplier.GetByID(s.ID);
            suplier.CompanyName = s.CompanyName;
            suplier.ContactName = s.ContactName;
            db.Suplier.Update(suplier);
            Save();
        }

        public void DeleteSuplier(int s)
        {
            db.Suplier.Remove(s);
            Save();
        }
        #endregion

        #region Order
        public void CreateOrder(OrderModel o)
        {
             db.Order.Add(new Order
            {
                ID = o.ID,
                ProductID = o.ProductID,
                OrderDate = o.OrderDate,
                TotalCost = o.TotalCost

            });
            Save();

        }
        public void UpdateOrder(OrderModel o)
        {
            Order order = db.Order.GetByID(o.ID);
            order.ProductID = o.ProductID;
            order.OrderDate = o.OrderDate;
            order.TotalCost = o.TotalCost;
            db.Order.Update(order);
            Save();
        }

        public void DeleteOrder(int o)
        {
            db.Order.Remove(o);
            Save();
        }

        public List<OrderModel> GetOrderModels()
        {
            return db.Order.GetAll().Select(i => new OrderModel(i)).ToList();

        }

        public List<ReportProduct> GetProductsPrice(int combox)
        {
            var request = db.Product.GetAll()
                 .Where(i => i.ID == combox)
                 .Select(i => new ReportProduct() { UnitPrice = i.UnitPrice, Amount = i.Amount })
                 .ToList();


            return request;
        }
        #endregion



    }
    public class ReportProduct
    {
        public int? UnitPrice { get; set; }

        public int? Amount { get; set; }

    }
}
