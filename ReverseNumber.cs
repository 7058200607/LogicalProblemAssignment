using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblemAssignment
{
    public class ReverseNumber
    {
        public static void AReverseNumber() 
        {
            // initializing number
            int number;
            Console.Write("enter the Number");
            number = Convert.ToInt32(Console.ReadLine());

            int reverseumber = 0;
            int remainder = 0;
            Console.WriteLine("Number before reverse = " + number);

            //reverse number logic
            for (remainder = 0; number > 0; number = number / 10)
            {
                remainder = number % 10;

                reverseumber = reverseumber * 10 + remainder;
            }
            Console.WriteLine("Number after reverse  = " + reverseumber);
        }
    }
} 

