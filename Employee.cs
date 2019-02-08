using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public abstract class Employee
    {
        public int Id;
        public string Name;
        public string Designation;
        public int Experience;
        public int Annual_salary;
        public string joining_date;

        public abstract void salary_calc( int Experience);
    }
}
