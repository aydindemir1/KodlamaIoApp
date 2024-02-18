// See https://aka.ms/new-console-template for more information

using KodlamaIoApp.Business.Concretes;
using KodlamaIoApp.DataAccess.Abstracts;
using KodlamaIoApp.DataAccess.Concretes;
using KodlamaIoApp.Entities;

CategoryManager categoryManager = new CategoryManager(new CategoryDal());
CourseManager courseManager = new CourseManager(new CourseDal());
InstructorManager instructorManager = new InstructorManager(new InstructorDal());

Console.WriteLine("Kategoriye ait işlemler: ");
categoryManager.GetAll();
categoryManager.GetById(1);
categoryManager.GetAll();
Category updatedCategory = new Category(2, "Yazılım Kategorisi");
categoryManager.Update(1, updatedCategory);
Console.WriteLine("Güncellemeden sonra Kategori Listesi");
categoryManager.GetAll();
categoryManager.Delete(1);


Console.WriteLine("-----------------------------------------");

Console.WriteLine("Kurslara ait işlemler: ");
courseManager.GetAll();
courseManager.GetById(1);
courseManager.Delete(1);
Course updatedCourse = new Course(9,1,1, "Senior Level Yazılım Geliştirici Yetiştirme Kampı JAVA", "Bu Kamp İle Sektörde En İleri Seviyelere Geleceksiniz",0);
courseManager.Update(3, updatedCourse);
Console.WriteLine("Silinen ve güncellenen kurslardan sonra güncel liste hali: ");
courseManager.GetAll();

Console.WriteLine("-----------------------------------------");


Console.WriteLine("Eğitmenlere ait işlemler: ");
instructorManager.GetAll();
instructorManager.GetById(1);
Instructor updatedInstructor = new Instructor(3,1, "Ali Veli", "aliveli.jpg");
instructorManager.Update(1, updatedInstructor);
instructorManager.Delete(1);
Console.WriteLine("Silinen ve güncellenen eğitmenler sonrası güncel liste hali: ");
instructorManager.GetAll();
