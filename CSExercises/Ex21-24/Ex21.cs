using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
           
            int keynumber = 88;
            int guessnumber = -1;
               
            
            while(guessnumber!=keynumber)
            {
                Console.WriteLine("Please input an integer:");
                guessnumber = Convert.ToInt32(Console.ReadLine());
                
                if(guessnumber==keynumber)
                { Console.WriteLine("Lucky you..."); }
                else
                { Console.WriteLine("Try again!");
                }



            }
            Console.ReadLine();
        }

    }
}
