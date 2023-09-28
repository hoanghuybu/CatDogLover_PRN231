using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;
namespace DataAccess
{
    public class ServiceDAO
    {
        private static ServiceDAO instance = null;
        private static readonly object instanceLock = new object();
        private ServiceDAO() { }
        public static ServiceDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ServiceDAO();
                    }
                    return instance;
                }
            }
        }
        public List<Service> GetService()
        {
            var listService = new List<Service>();
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    listService = context.Services.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listService;
        }

        public Service FindServiceById(string id)
        {
            Service customer = new Service();
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    customer = context.Services.SingleOrDefault(c => c.ServiceId == id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return customer;
        }

        public void SaveService(Service customer)
        {
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    context.Services.Add(customer);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void UpdateService(Service customer)
        {
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    context.Entry<Service>(customer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void DeleteService(Service customer)
        {
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    var deleteService = context.Services.SingleOrDefault(c => c.ServiceId == customer.ServiceId);
                    context.Services.Remove(deleteService);
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
