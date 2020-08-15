using System;

namespace P010_GradeStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] grades=new string[10] {"A","B","C","F","B","C","F","A","B","C"};
            int[] statics=new int[3]; // 0: A alan ; 1: B alan ;.........
            for(int i=0;i<15;i++)
            {
                switch(grades[i])
                {
                    case "A":
                    statics[0]++;break;
                    case "B":
                    statics[1]++;break;
                    case "C":
                    statics[2]++;break;
                    default:
                    statics[3]++;break;

                }
                
                Console.WriteLine("Statics of students: ");
                for (i = 0; i < 5; i++)
                {
                    Console.WriteLine(statics[i]);
                }
            }
        }
    }
}
