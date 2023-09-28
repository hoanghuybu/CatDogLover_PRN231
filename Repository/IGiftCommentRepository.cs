using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;

namespace Repository
{
    public interface IGiftCommentRepository
    {
        public void DeleteGiftComment(GiftComment giftComment);
        public void UpdateGiftComment(GiftComment giftComment);
        public void SaveGiftComment(GiftComment giftComment);
        public GiftComment FindGiftCommentById(int id);
        public List<GiftComment> GetGiftComment();
    }
}
