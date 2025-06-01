namespace HelloWorld
{
    internal class ContactWithWorld
    {
        static void Main(string[] args)
        {
            bool end = false;
            List<string> breadTakers = new List<string>();
            var msg = "Hello, World!";
            HeroSays(msg);
            HeroSays("Talking something ccesides \"Hello, World!\" ");
            HeroSays("What i can say for you?");
            HeroSays("I'm Hero the Programmer!");
            HeroSays("Who the Unicode One?!");
            Console.ReadKey();
            while (!end)
            {
                breadTakers.Add(TelimGivingBread(out end));
            }

            Console.Clear();
            foreach(string note in breadTakers)
            {
                Console.WriteLine(note);
            }
            Console.ReadKey();

            TheThingNamer3000();
        }

        public static void HeroSays(string message)
        {
            Console.WriteLine($"Hero says: {message}");
        }

        public static string TelimGivingBread(out bool end)
        {
            Console.Clear();
            Console.WriteLine("Bread is ready.");
            Console.WriteLine("Who is bread for?");
            string name = Console.ReadLine();
            string result = ($"Noted: {name} got bread.");
            Console.WriteLine(result);
            Console.WriteLine("Is it enough?");
            string answer = Console.ReadLine();
            end = false;
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
            return result;
        }

        static void TheThingNamer3000()
        {
            Console.Clear();
            Console.WriteLine("What kind of thing we are talking about?");
            //string a = Console.ReadLine();
            string thing = Console.ReadLine();

            Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
            //string b = Console.ReadLine();
            string desription = Console.ReadLine();

            //string c = "of Doom";
            //remove "of" to repair bug of displaying
            string doom = "Doom";

            //string d = "3000";
            string threeThousands = "3000";
            
            /*Answer this question: 
             * Aside from comments, what else could you do to make this code more understandable?
             * 
             *"a" renamed to "thing"
             *"b" renamed to "description"
             *"c" renamed to "doom"
             *"d" renamed to "threeThousands"
             */


            Console.WriteLine($"The {desription} {thing} of {doom} {threeThousands} !");


            /*I'm Compleet "The Thing Namer 3000" Challenge!
              +100xp recived!!!
             */
        }
    }
}
