using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YesNoValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            CodeBockBock codeBockBock = new CodeBockBock();

            bool valid = false;
            string question = "Do you like cats?";
            int maxAttempts = 5;
            int attempts = 0;
            bool answer;

            do
            {
                Console.WriteLine($"Attempts Left: {maxAttempts - attempts}\n{question}");
                answer = codeBockBock.GetResponse(out valid, maxAttempts, attempts);
                attempts++;
                Console.Clear();
            } while (!valid);

            Console.WriteLine("Thankyou for your response.");
            if (answer)
            {
                Console.WriteLine("You cat loving saint.");
            }
            else
            {
                Console.WriteLine("You filthy cat hater.");
            }

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
