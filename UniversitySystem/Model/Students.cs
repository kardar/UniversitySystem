using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.Model
{
    internal class Students : BaseEntity
    {
        public Students()
        {

        }
        public Students(string name, int age, string address, int samester, int cgpa, Departments departments3)
        {
            Name = name;
            Age = age;
            Address = address;
            Samester = samester;
            Cgpa = cgpa;
            Departments3 = departments3;
        }

        public int Cgpa { get; set; }

        public int Samester { get; set; }
        public Departments Departments { get; set; }

        public ICollection<Teachers> Teachers { get; set; }
       
        public Departments Departments3 { get; }
    }
}
