using KodlamaIoApp.DataAccess.Abstracts;
using KodlamaIoApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoApp.DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> categories;

        public CategoryDal()
        {
            categories = new List<Category>();
            categories.Add(new Category(1,"Programlama"));
        }

        public void Add(Category category)
        {
            categories.Add(category);
        }

        public void Delete(int categoryId)
        {
            Category categoryToDelete = null;
            foreach (var category in categories)
            {
                if (category.CategoryId == categoryId)
                {
                    categoryToDelete = category;
                    break;
                }
            }

            if (categoryToDelete != null)
            {
                categories.Remove(categoryToDelete);
                Console.WriteLine("Kategori başarıyla silindi.");
            }
            else
            {
                Console.WriteLine("Belirtilen ID'ye sahip bir kategori bulunamadı.");
            }
        }

        public List<Category> GetAll()
        {
            Console.WriteLine("Kategoriler listelendi: ");
            foreach (var category in categories)
            {
                Console.WriteLine( category.CategoryName);
            }
            return categories;
        }

        public Category GetById(int id)
        {
            foreach (var category in categories)
            {
                if (category.CategoryId == id)
                {
                    Console.WriteLine(category.CategoryName + " isimli kategori bulundu.");
                    return category;
                }
            }
            return null;
        }

        public void Update(int categoryId, Category updatedCategory)
        {
            
        }
    }
}
