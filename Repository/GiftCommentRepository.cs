using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;
using DataAccess;

namespace Repository
{
    public class GiftCommentRepository : IGiftCommentRepository
    {
        public void DeleteGiftComment(GiftComment giftComment) => GiftCommentDAO.Instance.DeleteGiftComment(giftComment);

        

        public GiftComment FindGiftCommentById(int id) => GiftCommentDAO.Instance.FindGiftCommentById(id);

        public List<GiftComment> GetGiftComment() => GiftCommentDAO.Instance.GetGiftComment();

        public void SaveGiftComment(GiftComment giftComment) => GiftCommentDAO.Instance.SaveGiftComment(giftComment);

        

        public void UpdateGiftComment(GiftComment giftComment) => GiftCommentDAO.Instance.UpdateGiftComment(giftComment);

        
    }
}
