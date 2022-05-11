using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblemAssignment
{
    public class PrimeNumber
    {
        public static void APrimeNumber() 
        {
            int number; 
            int a = 0;
            Console.Write("enter the Number");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                Console.WriteLine("{0} is a Prime Number", number);
            }
            else
            {
                Console.WriteLine("{0} Not a Prime Number", number);
            }
            Console.ReadLine();

        }

    }
    
}
