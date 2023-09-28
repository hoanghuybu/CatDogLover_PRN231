using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;

namespace Repository
{
    public interface IItemRepository
    {
        public void DeleteItem(Item item);
        public void UpdateItem(Item item);
        public void SaveItem(Item item);
        public Item FindItemById(int id);
        public List<Item> GetItem();
    }
}
