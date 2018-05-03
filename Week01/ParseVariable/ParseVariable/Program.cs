using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool valid = false;
            int min = 10;
            int max = 100;
            int maxAttempts = 3;
            int attempts = 0;

            Console.WriteLine();
            Console.WriteLine($"Attempts Left: {maxAttempts - attempts}");

            do
            {
                attempts = GetValidNum(attempts, min, max, out valid, out string message);
                message += $"\nAttempts Left: {maxAttempts - attempts}";
                Console.WriteLine(message);
            } while (!valid && attempts < maxAttempts);

            Console.WriteLine($"\nPress any key to exit.");
            Console.ReadKey();
        }

        static int GetValidNum(int attempts, int min, int max, out bool valid, out string message)
        {
            valid = false;

            Console.WriteLine($"\nPlease enter a valid number between {min} and {max}");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                if (num < min)
                {
                    message = "That number is below the minimum.";
                }
                else if (num > max)
                {
                    message = "That number exceeds the max.";
                }
                else
                {
                    message = "Input is valid.";
                    valid = true;
                }
            }
            else
            {
                message = "That is not a number.";
            }

            Console.Clear();

            if (!valid)
            {
                attempts++;
            }
            return attempts;
        }
    }
}
