using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;

namespace Repository
{
    public interface IOrderRepository
    {
        public void DeleteOrder(Order order);
        public void UpdateOrder(Order order);
        public void SaveOrder(Order order);
        public Order FindOrderById(int id);
        public List<Order> GetOrder();
    }
}
