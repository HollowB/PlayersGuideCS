using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BasicConsoleIO.BasicConsoleIO;
namespace Looping
{
    public class Looping
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

        public static void MagicCanon()
        {
            for (int nBlast = 1; nBlast < 100; nBlast++)
            {
                if ((nBlast % 3) == 0 && (nBlast % 5) == 0)
                {
                    ShowMessage($"{nBlast}. Комбинированный", ConsoleColor.Blue);
                }
                else if ((nBlast % 3) == 0)
                {
                    ShowMessage($"{nBlast}. Огненный", ConsoleColor.Red);
                }
                else if ((nBlast % 5) == 0)
                {
                    ShowMessage($"{nBlast}. Электрический", ConsoleColor.Yellow);
                }
                else
                {
                    ShowMessage($"{nBlast}. Нормальный", ConsoleColor.DarkGreen);
                }
            }
        }

        public static void GetPilotNumber(out int pilotNumber)
        {
            do
            {
                GetUserInput("Введите значение от 0 до 100: ", out pilotNumber);
                Console.WriteLine(!(0 <= pilotNumber && pilotNumber <= 100) ? "Неверное значение, попробуйте ещё." : "Введено верное значение");
            } while (!(0 <= pilotNumber && pilotNumber <= 100));
        }
        public static void GetHunterGuess(int pilotNumber, out int hunterNumber)
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
