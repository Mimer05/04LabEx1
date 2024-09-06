using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04LabEx1
{
    internal class ConsoleProgram
    {
        static void Main(string[] args)
        {  
            // constant apple cost that cannot change
            const double AppleCost = 32.50;

            //introduction
            Console.WriteLine("============== Apple Store ===============");
            Console.WriteLine("\tWelcome to apple store!");
            Console.WriteLine("\n\tThe apple cost: " + AppleCost);

            //input of number of apples
            Console.Write("\nEnter the number of Apples you want to purchase: ");Console.Beep();
            int NumberOfApples = Convert.ToInt32(Console.ReadLine());

            //Calculation of the apple and the number of user want
            double TheTotal = AppleCost * NumberOfApples;
            //the converted price to whole number
            int ConvertTotal = Convert.ToInt32(Math.Floor(TheTotal));

            Console.WriteLine("\n\t\tCalculating....\n");

            Console.WriteLine("============== The Total Cost ===============");
            Console.WriteLine("   The total price of "+ NumberOfApples + " apples is: "+TheTotal);Console.Beep();
            Console.WriteLine("   The value of the converted price is: " + ConvertTotal);
            Console.ReadKey();
        }
    }
}
