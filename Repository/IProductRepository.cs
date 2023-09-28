using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;

namespace Repository
{
    public interface IProductRepository
    {
        public void DeleteProduct(Product product);
        public void UpdateProduct(Product product);
        public void SaveProduct(Product product);
        public Product FindProductById(string id);
        public List<Product> GetProduct();
    }
}
