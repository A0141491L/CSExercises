



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input your mark:");
            int mark = Convert.ToInt32(Console.ReadLine());
            if (mark < 0 || mark > 100)
            { Console.WriteLine("Error."); }
            else if (mark >= 80 && mark <= 100)
            { Console.WriteLine("You scored {0} marks which is A grade.", mark); }
            else if (mark >= 60)
            { Console.WriteLine("You scored {0} marks which is B grade.", mark); }
            else if (mark >= 40)
            { Console.WriteLine("You scored {0} marks which is C grade.", mark); }

            else
            {
                Console.WriteLine("You scored {0} marks which is F grade.", mark);
            }
        }
    }
}