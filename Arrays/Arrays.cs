using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BasicConsoleIO.BasicConsoleIO;

namespace Arrays
{
    class Arrays
    {
        public static void ReplicatorOfDTo()
        {
            int arrayLength;
            ShowMainMessage("The Replicator of D'To");

            GetUserInput("Введите длинну массива: ", out arrayLength);
            
            int[] userArray = new int[arrayLength];
            int[] copyArray = new int[userArray.Length];

            Console.Clear();
            ShowMainMessage("The Replicator of D'To");
            GetUserArray(arrayLength, userArray);

            Console.Clear();
            ShowMainMessage("The Replicator of D'To");

            CopyUserArray(userArray, copyArray);

            ShowArrays(userArray, copyArray);

            LawsOfFreach(copyArray);
        }

        public static void LawsOfFreach(int[] array)
        {
            float averageValue;
            int minValue;
            Console.Clear();

            ShowMainMessage("The Laws of Freach");

            GetMinValue(array, out minValue);
            GetAvgValue(array, out averageValue);

            ShowMessage($"\nСреднее значение элементов массива: {averageValue}", ConsoleColor.Magenta);
            ShowMessage($"\nМинимальное значение элементов массива: {minValue}", ConsoleColor.Cyan);

        }

        private static void GetAvgValue(int[] array, out float averageValue)
        {
            int sum = default;
            averageValue = 0;
            foreach (int item in array)
            {
                sum += item;
            }
            averageValue = (float)sum / array.Length; 
        }

        private static void GetMinValue(int[] array, out int minValue)
        {
            minValue = int.MaxValue;
            foreach (int item in array)
            {
                minValue = (item < minValue) ? item : minValue;
            }
        }

        private static void GetUserArray(int arrayLength, int[] userArray)
        {
            
            int value;
            
            
            for (int i = 0; i < arrayLength; i++)
            {
                GetUserInput($"Введите {i+1} значение массива: ", out value);
                userArray[i] = value;
            }
        }

        private static void CopyUserArray(int[] userArray, int[] copyArray)
        {
            for (int i = 0; i < userArray.Length; i++)
            {
                copyArray[i] = userArray[i];
            }
        }
        private static void ShowArrays(int[] userArray, int[] copyArray)
        {
            

            ShowMessage(nameof(userArray), ConsoleColor.DarkGreen);
            for (int i = 0; i < userArray.Length; i++)
            {
                ShowMessage($"\n{i + 1} значение массива: {userArray[i]}", ConsoleColor.Green);
            }

            Console.WriteLine();
            
            ShowMessage(nameof(copyArray), ConsoleColor.DarkYellow);
            for (int i = 0; i < copyArray.Length; i++)
            {
                ShowMessage($"\n{i + 1} значение массива: {copyArray[i]}", ConsoleColor.Yellow);
            }
        }
    }
}
