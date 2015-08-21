
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex39
    {
        static void Main (string [] args)
        {
           Console.WriteLine("Please input a number:");
            double number=Convert.ToDouble (Console.ReadLine());
            double factorial=Factorial(number);
                

            Console.WriteLine("The factorial of {0} is {1} :",number,factorial);

           
        }

        static double Factorial(double number)
        {
            double M = 1;
            for (int i = 1; i <= number; i++)
            {
                M = M * i;
            }
            return M;
        }

    }
}
