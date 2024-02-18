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
    public class CourseManager : ICourseManager
    {
        private readonly ICourseDal courseDal;

        public CourseManager(ICourseDal courseDal)
        {
           this.courseDal = courseDal;
        }
        public void Add(Course course)
        {
            courseDal.Add(course);
            if (course.CourseId == 0)
            {
                Console.WriteLine("0 numaralı id girilemez.");
            }
        }

        public void Delete(int courseId)
        {
            courseDal.Delete(courseId);
        }

        public List<Course> GetAll()
        {
            return courseDal.GetAll();
        }

        public Course GetById(int id)
        {
            courseDal.GetById(id);
            if (GetById == null)
            {
                Console.WriteLine("Lütfen geçerli bir id giriniz.");
            }
            return null;
        }

        public void Update(int courseId, Course updatedCourse)
        {
            courseDal.Update(courseId, updatedCourse);
        }
    }
}
