using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;

namespace Repository
{
    public interface IOrderDetailRepository
    {
        public void DeleteOrderDetail(OrderDetail OrderDetail);
        public void UpdateOrderDetail(OrderDetail OrderDetail);
        public void SaveOrderDetail(OrderDetail OrderDetail);
        public OrderDetail FindOrderDetailById(int id);
        public List<OrderDetail> GetOrderDetail();
    }
}
