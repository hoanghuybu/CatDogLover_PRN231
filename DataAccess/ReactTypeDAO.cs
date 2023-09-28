using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;

namespace DataAccess
{
    public class ReactTypeDAO
    {
        private static ReactTypeDAO instance = null;
        private static readonly object instanceLock = new object();
        private ReactTypeDAO() { }
        public static ReactTypeDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ReactTypeDAO();
                    }
                    return instance;
                }
            }
        }
        public List<ReactType> GetReactType()
        {
            var listReactType = new List<ReactType>();
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    listReactType = context.ReactTypes.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listReactType;
        }

        public ReactType FindReactTypeById(int id)
        {
            ReactType reactType = new ReactType();
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    reactType = context.ReactTypes.SingleOrDefault(c => c.ReactTypeId == id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return reactType;
        }

        public void SaveReactType(ReactType reactType)
        {
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    context.ReactTypes.Add(reactType);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void UpdateReactType(ReactType reactType)
        {
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    context.Entry<ReactType>(reactType).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void DeleteReactType(ReactType reactType)
        {
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    var deleteReactType = context.ReactTypes.SingleOrDefault(c => c.ReactTypeId == reactType.ReactTypeId);
                    context.ReactTypes.Remove(deleteReactType);
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
