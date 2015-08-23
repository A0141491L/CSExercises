using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





using System.Data.SqlClient;

namespace CSExercises
{
    public class Ex40
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("The following numbers are the  square roots of numbers (1~25):");
            
            for(int i=1;i<25;i++)
            {
              double sqrt=SQT(i);
              Console.WriteLine( "{0:0.000}",sqrt   );
            
            
            }
   
        }

        public static double SQT(int y)
        {
           
            Random random = new Random();
            double G = random.Next(1, y+1);


            if (G * G == y)
            {
                return G;
            }
            else
            {

                while (y- 0.00001 >= G * G || G * G >= y+ 0.00001)
                {
                    G = (G + y / G) / 2;
                }
                return G;

            }


        }
    }
}
