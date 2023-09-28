using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;

namespace Repository
{
    public interface IReactRepository
    {
        public void DeleteReact(React react);
        public void UpdateReact(React react);
        public void SaveReact(React react);
        public React FindReactById(int accountId, int postId);
        public List<React> GetReact();
    }
}
