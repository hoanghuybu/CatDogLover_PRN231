using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;
using DataAccess;

namespace Repository
{
    public class ReactRepository : IReactRepository
    {
        public void DeleteReact(React react) => ReactDAO.Instance.DeleteReact(react);

        public React FindReactById(int accountId, int postId) => ReactDAO.Instance.FindReactById(accountId, postId);

        public List<React> GetReact() => ReactDAO.Instance.GetReact();

        public void SaveReact(React react) => ReactDAO.Instance.SaveReact(react);

        public void UpdateReact(React react) => ReactDAO.Instance.UpdateReact(react);
    }
}
