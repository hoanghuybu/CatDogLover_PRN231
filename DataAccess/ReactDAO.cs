using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;

namespace DataAccess
{
    public class ReactDAO
    {
        private static ReactDAO instance = null;
        private static readonly object instanceLock = new object();
        private ReactDAO() { }
        public static ReactDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ReactDAO();
                    }
                    return instance;
                }
            }
        }
        public List<React> GetReact()
        {
            var listReact = new List<React>();
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    listReact = context.Reacts.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listReact;
        }

        public React FindReactById(int accountId, int postId)
        {
            React react = new React();
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    react = context.Reacts.Where(c => c.AccountId == accountId && c.PostId == postId).SingleOrDefault();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return react;
        }

        public void SaveReact(React react)
        {
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    context.Reacts.Add(react);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void UpdateReact(React react)
        {
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    context.Entry<React>(react).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void DeleteReact(React react)
        {
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    var deleteReact = context.Reacts.Where(c => c.AccountId == react.AccountId && c.PostId == react.PostId).SingleOrDefault();
                    context.Reacts.Remove(deleteReact);
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
