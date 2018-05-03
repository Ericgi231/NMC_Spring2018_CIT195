using System;
using System.Collections.Generic;

namespace Grant121_QuickCode
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>()
            {
                "Eric",
                "Nicole",
                "Nick",
                "Kat",
                "Joey",
                "Kylie"
            };

            names.Sort();

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadKey();
        }
    }
}
