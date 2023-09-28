using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;
using DataAccess;

namespace Repository
{
    public class ServiceRepository : IServiceRepository
    {
        public void DeleteService(Service customer) => ServiceDAO.Instance.DeleteService(customer);

        public Service FindServiceById(string id) => ServiceDAO.Instance.FindServiceById(id);

        public List<Service> GetService() => ServiceDAO.Instance.GetService();

        public void SaveService(Service customer) => ServiceDAO.Instance.SaveService(customer);

        public void UpdateService(Service customer) => ServiceDAO.Instance.UpdateService(customer);
    }
}
