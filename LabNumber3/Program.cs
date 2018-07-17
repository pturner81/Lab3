using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber3
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int UserNumber;
            string UserName;

            Console.WriteLine("What is your name?");
            UserName = Console.ReadLine();
            Console.WriteLine($"Thank you {UserName}");
            Console.WriteLine("Enter a number 1-100.");
            UserNumber = int.Parse(Console.ReadLine());

            //process
            while (UserNumber <=0 || UserNumber > 100)
            {
                Console.WriteLine($"{UserName}- That did not fall between 1-100, please re-enter");
                UserNumber = int.Parse(Console.ReadLine());
            }
            if (UserNumber%2 == 1)
            {
                Console.WriteLine($"{UserName}- {UserNumber} is Odd");
            }
            else if (UserNumber >=2 && UserNumber <=25)
             {
                Console.WriteLine($"{UserName}- Your number ise ven and less than 25");
            }
            else if (UserNumber >=26 && UserNumber <=60)
            {
                Console.WriteLine($"{UserName}- Your number is even");
            }
            else if (UserNumber >= 60)
            {
                Console.WriteLine($"{UserName}- {UserNumber} is Even");
            }
            Console.WriteLine($"Press any key to end program {UserName}");
            Console.ReadKey();
            
        }
    }
}
