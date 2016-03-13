using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Problem_10.Inside_the_Building
{
    class InsideTheBuilding
    {
        static void Main(string[] args)
        {
            double size = double.Parse(Console.ReadLine());
            double[] coordinates= new double[10];

            for (int i = 0; i < 10; i++)
            {
                double coordinate = double.Parse(Console.ReadLine());
                coordinates[i] = coordinate;
            }

            for (int i = 0; i < coordinates.Length; i=i+2)
            {
                if (((coordinates[i] >= 0 && coordinates[i] <= 3 * size) && (coordinates[i + 1] >= 0 && coordinates[i + 1] <= size)) || (((coordinates[i] >= size) && (coordinates[i] <= 2 * size) && (coordinates[i + 1] >= size && coordinates[i+1] <= 4 * size))))
                {
                    Console.WriteLine("inside");
                }
                else
                {
                    Console.WriteLine("outside");
                }
            }
            
        }
    }
}


//=====================================================================================================

//using System;

//class InsideTheBuilding
//{
//    static void Main()
//    {
//        int size = int.Parse(Console.ReadLine());
//        int x1 = int.Parse(Console.ReadLine());
//        int y1 = int.Parse(Console.ReadLine());
//        int x2 = int.Parse(Console.ReadLine());
//        int y2 = int.Parse(Console.ReadLine());
//        int x3 = int.Parse(Console.ReadLine());
//        int y3 = int.Parse(Console.ReadLine());
//        int x4 = int.Parse(Console.ReadLine());
//        int y4 = int.Parse(Console.ReadLine());
//        int x5 = int.Parse(Console.ReadLine());
//        int y5 = int.Parse(Console.ReadLine());

//        Console.WriteLine(IsPointInTheBuilding(x1, y1, size));
//        Console.WriteLine(IsPointInTheBuilding(x2, y2, size));
//        Console.WriteLine(IsPointInTheBuilding(x3, y3, size));
//        Console.WriteLine(IsPointInTheBuilding(x4, y4, size));
//        Console.WriteLine(IsPointInTheBuilding(x5, y5, size));
//    }

//    private static string IsPointInTheBuilding(int x, int y, int size)
//    {
//        bool insideDown =
//            (x >= 0) && (x <= 3 * size) && (y >= 0) && (y <= size);
//        bool insideUp =
//            (x >= size) && (x <= 2 * size) && (y >= size) && (y <= 4 * size);
//        bool inside = insideDown | insideUp;
//        string result = inside ? "inside" : "outside";
//        return result;
//    }
//}
