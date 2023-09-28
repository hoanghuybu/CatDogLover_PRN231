using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using BussinessObjects;

namespace Repository
{
    public class OrderRepository : IOrderRepository
    {
        public void DeleteOrder(Order order) => OrderDAO.Instance.DeleteOrder(order);

        public Order FindOrderById(int id) => OrderDAO.Instance.FindOrderById(id);

        public List<Order> GetOrder() => OrderDAO.Instance.GetOrder();

        public void SaveOrder(Order order) => OrderDAO.Instance.SaveOrder(order);

        public void UpdateOrder(Order order) => OrderDAO.Instance.UpdateOrder(order);
    }
}
