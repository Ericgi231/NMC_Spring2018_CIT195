using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YesNoValidator
{
    class CodeBockBock
    {
        public bool GetResponse(out bool valid, int maxAttempts, int attempts)
        {
            string uInput;
            bool answer = false;

            Console.WriteLine("Yes or No?");

            uInput = Console.ReadLine().ToLower();

            if (attempts < maxAttempts - 1)
            {
                switch (uInput)
                {
                    case "yes":
                    case "y":
                        valid = true;
                        answer = true;
                        break;

                    case "no":
                    case "n":
                        valid = true;
                        answer = false;
                        break;

                    default:
                        attempts++;
                        valid = false;
                        break;
                }
            }
            else
            {
                valid = false;
                Console.Clear();
                Console.WriteLine("You failed to respond to a yes or no question, you idiot, good job.");
                Console.WriteLine("\nPress any key to exit.");
                Console.ReadKey();
                Environment.Exit(0);
            }

            return answer;
        }
    }
}
