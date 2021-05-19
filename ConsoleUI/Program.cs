using Business.Repository;
using DataAccess.concrete;
using DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new ContextStudent());
            //unitOfWork.StudentRepositories.Add(new Student() { FirstName = "ilyas", LastName = "aktas", NationalIdentity = "3412312" });
            //unitOfWork.LessonRepositories.Add(new Lesson() { Name = "Matematik", Credit = 4 });
            //unitOfWork.LessonRepositories.Add(new Lesson() { Name = "Felsefe", Credit = 6 });
            //unitOfWork.LessonRepositories.Delete(4);
            unitOfWork.LessonRepositories.Update(new Lesson() { Id = 3, Name = "fizik", Credit = 5 });

            unitOfWork.Save();
            foreach (var item in unitOfWork.LessonRepositories.GetAll(p=>p.Name=="felsefe"))
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadLine();

            
        }


        //proje calisti 5 dakika ya geliyorum...
    }
}
