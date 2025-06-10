using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BasicConsoleIO.BasicConsoleIO;

namespace Methods
{
    class Recursive
    {
        
        public static void CountDown(int number)
        {
            Console.WriteLine(number);
            if (number > 1)
            {
                CountDown(number - 1);
            }
            return;
        }
    }
}
