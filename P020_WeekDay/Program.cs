using System;

namespace P020_WeekDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayNumber;
            do
            {
                Console.WriteLine("Enter Number between 1 & 7: ");
                dayNumber = Convert.ToInt32(Console.ReadLine());
            switch (dayNumber)
            {
                case 1: Console.WriteLine("Monday");break;
                case 2: Console.WriteLine("Tuesday");break;
                case 3: Console.WriteLine("Wednesday");break;
                case 4: Console.WriteLine("Thursday");break;
                case 5: Console.WriteLine("Friday");break;
                case 6: Console.WriteLine("Saturday");break;
                case 7: Console.WriteLine("Sunday");break;
                default: Console.WriteLine("Fail enterance");break;
            }}
            while(dayNumber<1 || dayNumber>7);
        }
    }
}
