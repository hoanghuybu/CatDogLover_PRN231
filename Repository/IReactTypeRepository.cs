using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;

namespace Repository
{
    public interface IReactTypeRepository
    {
        public void DeleteReactType(ReactType reactType);
        public void UpdateReactType(ReactType reactType);
        public void SaveReactType(ReactType reactType);
        public ReactType FindReactTypeById(int id);
        public List<ReactType> GetReactType();
    }
}
