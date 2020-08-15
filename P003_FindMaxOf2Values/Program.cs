using System;

namespace P003_FindMaxOf2Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.WriteLine("Birnici Eded: ");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ikinci eded: ");
            b=Convert.ToInt32(Console.ReadLine());

            if(a>b) Console.WriteLine(a);
            else Console.WriteLine(b);

        }
    }
}
