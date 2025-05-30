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

            foreach(string note in breadTakers)
            {
                Console.WriteLine(note);
            }
            Console.ReadKey();
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
    }
}
