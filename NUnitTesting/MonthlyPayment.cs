using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NUnitTesting
{
    class MonthlyPayment
    {
        public void CalculateMonthlyPayment()
        {
            Console.Write("Enter the year to pay off : ");
            double Y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Principal amount : ");
            double P = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter percent interest compounded monthly : ");
            double R = Convert.ToDouble(Console.ReadLine());
            double n = 12 * Y;
            double r = R / 12 * 100;
            double numerator = P * r;
            double denomenator = 1 - Math.Pow(1 + r, -n);
            double payment = numerator / denomenator;
            Console.WriteLine("Payment: " + payment);
        }
    }
}
