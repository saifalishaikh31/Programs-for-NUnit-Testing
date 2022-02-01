using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NUnitTesting
{
    class VendingMachine
    {
        public void Amount()
        {
            Console.WriteLine("Enter the amount to change :");
            int amount = Convert.ToInt32(Console.ReadLine());
            vendingMachine(amount);
        }
        public static void vendingMachine(int amount)
        {
            int[] notes = new int[] { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int[] noteCounter = new int[notes.Length];

            for (int i = 0; i < notes.Length; i++)
            {
                if (amount >= notes[i])
                {
                    noteCounter[i] = amount / notes[i];
                    amount = amount - noteCounter[i] * notes[i];
                }
            }

            Console.WriteLine("Currency Count ->");
            int noOfNotes = 0;
            for (int i = 0; i < notes.Length; i++)
            {
                if (noteCounter[i] != 0)
                {
                    Console.WriteLine(notes[i].ToString().PadLeft(4) + " : " + noteCounter[i]);
                    noOfNotes += noteCounter[i];
                }
            }
            Console.WriteLine("Minimum number of notes : " + noOfNotes);
        }
    }
}
