using System;
using System.Text;
namespace BasicConsoleIO
{ 
    public class BasicConsoleIO
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Basic Console I/O *****");
            GetUserData();
            Console.ReadLine();
        }

        private static void GetUserData()
        { 
            //Получить пользовательские данные
            Console.Write("Введите ваше имя: ");
            string userName = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            string userAge = Console.ReadLine();
            string mainMessage = $"**** Ваше имя {userName}, а лет вам {userAge} *****";


            //Ради прикола изменить цвет фона и текста консоли
            ConsoleColor startForegroundColor = Console.ForegroundColor;
            ConsoleColor startBackgoundColor = Console.BackgroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;


            //Вывести данные в консоль
            Console.Clear();
            Console.WriteLine(GetDesign(mainMessage));
            Console.WriteLine(mainMessage);
            Console.WriteLine(GetDesign(mainMessage));


            //Изменить цвет на тот, что был
            Console.ForegroundColor = startForegroundColor;
            Console.BackgroundColor = startBackgoundColor;
            Console.ReadLine();
            Console.Clear();
        }

        static string GetDesign(string mainMessage)
        {
            //Данный класс создан для прикола, просто выводить дизигн для Дяди Троелсена, ведь он так любит звезды =)

            //Создание и наполнения конструктора строки для нашего ДиЗиГнА
            StringBuilder sb = new StringBuilder("");
            for (int i = 0; i < mainMessage.Length; i++)
            {
                sb.Append("*");
            }
            return sb.ToString();
        }
        static string GetDesign(string mainMessage, string designElement)
        {
            //Данный класс создан для второго прикола, просто выводить дизигн для Дяди Троелсена, но при этом с желаемым элементом =)

            //Создание и наполнения конструктора строки для нашего ДиЗиГнА
            StringBuilder sb = new StringBuilder("");
            for (int i = 0; i < mainMessage.Length; i++)
            {
                sb.Append(designElement);
            }
            return sb.ToString();
        }

        static string GetMainMessage(string mainMessage)
        {
            //Данный класс создан для прикола, просто выводить дизигн для Дяди Троелсена, но при этом с желаемым элементом =)

            //Создание и наполнения конструктора строки для нашего ДиЗиГнА
            StringBuilder sb = new StringBuilder("");
            for (int i = 0; i < 5; i++)
            {
                sb.Append("*");
            }

            sb.Append($" {mainMessage} ");

            for (int i = 0; i < 5; i++)
            {
                sb.Append("*");
            }
            return sb.ToString();
        }
        static string GetMainMessage(string mainMessage, string designElement)
        {
            //Данный класс создан для прикола, просто выводить дизигн для Дяди Троелсена, но при этом с желаемым элементом =)

            //Создание и наполнения конструктора строки для нашего ДиЗиГнА
            StringBuilder sb = new StringBuilder("");
            for (int i = 0; i < 5; i++)
            {
                sb.Append(designElement);
            }

            sb.Append($" {mainMessage} ");

            for (int i = 0; i < 5; i++)
            {
                sb.Append(designElement);
            }
            return sb.ToString();
        }

        public static void ShowMainMessage(string mainText)
        {
            string mainMessage = GetMainMessage(mainText);
            string design = GetDesign(mainMessage);
            Console.WriteLine(design);
            Console.WriteLine(mainMessage);
            Console.WriteLine(design);
        }

        public static void ShowMainMessage(string mainText, string designElement)
        {
            string mainMessage = GetMainMessage(mainText, designElement);
            string design = GetDesign(mainMessage, designElement);
            Console.WriteLine(design);
            Console.WriteLine(mainMessage);
            Console.WriteLine(design);
        }

        public static void ShowMessage(string messageText, ConsoleColor ForegroundColor)
        {
            ConsoleColor baseFColor = Console.ForegroundColor;
            Console.ForegroundColor = ForegroundColor;
            Console.WriteLine(messageText);
            Console.ForegroundColor = baseFColor;
        }
    }
}