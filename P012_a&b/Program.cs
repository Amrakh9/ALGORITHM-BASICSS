using System;

namespace P012_a_b
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            Console.WriteLine("Birinci edede Girin:");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ikinci edede Girin:");
            b=Convert.ToInt32(Console.ReadLine());

            if(a%b==0)
            {
                Console.WriteLine(a+" ededi "+b+" edeine tam bolunur.");
            }
            else 
            {
                Console.WriteLine(a+" ededi "+b+" edeine tam bolunmur.");
            }
        }
    }
}
