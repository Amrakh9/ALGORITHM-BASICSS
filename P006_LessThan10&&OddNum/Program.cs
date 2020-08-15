using System;

namespace P006_LessThan10__OddNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir eded daxil edin: ");
            int a=Convert.ToInt32(Console.ReadLine());

            if(a<10 && a%2==0)
            {
                Console.WriteLine("Daxil edilen reqem 10'dan kicikdir ve tekdir");
            }
            else
            {
                Console.WriteLine("Daxil edilen reqem 10'dan boyukdur ve cutdur");  
            }
        } 
    }
}
