using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.Model
{
    internal class Teachers : BaseEntity
    {
        public int YearsOfService { get; set; }

        public int Salary { get; set; }

        public string Education { get; set; }

        public ICollection<Students> Students { get; set; }
    }
}
