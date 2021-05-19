using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.concrete
{
    public class Lesson:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Credit { get; set; }

        public ICollection<Student>  Students { get; set; }
    }
}
