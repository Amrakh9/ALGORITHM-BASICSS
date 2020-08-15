using System;

namespace P019_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            double capital = 10000;
            int year=5;
            double interestRate=0.1;
            Console.WriteLine("Evvelki gelir:"+capital);
            for(int i=1;i<=year;i++)
            {
                capital=capital*(1+interestRate);
                Console.WriteLine(i+". yil sonunda toplanan anapara: {0:N2}", capital);
               
            }
        }
    }
}
