using System;

namespace P018_theSmallestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] {8, 7, 9, 17, 3, -5, -1, 6, 20, 13};
            int min=0;

            for(int i=0;i<10;i++)
            {
                if(numbers[i]<min)
                {
                    min=numbers[i];
                }
                
            }
            Console.WriteLine("Smallet Number among given numbers: "+min);
        }
    }
}
