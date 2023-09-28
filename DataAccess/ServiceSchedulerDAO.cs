using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;

namespace DataAccess
{
    public class ServiceSchedulerDAO
    {
        private static ServiceSchedulerDAO instance = null;
        private static readonly object instanceLock = new object();
        private ServiceSchedulerDAO() { }
        public static ServiceSchedulerDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ServiceSchedulerDAO();
                    }
                    return instance;
                }
            }
        }
        public List<ServiceScheduler> GetServiceScheduler()
        {
            var listServiceScheduler = new List<ServiceScheduler>();
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    listServiceScheduler = context.ServiceSchedulers.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listServiceScheduler;
        }

        public ServiceScheduler FindServiceSchedulerById(string id)
        {
            ServiceScheduler customer = new ServiceScheduler();
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    customer = context.ServiceSchedulers.SingleOrDefault(c => c.ServiceSchedulerId == id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return customer;
        }

        public void SaveServiceScheduler(ServiceScheduler customer)
        {
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    context.ServiceSchedulers.Add(customer);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void UpdateServiceScheduler(ServiceScheduler customer)
        {
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    context.Entry<ServiceScheduler>(customer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void DeleteServiceScheduler(ServiceScheduler customer)
        {
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    var deleteServiceScheduler = context.ServiceSchedulers.SingleOrDefault(c => c.ServiceSchedulerId == customer.ServiceSchedulerId);
                    context.ServiceSchedulers.Remove(deleteServiceScheduler);
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
