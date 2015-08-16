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
            Console.WriteLine("{0,0:000}",c);
            Console.ReadLine();
        }
    }
}
