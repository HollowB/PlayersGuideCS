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

        public static void Watchtower()
        {
            BasicConsoleIO.ShowMainMessage("Watchtower");
            int x, y;
            BasicConsoleIO.GetUserInput("Enter X coordinate: ", out x);
            BasicConsoleIO.GetUserInput("Enter Y coordinate: ", out y);

            BasicConsoleIO.ShowMessage(GetDecision(x, y), ConsoleColor.Red);
        }

        private static string GetDecision(int x, int y)
        {
            
            if (x < 0)
            {  
                return  y  switch 
                {
                    >0 => "NW",
                    0 => "W",
                    <0 => "SW"
                }; 
            }

            if (x == 0)
            {
                return y switch
                {
                    > 0 => "N",
                    0 => "!",
                    < 0 => "S"
                };
            }

            if (x > 0)
            {
                return y switch
                {
                    > 0 => "NE",
                    0 => "E",
                    < 0 => "SE"
                };
            }

            return "wrong value, vam pizdec";
        }
    }
}
