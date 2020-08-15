using System;

namespace P008_SumOfNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0;
            int number=0 ;
            do
            {
                Console.WriteLine("Eded: ");
                number=Convert.ToInt32(Console.ReadLine());
                if(number!=-1)
                {
                    sum+=number;
                }
            }   
            while (number!=-1);
            {
                Console.WriteLine("Girilen saylarin cemi: "+sum);
            }
        }
    }
}
