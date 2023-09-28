using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;

namespace DataAccess
{
    public class ProductDAO
    {
        private static ProductDAO instance = null;
        private static readonly object instanceLock = new object();
        private ProductDAO() { }
        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                    return instance;
                }
            }
        }
        public List<Product> GetProduct()
        {
            var listProduct = new List<Product>();
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    listProduct = context.Products.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listProduct;
        }

        public Product FindProductById(string id)
        {
            Product product = new Product();
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    product = context.Products.SingleOrDefault(c => c.ProductId == id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return product;
        }

        public void SaveProduct(Product product)
        {
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    context.Products.Add(product);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void UpdateProduct(Product product)
        {
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    context.Entry<Product>(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void DeleteProduct(Product product)
        {
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    var deleteProduct = context.Products.SingleOrDefault(c => c.ProductId == product.ProductId);
                    context.Products.Remove(deleteProduct);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
