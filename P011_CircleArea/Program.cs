using System;

namespace P011_CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
           int r;
           double pi=3.14;
           
           Console.WriteLine("Radiusu daxil edin:");
           r=Convert.ToInt32(Console.ReadLine());

           double s=pi*r*r;
           Console.WriteLine("Cevrenin sahesi: {0:N4}"+s); 

        }
    }
}
