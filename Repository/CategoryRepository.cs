using BussinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        public void DeleteCategory(Category category) => CategoryDAO.Instance.DeleteCategory(category);

       

        public Category FindCategoryById(int id) => CategoryDAO.Instance.FindCategoryById(id);

        public List<Category> GetCategory() => CategoryDAO.Instance.GetCategory();

        public void SaveCategory(Category category) => CategoryDAO.Instance.SaveCategory(category);

        

        public void UpdateCategory(Category category) => CategoryDAO.Instance.UpdateCategory(category);

        

        
    }
}
