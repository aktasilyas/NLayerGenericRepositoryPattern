using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interface
{
    interface IUnitOfWork:IDisposable
    {
         int Save();
         ILessonRepository  LessonRepositories { get;}
         IStudentRepository StudentRepositories { get; }
    }
}
