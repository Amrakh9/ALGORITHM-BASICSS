using System;

namespace P017_ChooseBetween1_100Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
        do{
            Console.WriteLine("Please Enter Number: ");
            n = Convert.ToInt32(Console.ReadLine());
            if(n < 1)
            {
                Console.WriteLine("Entered number is less than 1 :(");
            }
            else if(n > 100)
            {
                Console.WriteLine("Entered number is higher than 100 :(");
            }
            else 
            {
                Console.WriteLine("Congratulations you choosed between 1 & 100 :)");
            }
              
        }
            while(n < 1 || n > 100);

        }
    }
}
