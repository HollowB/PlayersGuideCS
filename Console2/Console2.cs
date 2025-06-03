using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2
{
    using BasicConsoleIO;
    class Console2
    {
        public static void DefenceOfConsolas()
        {
            int row, column;
            BasicConsoleIO.ShowMainMessage("The Defense Of Consolas");

            Console.Title = "Defense of Consolas";

            Console.Write("Enter Target Row: ");
            row = int.Parse(Console.ReadLine());
            Console.Write("Enter Target Column: ");
            column = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDeply to:");

            BasicConsoleIO.ShowMessage($"({row}, {column - 1})", ConsoleColor.Red);
            BasicConsoleIO.ShowMessage($"({row - 1}, {column})", ConsoleColor.Blue);
            BasicConsoleIO.ShowMessage($"({row}, {column + 1})", ConsoleColor.Magenta);
            BasicConsoleIO.ShowMessage($"({row + 1}, {column})", ConsoleColor.Cyan);
            Console.Beep();
            Console.ReadKey(); 
        }
    }
}
