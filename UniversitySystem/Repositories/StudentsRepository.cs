using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.Repositories
{
    internal class StudentsRepository : CrudRepository<Model.Students>
    {
        public StudentsRepository(DbContext context) : base(context)
        {
        }
    }
}
