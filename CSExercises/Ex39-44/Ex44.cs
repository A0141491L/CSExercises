
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
               Console.WriteLine("Please choose a chart from string s as c1:");
               char c1 = Convert.ToChar(Console.ReadLine());
               Console.WriteLine("Please choose a chart as c2 :");
               char c2 = Convert.ToChar(Console.ReadLine());
               Console.WriteLine("The new string is {0}",Substitute(s,c1,c2));
               
             }
    

        public static string Substitute(string s, char c1, char c2)
        {
            
            char[] sarray=new char[s.Length] ;

            for ( int i = 0; i <s.Length; i++)
              
                  sarray[i] =  Convert.ToChar(s.Substring(i, 1));
            
            for (  int  j = 0; j < s.Length; j++)
            {if (c1==sarray[j])             //if (c1.Equals (sarray[j])
                      
                     sarray[j]=c2;
                        
                    
               }
             
            s=new string ( sarray);
             
              return s;


            }

            


               
        }
    }
   


