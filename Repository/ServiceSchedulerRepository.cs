using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;
using DataAccess;

namespace Repository
{
    public class ServiceSchedulerRepository : IServiceSchedulerRepository
    {
        public void DeleteServiceScheduler(ServiceScheduler serviceScheduler) => ServiceSchedulerDAO.Instance.DeleteServiceScheduler(serviceScheduler);

        public ServiceScheduler FindServiceSchedulerById(string id) => ServiceSchedulerDAO.Instance.FindServiceSchedulerById(id);

        public List<ServiceScheduler> GetServiceScheduler() => ServiceSchedulerDAO.Instance.GetServiceScheduler();

        public void SaveServiceScheduler(ServiceScheduler serviceScheduler) => ServiceSchedulerDAO.Instance.SaveServiceScheduler(serviceScheduler);

        public void UpdateServiceScheduler(ServiceScheduler serviceScheduler) => ServiceSchedulerDAO.Instance.UpdateServiceScheduler(serviceScheduler);
    }
}
