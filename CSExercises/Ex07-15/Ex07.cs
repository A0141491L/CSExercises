using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input your salary:");
            String a1= Console.ReadLine();
            int a =Convert.ToInt32 (a1);

            double b = 0.1 * a;
            double c = 0.03 * a;
            double d = b + c;
            Console.WriteLine("Your housing allowance is {0}:",b);
            Console.WriteLine("Your traffic allowance is {0}:",c);
            Console.WriteLine("Your total income is {0}:",d);
            Console.ReadLine();
        }
    }
}
