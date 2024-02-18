using KodlamaIoApp.Business.Abstracts;
using KodlamaIoApp.DataAccess.Abstracts;
using KodlamaIoApp.DataAccess.Concretes;
using KodlamaIoApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoApp.Business.Concretes
{
    public class CategoryManager : ICategoryManager
    {
        private readonly ICategoryDal categoryDal;
        public CategoryManager()
        {
        }

        public CategoryManager(ICategoryDal categoryDal)
        {
            this.categoryDal = categoryDal;
        }
        public void Add(Category category)
        {
            categoryDal.Add(category);
            if (category.CategoryId == 0)
            {
                Console.WriteLine("0 numaralı id girilemez.");
            }
        }

        public void Delete(int categoryId)
        {
            categoryDal.Delete(categoryId);
        }

        public List<Category> GetAll()
        {

            return categoryDal.GetAll();
            
        }

        public Category GetById(int id)
        {
            categoryDal.GetById(id);
            if (GetById == null)
            {
                Console.WriteLine("Lütfen geçerli bir id giriniz.");
            }
            return null;
        }

        public void Update(int categoryId, Category updatedCategory)
        {
            categoryDal.Update(categoryId, updatedCategory);
        }
    }
}
