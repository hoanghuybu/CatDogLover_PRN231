using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;

namespace DataAccess
{
    public class GiftCommentDAO
    {
        private static GiftCommentDAO instance = null;
        private static readonly object instanceLock = new object();
        private GiftCommentDAO() { }
        public static GiftCommentDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new GiftCommentDAO();
                    }
                    return instance;
                }
            }
        }
        public List<GiftComment> GetGiftComment()
        {
            var listGiftComment = new List<GiftComment>();
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    listGiftComment = context.GiftComments.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listGiftComment;
        }

        public GiftComment FindGiftCommentById(int id)
        {
            GiftComment giftComment = new GiftComment();
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    giftComment = context.GiftComments.SingleOrDefault(c => c.GiftCommentId == id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return giftComment;
        }

        public void SaveGiftComment(GiftComment giftComment)
        {
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    context.GiftComments.Add(giftComment);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void UpdateGiftComment(GiftComment giftComment)
        {
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    context.Entry<GiftComment>(giftComment).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void DeleteGiftComment(GiftComment giftComment)
        {
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    var deleteGiftComment = context.GiftComments.SingleOrDefault(c => c.GiftCommentId == giftComment.GiftCommentId);
                    context.GiftComments.Remove(deleteGiftComment);
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
