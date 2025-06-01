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
    }
}
