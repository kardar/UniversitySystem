using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySystem.Model;

namespace UniversitySystem.Repositories
{
    internal class TeacherRepository : CrudRepository<Teachers>
    {
        public TeacherRepository(DbContext context) : base(context)
        {
        }
    }
}
