using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;

namespace Repository
{
    public interface IPostRepository
    {
        public void DeletePost(Post post);
        public void UpdatePost(Post post);
        public void SavePost(Post post);
        public Post FindPostById(int id);
        public List<Post> GetPost();
    }
}
