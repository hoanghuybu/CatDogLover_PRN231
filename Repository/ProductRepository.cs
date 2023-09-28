using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;
using DataAccess;

namespace Repository
{
    public class ProductRepository : IProductRepository
    {
        public void DeleteProduct(Product product) => ProductDAO.Instance.DeleteProduct(product);

        public Product FindProductById(string id) => ProductDAO.Instance.FindProductById(id);

        public List<Product> GetProduct() => ProductDAO.Instance.GetProduct();

        public void SaveProduct(Product product) => ProductDAO.Instance.SaveProduct(product);

        public void UpdateProduct(Product product) => ProductDAO.Instance.UpdateProduct(product);
    }
}
