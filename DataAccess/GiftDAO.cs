using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;

namespace DataAccess
{
    public class GiftDAO
    {
        private static GiftDAO instance = null;
        private static readonly object instanceLock = new object();
        private GiftDAO() { }
        public static GiftDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new GiftDAO();
                    }
                    return instance;
                }
            }
        }
        public List<Gift> GetGift()
        {
            var listGift = new List<Gift>();
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    listGift = context.Gifts.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listGift;
        }

        public Gift FindGiftById(string id)
        {
            Gift gift = new Gift();
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    gift = context.Gifts.SingleOrDefault(c => c.GiftId == id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return gift;
        }

        public void SaveGift(Gift gift)
        {
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    context.Gifts.Add(gift);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void UpdateGift(Gift gift)
        {
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    context.Entry<Gift>(gift).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void DeleteGift(Gift gift)
        {
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    var deleteGift = context.Gifts.SingleOrDefault(c => c.GiftId == gift.GiftId);
                    context.Gifts.Remove(deleteGift);
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
