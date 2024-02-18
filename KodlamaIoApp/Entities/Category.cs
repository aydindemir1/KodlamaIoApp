using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoApp.Entities
{
    public class Category
    {
        public Category()
        {

        }

        public Category(int categoryId, string categoryName)
        {
            CategoryId = categoryId;
            CategoryName = categoryName;
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<Course> Courses { get; set; }

        public List<Instructor> Instructors { get; set; }
    }
}
