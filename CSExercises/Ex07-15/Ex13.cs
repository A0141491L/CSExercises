using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex13
    {
        public static void Main(string[] args)
        {
            Console.Write("Input the distance of traveled:$ ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = 2.40 + x * 0.40;
            double tmp = Math.Round(y, 1);
            if (tmp > y)
            {
                Console.WriteLine("Rounded upwards: {0:0.00}", tmp);
            }
            else
            {
                Console.WriteLine("Rounded upwards: {0:0.00}", tmp+0.1);
            }

            Console.ReadLine();
        }
    }
}
