
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;








namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            string[] StudentNames = new string []{"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L"};
            int [,] Marks=new int [,] {{56,84,68,29},{94,73,31,89},{41,63,36,90},{99,9,18,17},{62,3,65,75},
            {40,96,53,23},{81,15,27,30},{21,70,100,22},{88,50,13,12},{48,54,52,78},{64,71,67,25},{16,93,46,72}};
            int i=0,j=0;
            string[] Subject = new string[] { "Chinese", "English", "Science", "Music" };
 
            
            
            for (i=0;i<12;i++)
            {
                {Console.WriteLine("{0}",StudentNames[i]);
                

                for ( j=0;j<4;j++)
                { Console.Write("\t{0}",Marks[i,j]);
                    
                   
                };
                   Console .WriteLine();
                  
            }
            Console.WriteLine();
            
            
            }
            
            //total marks for each students
          
            //class aveage ,deviation of each subject
          
            for (j = 0; j < 4; j++)
             {
                 double Chapingfang=0;
                 int SubjectSum = 0; 
                double M = 0; int N;
                double A;
                 for (i = 0; i < 12; i++)
                 {
                     SubjectSum = SubjectSum + Marks[i, j];
                      M = Convert.ToDouble(SubjectSum / 12);
                      A=(Marks[i,j]-M)*(Marks[i,j]-M);
                     Chapingfang=Chapingfang+ A;
                    
                   
                     
                 }
                  

                    N = StudentNames.Length;
                    Console.WriteLine("The standard Deviation  of the {1} is {0}", Math.Sqrt(Chapingfang/N)  , Subject[j]);
                 



                 
            }
            //average of each student's total mark
            int  MarksSum = 0;
            for(i=0;i<12;i++) 

          {
             
              for (j = 0; j < 4; j++)
              {
                  MarksSum = MarksSum + Marks[i, j];

                 
              }
              
          }
            Console.WriteLine("The average of total marks of class is  {0} ",  Convert.ToDouble(MarksSum/(i*j)));
                     
          
        
        
        }
            









        }
    }




