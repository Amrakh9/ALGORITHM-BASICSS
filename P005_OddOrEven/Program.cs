using System;

namespace P005_OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Numer: ");
            int number=Convert.ToInt32(Console.ReadLine());
            string result;
            if(number%2==0)    result ="Even";
            else    result="Odd"; 
            Console.WriteLine("number is :"+result);
        }
    }
}
