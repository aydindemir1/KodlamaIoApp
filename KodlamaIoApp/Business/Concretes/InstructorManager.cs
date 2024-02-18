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
    public class InstructorManager : IInstructorManager
    {
        private readonly IInstructorDal instructorDal;

        public InstructorManager()
        {
            
        }
        public InstructorManager(IInstructorDal instructorDal)
        {
            this.instructorDal = instructorDal;
        }
        public void Add(Instructor instructor)
        {
            instructorDal.Add(instructor);
            if (instructor.InstructorId == 0)
            {
                Console.WriteLine("0 numaralı id girilemez.");
            }
        }

        public void Delete(int instructorId)
        {
            instructorDal.Delete(instructorId);
        }

        public List<Instructor> GetAll()
        {
            return instructorDal.GetAll();
             
        }

        public Instructor GetById(int id)
        {
            instructorDal.GetById(id);
            if (GetById == null)
            {
                Console.WriteLine("Lütfen geçerli bir id giriniz.");
            }
            return null;
        }

        public void Update(int instructorId, Instructor updatedInstructor)
        {
            instructorDal.Update(instructorId, updatedInstructor);
        }
    }
}
