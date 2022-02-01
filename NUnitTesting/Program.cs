using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NUnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
             bool flag = true;
             while (flag)
             {
                 Console.WriteLine("\n 1.Vending Machine."
                                  +"\n 2.Day Of Week."
                                  +"\n 3.Temperature Conversion."
                                  +"\n 4.Monthly Payment."
                                  +"\n 5.Square Root using Newtons Method."
                                  +"\n 6.Exit");
                 int option = Convert.ToInt32(Console.ReadLine());
                 switch (option)
                 {
                     case 1:
                         VendingMachine vendingmachine = new VendingMachine();
                         vendingmachine.Amount();
                         break;
                     case 2:
                         DayOfWeek dayofweek = new DayOfWeek();
                         dayofweek.GetData();
                         break;
                     case 3:
                         TempConversion tempconv = new TempConversion();
                         tempconv.TemperatureConversion();
                         break;
                     case 4:
                         MonthlyPayment monthlypay = new MonthlyPayment();
                         monthlypay.CalculateMonthlyPayment();
                         break;
                     case 5:
                         SqrtNewtonsMethod sqrt = new SqrtNewtonsMethod();
                         sqrt.FindSqrt();
                         break;
                     case 6:
                         flag = false;
                         break;
                     default: 
                         Console.WriteLine("Choose Correct option");
                         break;

                 }
             }
        }
    }
}
