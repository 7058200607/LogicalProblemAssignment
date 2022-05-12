using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblemAssignment
{
    public class CouponNumber
    {
        public static void ACouponCode()
        {
            Console.Write("\nenter the Number of Coupon : ");
            int number = Convert.ToInt32(Console.ReadLine());
            string coupons = string.Empty;
            while(number > 0) 
            {
                int random=new Random().Next(1,100);
                coupons +=(char)random;
                number--;
            }
            Console.WriteLine("Your Coupon Number is " +coupons);
        }
    }
}

   

