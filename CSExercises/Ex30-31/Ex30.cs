
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {



            for (int i = 5; i <= 10000; i++)
            {

                bool isprime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isprime = false;

                        break;
                    }


                }
                if (isprime)
                    Console.WriteLine(i);


            }

        }
    }
}
