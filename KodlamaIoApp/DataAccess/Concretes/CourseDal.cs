using KodlamaIoApp.DataAccess.Abstracts;
using KodlamaIoApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoApp.DataAccess.Concretes
{
    public class CourseDal : ICourseDal
    {
        List<Course> courses;

        public CourseDal()
        {
            courses = new List<Course>();
            
            courses.Add(new Course(1,1,1, "Senior Yazılım Geliştirici Yetiştirme Kampı .NET","Bu Kamp İle Sektörde En İyi Noktalara Geleceksiniz",0));
            courses.Add(new Course(2,1,1, "2024 Yazılım Geliştirici Yetiştirme Kampı C#","Bu Kamp İle Sıfırdan Profesyonel Seviyeye Geleceksiniz",0));
            courses.Add(new Course(3,1,1, "Yazılım Geliştirici Yetiştirme Kampı C# - ANGULAR","Bu Kamp İle Sıfırdan Profesyonel Seviyeye Geleceksiniz",0));
            courses.Add(new Course(4,1,1, "2022 Yazılım Geliştirici Yetiştirme Kampı - JAVA", "Bu Kamp İle Sıfırdan Profesyonel Seviyeye Geleceksiniz", 0));
            courses.Add(new Course(5,1,1, "Yazılım Geliştirici Yetiştirme Kampı JAVA - REACT", "Bu Kamp İle Sıfırdan Profesyonel Seviyeye Geleceksiniz", 0));
            courses.Add(new Course(6,2,1, "2023 Yazılım Geliştirici Yetiştirme Kampı PYTHON - SELENİUM", "Bu Kamp İle Sıfırdan Profesyonel Seviyeye Geleceksiniz", 0));
            courses.Add(new Course(7,1,1, "Yazılım Geliştirici Yetiştirme Kampı Javascript", "Bu Kamp İle Sıfırdan Profesyonel Seviyeye Geleceksiniz", 0));
            courses.Add(new Course(8,1,1, "Programlamaya Giriş İçin Temel Kurs", "Bu Kurs İle Sıfırdan Programlamanın Temellerini Öğreneceksiniz", 0));

        }
        public void Add(Course course)
        {
            courses.Add(course);
        }

        public void Delete(int courseId)
        {
            Course courseToDelete = null;

            foreach (var course in courses)
            {
                if(course.CourseId == courseId)
                {
                    courseToDelete = course;
                    break;
                }
            }

            if(courseToDelete != null)
            {
                courses.Remove(courseToDelete);
                Console.WriteLine("Course başarıyla silindi");
            }
            else
            {
                Console.WriteLine("Belirtilen ID'ye sahip bir kurs bulunamadı.");
            }

        }

        public List<Course> GetAll()
        {
            Console.WriteLine("Kurslar listelendi: ");
            foreach (var course in courses)
            {
                Console.WriteLine( course.CourseName);
            }
            return courses;

        }

        public Course GetById(int id)
        {
            foreach (var course in courses)
            {
                if (course.CourseId == id)
                {
                    Console.WriteLine(id + " id li  " + course.CourseName + " isimli kurs bulundu.");
                    return course;
                }
                else
                {
                    Console.WriteLine(id + " id li kurs bulunamadı.");
                    return null;
                }
            }
            if(courses.Count == 0)
            {
                Console.WriteLine("Kurs listesi boş.");
               
            }
            return null;
          
        }

        public void Update(int courseId,  Course updatedCourse)
        {
            foreach (var course in courses)
            {
                if (course.CourseId == updatedCourse.CourseId)
                {
                    course.CourseName = updatedCourse.CourseName;
                    Console.WriteLine("Kurs başarıyla güncellendi.");
                    return;
                }
            }
            Console.WriteLine("Belirtilen ID'ye sahip bir kurs bulunamadı.");
        }
    }
}
