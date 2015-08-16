using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input a integer number:");
            String a = Console.ReadLine();
            int a1 = Convert.ToInt32(a);
            double b = Math.Sqrt(a1);
            Console.WriteLine("The square root of {0} is {1}",a1,b);
            Console.ReadLine();

        }
    }
}
