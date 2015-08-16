using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex02
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input a number:");
            String a=Console.ReadLine();
            int a1=Convert.ToInt32(a);
            int b = a1 * a1;
            Console.WriteLine(b);
            Console.ReadLine();

        }
    }
}
