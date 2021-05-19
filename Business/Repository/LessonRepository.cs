using Business.Interface;
using DataAccess.concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class LessonRepository:Repository<Lesson>,ILessonRepository
    {
        public LessonRepository(DbContext context):base(context)
        {

        }

        public void GetLesson()
        {
            Console.WriteLine("lesson listed");
        }
    }
}
