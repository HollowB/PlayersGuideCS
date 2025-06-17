using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Tuples.Menu;
using static BasicConsoleIO.BasicConsoleIO;
namespace Classes
{
    public class Arrow
    {
        private Arrowhead Head { get; set; }
        private int Shaft { get; }
        private Fletching Fletch { get; set; }

        public Arrow()
        {
            int length = 0;
            string head = InitiateMenu(Enum.GetNames(typeof(Arrowhead)), "Наконечник");
            Console.Clear();

            string fletch = InitiateMenu(Enum.GetNames(typeof(Fletching)), "Оперение");
            Console.Clear();

            GetUserInputInGange("Введите длину древка(от 60 до 100): ", 60, 100, out length);
            Head = (Arrowhead)Enum.Parse(typeof(Arrowhead), head);
            Fletch = (Fletching)Enum.Parse(typeof(Fletching), fletch);
            Shaft = length;
        }

        public float GetCost()
        {
            return (float)((float)this.Fletch + (float)Head + (float)Shaft * 0.5); 
        }

    }
}
