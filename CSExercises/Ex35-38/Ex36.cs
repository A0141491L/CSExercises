
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {   

            
            int k=0;
            Console.WriteLine("Please enter a string:");
            string words = Console.ReadLine();
            
            for (int i = 0; i < words.Length; i++)
            {



                if (words.Substring(0, 1).Equals(words[words.Length - i - 1]))
                
                                 k = 0;
                
                else
                    k = 1;
                

               
                }
            if (k == 0)
            {
                Console.WriteLine("  Not Palindrome. ");
            }
            else if (k == 1)
            {
                Console.WriteLine("Palindrome.");
            }

            //second question   second question    second question   second question    second question

            
            

            Console.WriteLine("Please enter a sentence:");
            string  sentence = Console.ReadLine().ToUpper();
            string [] cutsentence= new string [sentence.Length];

            for(int j=0;j<sentence.Length;j++)
            {
               if( sentence[j]<='A'&& sentence[j]>='Z' &&sentence[j]>='0'&&sentence[j]<='9')
                   cutsentence[j]=sentence.Substring(j,0);
            
            
            }



            
            for (int i = 0; i < cutsentence.Length; i++)
            {



                if (cutsentence[i].Equals(cutsentence[cutsentence.Length - i - 1]))

                    k = 0;

                else
                    k = 1;



            }
            if (k == 0)
            {
                Console.WriteLine("  Not Palindrome. ");
            }
            else if (k == 1)
            {
                Console.WriteLine("Palindrome.");
            }








































        }
      }
    }

