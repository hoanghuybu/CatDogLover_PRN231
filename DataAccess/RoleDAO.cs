using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;

namespace DataAccess
{
    public class RoleDAO
    {
        private static RoleDAO instance = null;
        private static readonly object instanceLock = new object();
        private RoleDAO() { }
        public static RoleDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new RoleDAO();
                    }
                    return instance;
                }
            }
        }
        public List<Role> GetRole()
        {
            var listRole = new List<Role>();
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    listRole = context.Roles.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listRole;
        }

        public Role FindRoleById(int id)
        {
            Role customer = new Role();
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    customer = context.Roles.SingleOrDefault(c => c.RoleId == id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return customer;
        }

        public void SaveRole(Role customer)
        {
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    context.Roles.Add(customer);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void UpdateRole(Role customer)
        {
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    context.Entry<Role>(customer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void DeleteRole(Role customer)
        {
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    var deleteRole = context.Roles.SingleOrDefault(c => c.RoleId == customer.RoleId);
                    context.Roles.Remove(deleteRole);
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
