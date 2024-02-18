using KodlamaIoApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoApp.DataAccess.Abstracts
{
    public interface ICategoryDal
    {
        void Add(Category category);
        void Delete(int categoryId);
        List<Category> GetAll();
        Category GetById(int id);
        void Update(int categoryId, Category updatedCategory);
    }
}
