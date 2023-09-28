using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;

namespace Repository
{
    public interface ICategoryRepository
    {
        public void DeleteCategory(Category category);
        public void UpdateCategory(Category category);
        public void SaveCategory(Category category);
        public Category FindCategoryById(int id);
        public List<Category> GetCategory();
    }
}
