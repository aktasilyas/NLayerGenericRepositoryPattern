using DataAccess.concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class ContextStudent:DbContext
    {
        public ContextStudent() : base("StudentDb")
        {

        }

        public DbSet<Lesson>  Lessons { get; set; }
        public DbSet<Student>  Students { get; set; }
    }
}
