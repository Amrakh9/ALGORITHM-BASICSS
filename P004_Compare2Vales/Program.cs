using System;

namespace P004_Compare2Vales
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Birinci Yol*/
            Console.WriteLine("Birinci Eded: ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ikinci Eded: ");
            int b=Convert.ToInt32(Console.ReadLine());

            if(a>b)
            {
                Console.WriteLine("{0} ededi {1} ededinden boyukdur",a,b);
            }
            else 
            {
                if(b>a)
                {
                    Console.WriteLine("{0} ededi {1} ededinden boyukdur",b,a);
                }
                else
                {
                    Console.WriteLine("{0} ededi {1} ededine beraberdir",b,a);
                }
            }
        }
    }
}
