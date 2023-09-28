using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;
using DataAccess;

namespace Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public void DeleteOrderDetail(OrderDetail orderDetail) => OrderDetailDAO.Instance.DeleteOrderDetail(orderDetail);

        

        public OrderDetail FindOrderDetailById(int id) => OrderDetailDAO.Instance.FindOrderDetailById(id);

        public List<OrderDetail> GetOrderDetail() => OrderDetailDAO.Instance.GetOrderDetail();

        public void SaveOrderDetail(OrderDetail orderDetail) => OrderDetailDAO.Instance.SaveOrderDetail(orderDetail);

       

        public void UpdateOrderDetail(OrderDetail orderDetail) => OrderDetailDAO.Instance.UpdateOrderDetail(orderDetail);

        
    }
}
