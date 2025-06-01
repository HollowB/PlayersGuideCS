namespace Math;

class Program
{
    static void Main(string[] args)
    {
        Math.TheTriangleFarmer();
        Console.ReadKey();

        int sistersCount, duckbearCount;
        sistersCount = Math.SistersAndDuckbear(out duckbearCount);

        Console.WriteLine($"Four Sisters got {sistersCount} chocolate eggs each");
        Console.WriteLine($"Duckbear got {duckbearCount} chockolate eggs");
    }
}
