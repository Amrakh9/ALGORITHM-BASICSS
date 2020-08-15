using System;

namespace P009_BestGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] grades=new int[3];
            grades[0]=65;
            grades[1]=75;
            grades[2]=100;
            int max=0;

            for(int i=0;i<3;i++)
            {
                if(grades[i]>max)
                {
                    max=grades[i];
                }
                
            }
            Console.WriteLine(max);
        }
    }
}