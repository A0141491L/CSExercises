
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex44
    {
        public static void Main(string[] args)
           {
               Console.WriteLine("Please enter a string s:");
               string s=Console.ReadLine();
               Console.WriteLine("Please choose a chart from string s:");
               char c1 = Convert.ToChar(Console.ReadLine());
               Console.WriteLine("Please choose a chart from string s again :");
               char c2 = Convert.ToChar(Console.ReadLine());
               //Console.WriteLine("The occurrences of {0} and the new string afte {1} is took place by {2} are {3} respectively.",c1,c1,c2,Substitute(s,c1,c2));
               
             }
    

//        public static string Substitute(string s, char c1, char c2)
//        {
//            int i = 0;
//            for ( i = 0; i <= s.Length; i++)
//              {
//                  char single = Convert.ToChar(s.Substring(i, 1));

//                  if (c1.Equals (single))
                      
//                       single=c2;
//                      i++;
                    
//               }
//            Console.Write(i);
//            string[] news = new string[s.Length] ;

           


//            }

            

//            for (int j = 0; j <= s.Length; j++)
//            {
//                if (news[j].Equals(c1))
//                  {
//                      s[j] = 'c2';   ////how to 
//                    }
                 
//                 }

//                return null;
        }
    }
   


