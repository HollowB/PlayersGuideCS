using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DecisionMaking
{
using BasicConsoleIO;
    class DecisionMaking
    {
        public static void ReparingTheClocktower()
        {
            int number;
            BasicConsoleIO.ShowMainMessage("Reparing the Clocktower", "%");
            Console.Write("Enter the clock number: ");
            number = int.Parse(Console.ReadLine());
            string sound = number % 2 == 0 ? "Tick" : "Tock";
            Console.WriteLine($"{sound}");
            
        }
    }
}
