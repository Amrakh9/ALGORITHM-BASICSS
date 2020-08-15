using System;

namespace P001_RectangleArea
{
    class Program
    {       /* Diktortgende alan */
        static void Main(string[] args)
        {
            int a,b;
            Console.WriteLine("Birinci edede Girin:");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ikinci edede Girin:");
            b=Convert.ToInt32(Console.ReadLine());
            int c=a*b;
            Console.WriteLine("Sahe: " + c);

        }
    }
}
