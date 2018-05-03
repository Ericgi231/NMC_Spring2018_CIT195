using System;
using System.Collections.Generic;

namespace Grant121_QuickLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>();

            myList = FillList(myList);
            PrintList(myList);

            Console.ReadKey();
        }

        static List<string> FillList(List<string> myList)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter item #{i}:\n>");
                myList.Add(Console.ReadLine());
                Console.WriteLine();
            }
            return myList;
        }

        static void PrintList(List<string> myList)
        {
            foreach (string txt in myList)
            {
                Console.WriteLine(txt);
            }
        }
    }
}
