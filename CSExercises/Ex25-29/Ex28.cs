using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Please enter an integer:");
            int number = Convert.ToInt32(Console.ReadLine());
            bool K=true;


            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                { K = true;
                break;
                }


            }
            if (K ==true)
            
                Console.WriteLine("Prime");

            
            else
                Console.WriteLine("Not prime.");
             

        }
    }
}
