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

            GetUserArray(arrayLength, userArray);

            CopyUserArray(userArray, copyArray);

            ShowArrays(userArray, copyArray);
        }


        private static void GetUserArray(int arrayLength, int[] userArray)
        {
            Console.Clear();
            int value;
            ShowMainMessage("The Replicator of D'To");
            
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
            Console.Clear();
            ShowMainMessage("The Replicator of D'To");

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
