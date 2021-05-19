using Business.Interface;
using DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public ILessonRepository LessonRepositories { get; }

        public IStudentRepository StudentRepositories { get; }
        private  DbContext _context;

        public UnitOfWork(DbContext context)
        {
            _context = context;
            LessonRepositories = new LessonRepository(_context);
            StudentRepositories = new StudentRepository(_context);
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
