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
                                  +"\n 2.Day Of Week"
                                  +"\n 3.Exit");
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
