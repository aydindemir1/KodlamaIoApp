using KodlamaIoApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoApp.DataAccess.Abstracts
{
    public interface ICourseDal
    {
        void Add(Course course);
        void Delete(int courseId);
        List<Course> GetAll();
        Course GetById(int id);
        void Update(int courseId, Course updatedCourse);
    }
}
