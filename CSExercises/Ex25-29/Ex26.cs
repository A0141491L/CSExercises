
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("NO"+'\t'+'\t'+"INVERSE"+'\t'+'\t'+"SQUARE"+'\t'+"ROOT"+'\t'+'\t'+"SQUARE"); 
            Console.WriteLine("==============================================================");
            for (int i = 0; i <= 10; i++)
              { 
                 double inverse=1/i;
                double squareroot=Math.Sqrt(i);
                double square=i*i;

                Console.WriteLine("{0:0.0}"+'\t'+'\t'+"{1:0.0###}"+'\t'+'\t'+"{2:0.0###}"+'\t'+'\t'+'\t'+"{3:0.0###}",i,inverse,squareroot,square) ;
            
               }
               



        }
    }
}
