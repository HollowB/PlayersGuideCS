using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    class Math
    {
        public static double TheTriangleFarmer()
        {
            Console.Clear();
            Console.WriteLine("-------------------");
            Console.WriteLine("The Triangle Farmer");
            Console.WriteLine("-------------------");

            double baseSize, height, area;
            Console.Write($"\nInput the base size of triangle: ");
            baseSize = double.Parse(Console.ReadLine());
            
            Console.Write($"\nInput the height of triangle: ");
            height = double.Parse(Console.ReadLine());
            area = (double)((baseSize * height) / 2.0);

            Console.WriteLine($"Triangle area is: {area}");
            return area;

            //I'm comlete "The Triangle Farmer" challenge!
            //+100xp recived!!!
        }

        public static int SistersAndDuckbear(out int duckbearCount)
        {
            Console.Clear();
            Console.WriteLine("-------------------");
            Console.WriteLine("The Four sisters and the Duckbear");
            Console.WriteLine("-------------------");

            int common, sister;
            Console.Write("Enter the number of eggs gathered today: ");
            common = int.Parse(Console.ReadLine());

            sister = common / 4;
            duckbearCount = common % 4;

            return sister;
            //I'm comlete "The Four sisters and the Duckbear" challenge!
            //+100xp recived!!!

            //Answer the question
            //0<eggs<4,5<eggs<8,11
        }

        public static void DominionOfKings()
        {
            Console.Clear();
            Console.WriteLine("-------------------");
            Console.WriteLine("The Dominion of Kings");
            Console.WriteLine("-------------------");

            bool end = false;
            string name = "";
            Dictionary<string, Dictionary<string, int>> kings = new Dictionary<string, Dictionary<string, int>>();
            while (!end)
            {
                Console.Clear();
                Console.Write("Dear King, please tell me your name: ");
                name = Console.ReadLine();
                kings.Add(name, GetKingdomState(name));
                Console.Clear();
                
                Console.WriteLine("Is it enough?");
                string answer = Console.ReadLine();
                switch (answer.ToLower())
                {
                    case "da":
                    case "да":
                    case "yes":
                        end = true;
                        break;
                    _:
                        end = false;
                        break;
                }
            }
            ShowKingdomsScore(kings);
            //I'm comlete "The Dominion of Kings" challenge!
            //+100xp recived!!!
        }

        private static Dictionary<string, int> GetKingdomState(string kingName)
        {
            Console.Clear();
            int estate, duchy, province;
            Dictionary<string, int> state = new Dictionary<string, int>();
            Console.WriteLine($"Dear,King {kingName}, please, enter state of your kingdom.");
            Console.Write("Estates: ");
            state.Add("estate",int.Parse(Console.ReadLine()));
            Console.Write("Duchies: ");
            state.Add("duchy", int.Parse(Console.ReadLine()));
            Console.Write("Provinces: ");
            state.Add("province", int.Parse(Console.ReadLine()));
            return state;
        }

        private static void ShowKingdomsScore(Dictionary<string, Dictionary<string, int>> kings)
        {
            Console.Clear();
            foreach(KeyValuePair<string, Dictionary<string, int>> kvp in kings)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine($"{kvp.Key} score: {GetKingdomScore(kvp.Value)}");
                Console.WriteLine("-------------------------");
            }
        }

        private static int GetKingdomScore(Dictionary<string, int> value)
        {
            int score = 0;
            score += value["estate"];
            score += value["duchy"] * 3;
            score += value["province"] * 6;

            return score;

        }
    }
}
