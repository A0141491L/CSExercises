
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex41
    {

       public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string s1:");
            string s1 = Console.ReadLine();
            Console.WriteLine("Please enter a string s2:");
            string s2 = Console.ReadLine();
            bool boolean = InString( s1, s2);
            Console.WriteLine("{0}", boolean);//console.writeline(boolean);
        
        
          }


        public static bool InString(string s1, string s2)
        {


            string[] s1array = new string[s1.Length];
            for (int i = 0; i <= s1.Length; i++)
            {
                s1array[i] = s1.Substring(i, 1);

            }


            string[] s2array = new string[s2.Length];
            for (int j = 0; j <= s2.Length; j++)
            {
                s1array[j] = s1.Substring(j, 1);
            }

            bool k = true;
            for (int j = 0; j < s2.Length; j++)
            {

                for (int i = 1; i <= s1.Length - s2.Length + i; i++)
                {
                    if (s1[j] == s2[i])                       //if (s1array[j] == s2array[i])
                        k = true;
                    else
                        k = false;
                    break;              //why do you add break?

                }

            }

            if (k)
                return true;
            else

                return false;
        }
    }
}
