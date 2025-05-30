namespace HelloWorld
{
    internal class ContactWithWorld
    {
        static void Main(string[] args)
        {
            var msg = "Hello, World!";
            HeroSays(msg);
            HeroSays("Talking something ccesides \"Hello, World!\" ");
        }

        public static void HeroSays(string message)
        {
            Console.WriteLine($"Hero says: {message}");
        }
    }
}
