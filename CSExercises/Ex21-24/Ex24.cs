using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {



            Console.WriteLine("Please enter an integer:");
            int N = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            double G = random.Next(1, N);


            if (G * G == N)
            {
                Console.WriteLine("{0} is the square  root of {1}", G, N);
            }
            else
            {

                while (N - 0.00001 >= G * G || G * G >= N + 0.00001)
                {
                    G = (G + N / G) / 2;
                }
                Console.WriteLine("The nearest result is {0:0.00000}.", G);

            }





















        }






    }
}

