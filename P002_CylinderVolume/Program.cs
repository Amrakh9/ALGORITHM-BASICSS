using System;

namespace P002_CylinderVolume
{
    class Program
    {
        static void Main(string[] args)
        {
            int r;
            int h;
            double pi=3.14159; /* float,double,decimal*/

            Console.WriteLine("Silindirin radiusu: ");
            r=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Silindirin hundurluyu: ");
            h=Convert.ToInt32(Console.ReadLine());
            double v=pi*r*r*h;
            Console.WriteLine("Silindirin hecmi: "+v);
            Console.WriteLine("Silindirin hecmi: {0:N2}",v);

        }
    }
}
