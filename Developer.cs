using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Developer : Employee
    {
        public override void salary_calc(int Experience)
        {


            int salary = 8000 + (2000 * Experience);
            Console.WriteLine("The salary is"+salary);
        }
    }
}
