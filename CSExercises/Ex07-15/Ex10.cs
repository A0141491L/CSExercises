using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter the coordinates of two points: (X1,Y1),(X2,Y2)");
            double X1= Convert.ToDouble(Console.ReadLine());
            double Y1 = Convert.ToDouble(Console.ReadLine());
            double X2= Convert.ToDouble(Console.ReadLine());
            double Y2= Convert.ToDouble(Console.ReadLine());
            double Distance = Math.Sqrt((X2 - X1) * (X1 - X2) - (Y2 - Y1) * (Y2 - Y1));
            Console.WriteLine("The distance is {0}", Distance);
            Console.ReadLine();







            
        }
    }
}
