
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input your name: ");
            Console.WriteLine("Please input your gender (M or F):");
            Console.WriteLine("Please input your age: ");

            string name = Console.ReadLine();
            string gender = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());



            if (gender == "M")
            {
                if (age >= 40)
                    Console.WriteLine("GoodMorning Uncle" + name);
                else
                {
                    Console.WriteLine("GoodMorning Mr." + name);
                }
            }
            else if (gender == "F")
            {
                if (age >= 40)
                {
                    Console.WriteLine("GoodMorning Aunty" + name);
                }

                else
                {
                    Console.WriteLine("GoodMorning Ms." + name);
                }
            }
            else
            {
                Console.WriteLine("gender is incorrect");
            } 
        }
    }
}