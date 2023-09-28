using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;

namespace Repository
{
    public interface IServiceSchedulerRepository
    {
        public void DeleteServiceScheduler(ServiceScheduler customer);
        public void UpdateServiceScheduler(ServiceScheduler customer);
        public void SaveServiceScheduler(ServiceScheduler customer);
        public ServiceScheduler FindServiceSchedulerById(string id);
        public List<ServiceScheduler> GetServiceScheduler();
    }
}
