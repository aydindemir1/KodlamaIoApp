using KodlamaIoApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoApp.Business.Abstracts
{
    public interface ICategoryManager
    {
        void Add(Category category);
        void Delete(int categoryId);
        List<Category> GetAll();
        Category GetById(int id);
        void Update(int categoryId, Category updatedCategory);
    }
}
