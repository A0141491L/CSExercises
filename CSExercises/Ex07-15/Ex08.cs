using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input a temperature in Centigrade scale:");
            String c = Console.ReadLine();
            int C= Convert.ToInt32(c);
            double F=1.8*C+32;
            Console.WriteLine("The consist Fahrenheit is {0}",F);
            Console.ReadLine();
        }
    }
}
