using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;

namespace Repository
{
    public interface IServiceRepository
    {
        public void DeleteService(Service service);
        public void UpdateService(Service service);
        public void SaveService(Service service);
        public Service FindServiceById(string id);
        public List<Service> GetService();
    }
}
