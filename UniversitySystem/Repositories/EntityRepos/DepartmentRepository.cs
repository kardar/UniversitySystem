using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySystem.Model;
using UniversitySystem.Repositories.GenericRepos;

namespace UniversitySystem.Repositories.EntityRepos
{
    internal class DepartmentRepository : CrudRepository<Departments>
    {
        public DepartmentRepository(DbContext context) : base(context)
        {
        }
    }
}
