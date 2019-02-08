using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public  class Program
    {
        static void Main(string[] args)
        {
            HR hr = new HR();
            Developer dev = new Developer();



            Console.WriteLine("HR's SALARY") ;
            Console.WriteLine("Enter the Experience");
            hr.Experience = int.Parse(Console.ReadLine());
            hr.salary_calc(hr.Experience);

            Console.WriteLine("DEVELOPER's SALARY");
            Console.WriteLine("Enter the Experience");
            dev.Experience = int.Parse(Console.ReadLine());
            dev.salary_calc(dev.Experience);

        }
    }
}

  
