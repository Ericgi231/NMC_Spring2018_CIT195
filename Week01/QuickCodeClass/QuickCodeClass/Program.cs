using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickCodeClass
{
    class Program
    {
        //eric grant
        //class quick code
        //1-17-2018
        //
        static void Main(string[] args)
        {
            Cat cat = new Cat();

            Console.WriteLine(cat.ReturnInfo());

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
