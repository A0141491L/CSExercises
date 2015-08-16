using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            Console.Write("Input the value of x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = 2 * x * x - 4 * x + 3;
            Console.WriteLine("y= {0}", y);
            Console.ReadLine();
        }
    }
}
