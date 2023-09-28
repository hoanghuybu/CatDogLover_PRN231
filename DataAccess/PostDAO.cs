using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;

namespace DataAccess
{
    public class PostDAO
    {
        private static PostDAO instance = null;
        private static readonly object instanceLock = new object();
        private PostDAO() { }
        public static PostDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new PostDAO();
                    }
                    return instance;
                }
            }
        }
        public List<Post> GetPost()
        {
            var listPost = new List<Post>();
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    listPost = context.Posts.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listPost;
        }

        public Post FindPostById(int id)
        {
            Post Post = new Post();
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    Post = context.Posts.SingleOrDefault(c => c.PostId == id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return Post;
        }

        public void SavePost(Post Post)
        {
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    context.Posts.Add(Post);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void UpdatePost(Post Post)
        {
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    context.Entry<Post>(Post).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void DeletePost(Post Post)
        {
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    var deletePost = context.Posts.SingleOrDefault(c => c.PostId == Post.PostId);
                    context.Posts.Remove(deletePost);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
