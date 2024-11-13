using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypeInC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp e1=new Emp(1,"Pratik",Department.HR,Role.CEO);
            Console.WriteLine(e1);
        }
    }
}
