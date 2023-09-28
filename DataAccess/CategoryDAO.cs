using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;

namespace DataAccess
{
    public class CategoryDAO
    {
        private static CategoryDAO instance = null;
        private static readonly object instanceLock = new object();
        private CategoryDAO() { }
        public static CategoryDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CategoryDAO();
                    }
                    return instance;
                }
            }
        }
        public List<Category> GetCategory()
        {
            var listCategory = new List<Category>();
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    listCategory = context.Categories.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listCategory;
        }

        public Category FindCategoryById(int id)
        {
            Category category = new Category();
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    category = context.Categories.SingleOrDefault(c => c.CategoryId == id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return category;
        }

        public void SaveCategory(Category category)
        {
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    context.Categories.Add(category);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void UpdateCategory(Category category)
        {
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    context.Entry<Category>(category).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void DeleteCategory(Category category)
        {
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    var deleteCategory = context.Categories.SingleOrDefault(c => c.CategoryId == category.CategoryId);
                    context.Categories.Remove(deleteCategory);
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
