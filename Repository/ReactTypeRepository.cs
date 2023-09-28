using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;
using DataAccess;

namespace Repository
{
    public class ReactTypeRepository : IReactTypeRepository
    {
        public void DeleteReactType(ReactType reactType) => ReactTypeDAO.Instance.DeleteReactType(reactType);

        public ReactType FindReactTypeById(int id) => ReactTypeDAO.Instance.FindReactTypeById(id);

        public List<ReactType> GetReactType() => ReactTypeDAO.Instance.GetReactType();

        public void SaveReactType(ReactType reactType) => ReactTypeDAO.Instance.SaveReactType(reactType);

        public void UpdateReactType(ReactType reactType) => ReactTypeDAO.Instance.UpdateReactType(reactType);
    }
}
