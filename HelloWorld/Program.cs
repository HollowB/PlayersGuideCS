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
            TheVariableShop();
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

        static void TheVariableShop()
        {
            int intVar = int.MinValue;
            short shortVar = short.MinValue;
            long longVar = long.MinValue;
            byte byteVar = byte.MinValue;
            sbyte sbyteVar = sbyte.MinValue;

            uint uintVar = uint.MinValue;
            ushort ushortVar = ushort.MinValue;
            ulong ulongVar = ulong.MinValue;

            string stringVar = "string value";
            char charVar = 'c';

            double doubleVar = double.MinValue;
            float floatVar = float.MinValue;
            decimal decimalVar = decimal.MinValue;

            bool boolVar = true;

            Console.Clear();
            Console.WriteLine("-------------------");
            Console.WriteLine("The Variable Shop");
            Console.WriteLine("-------------------");

            Console.WriteLine($"{nameof(intVar)}: {intVar}");
            Console.WriteLine($"{nameof(shortVar)}: {shortVar}");
            Console.WriteLine($"{nameof(longVar)}: {longVar}");
            Console.WriteLine($"{nameof(byteVar)}: {byteVar}");
            Console.WriteLine($"{nameof(sbyteVar)}: {sbyteVar}");
            
            Console.WriteLine($"{nameof(uintVar)}: {uintVar}");
            Console.WriteLine($"{nameof(ushortVar)}: {ushortVar}");
            Console.WriteLine($"{nameof(ulongVar)}: {ulongVar}");

            Console.WriteLine($"{nameof(stringVar)}: {stringVar}");
            Console.WriteLine($"{nameof(charVar)}: {charVar}");

            Console.WriteLine($"{nameof(doubleVar)}: {doubleVar}");
            Console.WriteLine($"{nameof(floatVar)}: {floatVar}");
            Console.WriteLine($"{nameof(decimalVar)}: {decimalVar}");

            Console.WriteLine($"{nameof(boolVar)}: {boolVar}");

            /*I'm compleet "The Variable Shop" challenge
              +100xp recived!
             */

            Console.ReadKey();
            intVar = int.MaxValue;
            shortVar = short.MaxValue;
            longVar = long.MaxValue;
            byteVar = byte.MaxValue;
            sbyteVar = sbyte.MaxValue;

            uintVar = uint.MaxValue;
            ushortVar = ushort.MaxValue;
            ulongVar = ulong.MaxValue;

            stringVar = "UPDATED STRING";
            charVar = '@';

            doubleVar = double.MaxValue;
            floatVar = float.MaxValue;
            decimalVar = decimal.MaxValue;

            boolVar = false;

            Console.WriteLine("/n-------------------");
            Console.WriteLine("The Variable Shop Returns");
            Console.WriteLine("-------------------");
            Console.WriteLine("/nUpdatedValues:");

            Console.WriteLine($"{nameof(intVar)}: {intVar}");
            Console.WriteLine($"{nameof(shortVar)}: {shortVar}");
            Console.WriteLine($"{nameof(longVar)}: {longVar}");
            Console.WriteLine($"{nameof(byteVar)}: {byteVar}");
            Console.WriteLine($"{nameof(sbyteVar)}: {sbyteVar}");

            Console.WriteLine($"{nameof(uintVar)}: {uintVar}");
            Console.WriteLine($"{nameof(ushortVar)}: {ushortVar}");
            Console.WriteLine($"{nameof(ulongVar)}: {ulongVar}");

            Console.WriteLine($"{nameof(stringVar)}: {stringVar}");
            Console.WriteLine($"{nameof(charVar)}: {charVar}");

            Console.WriteLine($"{nameof(doubleVar)}: {doubleVar}");
            Console.WriteLine($"{nameof(floatVar)}: {floatVar}");
            Console.WriteLine($"{nameof(decimalVar)}: {decimalVar}");


            Console.WriteLine($"{nameof(boolVar)}: {boolVar}");

            //I'm comleted "The Varible Shop Returns" challenge!
            //+50xp recived!!!
        }
    }
}
