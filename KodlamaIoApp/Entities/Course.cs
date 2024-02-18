using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoApp.Entities
{
    public class Course
        
    {
        public Course()
        {
            
        }
        public Course(int CourseId, int InstructorId, int CategoryId, string CourseName, string Description, int Price)
        {
            this.CourseId = CourseId;
            this.InstructorId = InstructorId;
            this.CategoryId = CategoryId;
            this.CourseName = CourseName;
            this.Description = Description;
            this.Price = Price;

        }
        public int CourseId { get; set; }

        public int InstructorId { get; set; }
        public int CategoryId { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        

        public int Price { get; set; }
        public int CompletionRate { get; set; }
        public string ImageUrl { get; set; }
    }
}
