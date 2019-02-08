using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class HR:Employee
    {
        public override void salary_calc( int Experience)
        {
            int salary = 8000 + (1000 * Experience);
            Console.WriteLine("The salary is:"+ salary);
        }
    }
}
