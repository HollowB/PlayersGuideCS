namespace HelloWorld
{
    internal class ContactWithWorld
    {
        static void Main(string[] args)
        {
            var msg = "Hello, World!";
            HeroSays(msg);
        }

        public static void HeroSays(string message)
        {
            Console.WriteLine($"Hero says: {message}");
        }
    }
}
