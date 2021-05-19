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
    public class StudentRepository:Repository<Student>,IStudentRepository
    {
        public StudentRepository(DbContext context):base(context)
        {

        }

        public void GetStudent()
        {
            Console.WriteLine("student listed");
        }
    }
}
