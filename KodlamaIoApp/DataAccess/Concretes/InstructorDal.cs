using KodlamaIoApp.DataAccess.Abstracts;
using KodlamaIoApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoApp.DataAccess.Concretes
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> instructors;

        public InstructorDal()
        {
            instructors = new List<Instructor>();

            instructors.Add(new Instructor(1,1, "Engin Demiroğ","engindemirog.jpg"));
            instructors.Add(new Instructor(2,1,"Halit Enes Kalaycı", "haliteneskalayci.jpg"));
        }
        public void Add(Instructor instructor)
        {
            instructors.Add(instructor);
        }

        public void Delete(int instructorId)
        {
            Instructor instructorToDelete = null;
            foreach (var instructor in instructors)
            {
                if (instructor.InstructorId == instructorId)
                {
                    instructorToDelete = instructor;
                    break; // Silinecek eğitmen bulunduğunda döngüyü sonlandır
                }
            }

            if (instructorToDelete != null)
            {
                instructors.Remove(instructorToDelete);
                Console.WriteLine("Eğitmen başarıyla silindi.");
            }
            else
            {
                Console.WriteLine("Belirtilen ID'ye sahip bir eğitmen bulunamadı.");
            }
        }

        public List<Instructor> GetAll()
        {
            Console.WriteLine("Eğitmenler Listelendi");
            foreach (var instructor in instructors)
            {
                Console.WriteLine( instructor.InstructorName);
            }
            return instructors;
        }

        public Instructor GetById(int id)
        {
            foreach (var instructor in instructors)
            {
                if (instructor.InstructorId == id)
                {
                    Console.WriteLine(instructor.InstructorName + " isimli eğitmen bulundu");
                    return instructor;

                }
                else
                {
                    Console.WriteLine(id + " li eğitmen bulunamadı.");
                }
            }
            return null;
        }

        public void Update(int instructorId, Instructor updatedInstructor)
        {
            foreach (var instructor in instructors)
            {
                if (instructor.InstructorId == instructorId)
                {
                    instructor.InstructorName = updatedInstructor.InstructorName;
                    Console.WriteLine("Eğitmen başarıyla güncellendi.");
                    return;
                }
            }
            Console.WriteLine("Belirtilen ID'ye sahip bir eğitmen bulunamadı.");
        }
    }
}
