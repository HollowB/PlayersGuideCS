using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
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

            //I'm comleted "The Triangle Farmer" challenge!
            //+100xp recived!!!
        }
    }
}
