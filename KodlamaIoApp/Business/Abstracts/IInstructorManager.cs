using KodlamaIoApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoApp.Business.Abstracts
{
    public interface IInstructorManager
    {
        void Add(Instructor instructor);
        void Delete(int instructorId);
        List<Instructor> GetAll();
        Instructor GetById(int id);
        void Update(int instructorId, Instructor updatedInstructor);
    }
}
