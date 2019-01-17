using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_16_19Lab4TableofPowers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Please enter an integer.");

                string userInput = Console.ReadLine();
                long userNumber = int.Parse(userInput);

                Console.WriteLine();
                Console.WriteLine("Number           Squared           Cubed");
                Console.WriteLine("=======          ========          =======");

                for (int i = 1; i <= userNumber; i++)
                {
                    Console.WriteLine("{0}                 {1}                 {2}", i, i * i, i * i * i);
                }

                Console.WriteLine("Would you like to continue entering integers? (Y/N)");
                userInput = Console.ReadLine().ToUpper();
                if (userInput == "N")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
            }

        }
    }
}
