using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            int[] List = new int[] { 86, 35, 41, 49, 89, 51, 11, 71, 50, 75, 25, 58, 40, 14, 44, 3, 63, 81, 93, 79 };
            int Temp = 0;


            {
                Console.WriteLine("The given list is: ");
                for (int i = 0; i < List.Length; i++)
                {

                    Console.Write("{0}\t", List[i]);
                }
            }

            for (int i = 0; i < List.Length - 1; i++)
            {

                for (int j = i + 1; j < List.Length ; j++)
                {
                    if (List[i] < List[j])
                    {
                        Temp = List[i];
                        List[i] = List[j];
                        List[j] = Temp;
                    }
                }
            }
            
            {
                Console.WriteLine("The descending list is: ");
                for (int i= 0; i < List.Length ; i++)
                {
                 
                    Console.Write( "{0}\t",List[i]);
                }
            }
            
            
        }
    }
}
