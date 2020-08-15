using System;

namespace P013_ModulEded
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ededi daxil edin: ");
            int a=Convert.ToInt32(Console.ReadLine());
            
            if(a<0) Console.WriteLine(a*(-1));
            else Console.WriteLine(a);
        }
    }
}
