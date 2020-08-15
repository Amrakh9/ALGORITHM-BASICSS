using System;

namespace P016__OddAnd4
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=50;i++)
            {
                if(i%2==1 || i%4==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
