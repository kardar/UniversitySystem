using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.Model
{
    internal class Students : BaseEntity
    {
        public int Cgpa { get; set; }

        public int Samester { get; set; }
        public Departments Departments { get; set; }

        public ICollection<Teachers> Teachers { get; set; }
    }
}
