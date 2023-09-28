using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;

namespace DataAccess
{
    public class OrderDetailDAO
    {
        private static OrderDetailDAO instance = null;
        private static readonly object instanceLock = new object();
        private OrderDetailDAO() { }
        public static OrderDetailDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailDAO();
                    }
                    return instance;
                }
            }
        }
        public List<OrderDetail> GetOrderDetail()
        {
            var listOrderDetail = new List<OrderDetail>();
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    listOrderDetail = context.OrderDetails.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listOrderDetail;
        }

        public OrderDetail FindOrderDetailById(int id)
        {
            OrderDetail orderDetail = new OrderDetail();
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    orderDetail = context.OrderDetails.SingleOrDefault(c => c.OrderDetailId == id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return orderDetail;
        }

        public void SaveOrderDetail(OrderDetail orderDetail)
        {
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    context.OrderDetails.Add(orderDetail);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void UpdateOrderDetail(OrderDetail orderDetail)
        {
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    context.Entry<OrderDetail>(orderDetail).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void DeleteOrderDetail(OrderDetail orderDetail)
        {
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    var deleteOrderDetail = context.OrderDetails.SingleOrDefault(c => c.OrderDetailId == orderDetail.OrderDetailId);
                    context.OrderDetails.Remove(deleteOrderDetail);
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
