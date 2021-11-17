using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Models;
namespace BLL.Interfaces
{
   public  interface IDbCrud
    {
        List<ProductModel> GetAllProducts();
        List<SuplierModel> GetAllSuplier();
        List<OrderModel> GetOrderModels();
        List<ReportProduct> GetProductsPrice(int combox);
        

        void CreateProduct(ProductModel p);
        void UpdateProduct(ProductModel p);
        void DeleteProduct(int p);

        void CreateSuplier(SuplierModel s);
        void UpdateSuplier(SuplierModel s);
        void DeleteSuplier(int s);

        void CreateOrder(OrderModel o);
        void UpdateOrder(OrderModel o);
        void DeleteOrder(int o);
    
    }
}
