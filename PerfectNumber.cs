using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblemAssignment
{
    public class PerfectNumber
    {
        public static void AperfectNumber()
        {
            int number, sum = 0;
            Console.Write("enter the Number");
            number = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == number)
            {
                Console.WriteLine("\n Entered number is a perfect number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\n Entered number is not a perfect number");
                Console.ReadLine();
            }
        }
    }

}
          
