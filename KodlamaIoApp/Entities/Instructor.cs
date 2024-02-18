using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoApp.Entities
{
    public class Instructor
    {
        public Instructor()
        {
            
        }

        public Instructor(int InstructorId, int CategoryId, string InstructorName,string ImageUrl)
        {
            this.InstructorId = InstructorId;
            this.CategoryId = CategoryId;
            this.InstructorName = InstructorName;
            this.ImageUrl = ImageUrl;

        }
        public int InstructorId { get; set; }

        public int CategoryId { get; set; }
        public string InstructorName { get; set; }

        public string ImageUrl { get; set; }

        public List<Course>  courses{ get; set; }
    }
}
