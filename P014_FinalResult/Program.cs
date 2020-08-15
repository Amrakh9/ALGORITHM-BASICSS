using System;

namespace P014_FinalResult
{
    class Program
    {
        static void Main(string[] args)
{
    int midterm1, midterm2, final;
    double grade;
 
    Console.WriteLine("Birinci vize notunu giriniz: ");
    midterm1 = Convert.ToInt32(Console.ReadLine());
 
    Console.WriteLine("İkinci vize notunu giriniz: ");
    midterm2 = Convert.ToInt32(Console.ReadLine());
 
    Console.WriteLine("Final notunu giriniz: ");
    final = Convert.ToInt32(Console.ReadLine());
 
    grade = (midterm1 * 30/100) + (midterm2 * 0.3) + (final * 0.4);
    Console.WriteLine("Yılsonu not ortalaması: " + grade);
}
    }
}
