using System;

namespace P015
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c,d,e,a1,b1,c1,d1,e1;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            e = Convert.ToInt32(Console.ReadLine());
            a1 = Convert.ToInt32(Console.ReadLine());
            b1 = Convert.ToInt32(Console.ReadLine());
            c1 = Convert.ToInt32(Console.ReadLine());
            d1 = Convert.ToInt32(Console.ReadLine());
            e1 = Convert.ToInt32(Console.ReadLine());
            double avarage=(a+a1+b+b1+c+c1+d+d1+e+e1)/10;
            Console.WriteLine("Num Avarage: "+avarage);

        }
    }
}
