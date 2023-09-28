using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;
using DataAccess;

namespace Repository
{
    public class GiftRepository : IGiftRepository
    {
        public void DeleteGift(Gift gift) => GiftDAO.Instance.DeleteGift(gift);

        

        public Gift FindGiftById(string id) => GiftDAO.Instance.FindGiftById(id);

        public List<Gift> GetGift() => GiftDAO.Instance.GetGift();

        public void SaveGift(Gift gift) => GiftDAO.Instance.SaveGift(gift);

        

        public void UpdateGift(Gift gift) => GiftDAO.Instance.UpdateGift(gift);

        
    }
}
