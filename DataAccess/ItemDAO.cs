using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;

namespace DataAccess
{
    public class ItemDAO
    {
        private static ItemDAO instance = null;
        private static readonly object instanceLock = new object();
        private ItemDAO() { }
        public static ItemDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ItemDAO();
                    }
                    return instance;
                }
            }
        }
        public List<Item> GetItem()
        {
            var listItem = new List<Item>();
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    listItem = context.Items.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listItem;
        }

        public Item FindItemById(string id)
        {
            Item item = new Item();
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    item = context.Items.SingleOrDefault(c => c.ItemId == id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return item;
        }

        public void SaveItem(Item item)
        {
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    context.Items.Add(item);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void UpdateItem(Item item)
        {
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    context.Entry<Item>(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void DeleteItem(Item item)
        {
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    var deleteItem = context.Items.SingleOrDefault(c => c.ItemId == item.ItemId);
                    context.Items.Remove(deleteItem);
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
