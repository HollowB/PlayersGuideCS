using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static BasicConsoleIO.BasicConsoleIO;
namespace Tuples
{
    public class Menu
    {
        public static string InitiateMenu(string[] items, string name)
        {
            
            string item = GetUserChoise(items, name);
            return item;
        }

        private static string GetUserChoise(string[] items, string name)
        {
            int choise = -1;
            do
            {
                Console.Clear();
                ShowMenu(items, name);
                Console.WriteLine();
                GetUserInput("Введите свой выбор ", out choise);

            } while (!(choise-1 >= 0 && choise-1 <= items.Length-1));
            return items[choise-1];
        }

        private static void ShowMenu(string[] items, string name)
        {
            
            ShowMessage($"Выберите {name}", ConsoleColor.Magenta);
            for (int i = 0; i < items.Length; i++)
            {
                ShowMessage($"\t{i + 1}. {items[i]}", ConsoleColor.White);
            }
        }
    }
}
