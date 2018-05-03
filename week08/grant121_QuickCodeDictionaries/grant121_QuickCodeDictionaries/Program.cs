using System;
using System.Collections.Generic;

namespace grant121_QuickCodeDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> dic = new Dictionary<string,int>();
            GetItems(dic);
            DisplayItems(dic);
        }

        static Dictionary<string,int> GetItems(Dictionary<string,int> dic)
        {
            string name;
            int num;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter a type of gem:\n");
                name = GetValidKey(dic);

                Console.Write("Enter the value of the gem:\n");
                num = GetValidInt();

                dic.Add(name,num);
                Console.WriteLine();
            }

            return dic;
        }

        static int GetValidInt()
        {
            string txt;
            int num;
            do
            {
                Console.Write(">");
                txt = Console.ReadLine();
            } while (!int.TryParse(txt, out num));
            return num;
        }

        static string GetValidKey(Dictionary<string,int> dic)
        {
            string txt;
            bool valid = false;
            do
            {
                Console.Write(">");
                txt = Console.ReadLine();
                if (!dic.ContainsKey(txt))
                {
                    valid = true;
                }
            } while (!valid);
            return txt;
        }

        static void DisplayItems(Dictionary<string,int> dic)
        {
            Console.Clear();

            Console.WriteLine("Gem".PadRight(8,'.') + "Value");
            foreach (KeyValuePair<string,int> gem in dic)
            {
                Console.WriteLine(gem.Key.PadRight(8, '.') + "$" + gem.Value);
            }

            Console.ReadKey();
        }
    }
}
