using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace CSExercises
{
    public class Ex42
    {


        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string s1:");
            string s1 = Console.ReadLine();
            Console.WriteLine("Please enter a string s2:");
            string s2 = Console.ReadLine();
             
            if (s2.Length <= s1.Length)
              {
                     int    result = FindWord(s1, s2);

                      Console.WriteLine(result);
                }
            else
                {
                 
                Console.WriteLine("incorrect input.");

                  }

            
        }


        public static int FindWord(string s1, string s2)
        {

            

                bool k = true;

                int i = 0;

                for ( i = 0; i <= s1.Length - s2.Length; i++)
                {
                    if (s1.Substring(i, s2.Length).Equals(s2))

                        k = true;



                    else
                      {
                        k = false;
                        break;
                      
                    
                    
                    }
                }






                if (k)
                    return i;                //// is here something wrong?
                else

                    return -1;
            }

            

        } 
    }
  


