using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;

namespace DataAccess
{
    public class OrderDAO
    {
        private static OrderDAO instance = null;
        private static readonly object instanceLock = new object();
        private OrderDAO() { }
        public static OrderDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }
                    return instance;
                }
            }
        }
        public List<Order> GetOrder()
        {
            var listOrder = new List<Order>();
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    listOrder = context.Orders.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listOrder;
        }

        public Order FindOrderById(int id)
        {
            Order order = new Order();
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    order = context.Orders.SingleOrDefault(c => c.OrderId == id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return order;
        }

        public void SaveOrder(Order order)
        {
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    context.Orders.Add(order);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void UpdateOrder(Order order)
        {
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    context.Entry<Order>(order).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void DeleteOrder(Order order)
        {
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    var deleteOrder = context.Orders.SingleOrDefault(c => c.OrderId == order.OrderId);
                    context.Orders.Remove(deleteOrder);
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
