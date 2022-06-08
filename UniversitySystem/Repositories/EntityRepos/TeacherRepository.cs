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
    internal class TeacherRepository : CrudRepository<Teachers>
    {
        public TeacherRepository(DbContext context) : base(context)
        {
        }
    }
}
