using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex05
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input a number:");
            string a = (Console.ReadLine());
            double b = Convert.ToDouble(a);
            double c = Math.Sqrt(b);
            Console.WriteLine("The square root of {0} is {1:0.000}",b,c);
            Console.ReadLine();
        }
    } 
}
