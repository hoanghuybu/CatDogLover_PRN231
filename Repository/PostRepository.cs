using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;
using DataAccess;

namespace Repository
{
    public class PostRepository : IPostRepository
    {
        public void DeletePost(Post post) => PostDAO.Instance.DeletePost(post);

        public Post FindPostById(int id) => PostDAO.Instance.FindPostById(id);

        public List<Post> GetPost() => PostDAO.Instance.GetPost();

        public void SavePost(Post post) => PostDAO.Instance.SavePost(post);

        public void UpdatePost(Post post) => PostDAO.Instance.UpdatePost(post);
    }
}
