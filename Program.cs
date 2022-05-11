using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LogicalProblemAssignment 
{

    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("0.Calculate Fibonacci series");
            Console.WriteLine("1.Calulate Perfect Number");
            Console.Write("Enter A Choice :");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    Fibonacciseries.AFibonacciseries();

                    break;
                case 1:
                    PerfectNumber.AperfectNumber();
                    break;
            }
        }
    }
}

