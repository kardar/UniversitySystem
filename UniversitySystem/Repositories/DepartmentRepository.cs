using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySystem.Model;

namespace UniversitySystem.Repositories
{
    internal class DepartmentRepository : CrudRepository<Departments>
    {
        public DepartmentRepository(DbContext context) : base(context)
        {
        }
    }
}
