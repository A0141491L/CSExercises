
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
           
         string [] NameandMark= new string []{"John 63","Venkat 29","Mary 75","Victor 82","Betty 55"};
         int[] Mark = new int[] { 63,29,75,82,55};

         string temp ="";
         for (int i = 0; i <=5; i++)

               {
                   for (int j = i + 1; j < 5; j++)

                     {
                         char name1 = Convert.ToChar(NameandMark[i]);
                         char name2 = Convert.ToChar(NameandMark[j]);
                         if (name1 < name2)

                         {
                             temp = NameandMark[i];
                             NameandMark[i] = NameandMark[j];
                             NameandMark[j] = temp;
                            }
                    
                       }

                   Console.Write(NameandMark);
                   
                  }

            //second question second question  second question   second question second question second question second question
             
            string [,] MarkandName=new string [,]{  {"John","63"}, { "Venkat","29"},{" Mary","75"},{"Victor","82" },{"Betty","55"}};
                 


                 for (int i = 0; i <=5; i++)

               {
                   for (int j = i + 1; j < 5; j++)

                    {   
                       int mark1=Convert.ToInt32(MarkandName[i,j]);
                       int mark2=Convert.ToInt32(MarkandName[i+1,j]);

                       if (mark1 < mark2)


                         {
                             temp = MarkandName[i,j];
                             MarkandName[i , j] = MarkandName[i + 1, j];
                             MarkandName[i + 1, j] = temp;
                       
                          }

                      }

                   Console.WriteLine(MarkandName);
                   }

        }
    }
}
