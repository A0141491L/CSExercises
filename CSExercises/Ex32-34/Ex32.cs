

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;







namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            int i = 0;
            int SaleSum = 0;
            
            int[] Month = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            int[] Sales = new int[] { 1000, 1250, 1250, 1250, 1110, 1111, 1111, 1111, 1111, 1111, 1111, 10000 };
            for (i = 0; i < 12; i++)
            {
                Console.WriteLine("Enter sales for month{0}:{1}", Month[i], Sales[i]);
            }
            //minimum
            int K = Sales[0];

            for (i = 1; i < 12; i++)
            {
                if (K > Sales[i])
                    K = Sales[i];


            }
            Console.WriteLine("The minimum number is {0}", K);
            //Maxium
            for (i = 1; i < 12; i++)
            {
                if (K < Sales[i])
                { K = Sales[i]; }


            }
            Console.WriteLine("The maximum number is {0}", K);

            //Average
            SaleSum = 0;
            for (i = 0; i < 12; i++)
            {
                SaleSum = SaleSum + Sales[i];
            }

            Console.WriteLine(" The sale average is {0}", Convert.ToDouble(SaleSum) / Sales.Length);

        }
    }
}
