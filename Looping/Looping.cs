using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BasicConsoleIO.BasicConsoleIO;
namespace Looping
{
    class Looping
    {
        public static void Prototype()
        {
            int pilotNumber, hunterNumber;
            
            ShowMainMessage("Prototype");
            GetPilotNumber(out pilotNumber);
            Console.Clear();
            
            ShowMainMessage("Prototype");
            GetHunterGuess(pilotNumber, out hunterNumber);
        }


        private static void GetPilotNumber(out int pilotNumber)
        {
            do
            {
                GetUserInput("Введите значение от 0 до 100: ", out pilotNumber);
                Console.WriteLine(!(0 <= pilotNumber && pilotNumber <= 100) ? "Неверное значение, попробуйте ещё." : "Введено верное значение");
            } while (!(0 <= pilotNumber && pilotNumber <= 100));
        }
        private static void GetHunterGuess(int pilotNumber, out int hunterNumber)
        {
            Console.WriteLine();
            do
            {
                GetUserInput("Введите предположение о загаданном значении (от 0 до 100): ", out hunterNumber);
                if (hunterNumber < pilotNumber)
                {
                    ShowMessage("Значение слишком низкое.\n", ConsoleColor.Red);
                }
                else if (hunterNumber > pilotNumber)
                {
                    ShowMessage("Значение слишком высокое.\n", ConsoleColor.Red);
                }
                else
                {
                    ShowMessage($"Угадано верное значение \"{hunterNumber}\" !", ConsoleColor.Green);
                }

            } while (!(pilotNumber == hunterNumber));
        }
    }
}
