using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;

namespace Repository
{
    public interface IGiftRepository
    {
        public void DeleteGift(Gift gift);
        public void UpdateGift(Gift gift);
        public void SaveGift(Gift gift);
        public Gift FindGiftById(string id);
        public List<Gift> GetGift();
    }
}
