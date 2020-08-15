using System;

namespace P007_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eded daxil edin: ");
            int n=Convert.ToInt32(Console.ReadLine());
            int f=1;

            while(n>1)
            {
                f=f*n;
                n--;
            }
            Console.WriteLine("ededin fakt: "+f);
        }
    }
}
