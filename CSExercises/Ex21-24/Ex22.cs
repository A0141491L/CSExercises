
using System;

namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            int  C;
            Console.Write("EnterA:");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("EnterB:");
            int B = Convert.ToInt32(Console.ReadLine());
            int HCF;
            
            while(A!=B)
            {
                if (A > B)
                { C = A - B; A = C; }
                else
                { C = B - A; B = C; }
                

            }
            HCF = A;

            Console.WriteLine("HCF={0}", HCF);

            Console.WriteLine("LCM={0}", (A * B) / HCF);



        }
    }
}
