
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a phase:");
            string phase = Console.ReadLine().ToLower();

            string[] vowel = new string[] { "a", "e", "i", "o", "u" };
            int k = 0;

            for (int i = 0; i < phase.Length; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (phase[i] == vowel[j][0]) //phase.substring(i,1)==vowel[i,j]
                    {
                        k = k + 1;
                        break;
                    }
                }

            }

            Console.WriteLine("Total  number of vowels  is {0}", k);





            int[] counter = new int[] { 0, 0, 0, 0, 0 };
            for (int i = 0; i < phase.Length; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (phase[i] == vowel[j][0])
                    {
                        //phase.substring(i,1)==vowel[j]
                        counter[j] = counter[j] + 1;
                    }
                }
            }

            for (int j=0; j<counter.Length;j++)
            {
                Console.WriteLine("The alphabet is {0} and it occured {1} times", vowel[j], counter[j]);
            }
        }
    }
}















