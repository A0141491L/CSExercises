using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex03
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input an number:");
            string a = (Console.ReadLine());
            double a1 = Convert.ToDouble(a);
            double b = a1 * a1;
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
