using System;


namespace ProgrammingTechLesson1_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Вариант 4
            //по условию Х(0,001; 0,1; 1; 4), A = 1,5
            double y = 0;
            double x = 0.1;
            double a = 1.5;
            
            y = (Math.Pow(a, x) * Math.Pow(x, a)) + (2 * Math.Pow(a, 2 * x) * Math.Pow(x, a)) -
                (2 * Math.Pow(a, x) * Math.Pow(x, 2 * a)) - (4 * Math.Pow(a, 2 * x) * Math.Pow(x, 2 * a)) /
                (Math.Log(a, 10) + Math.Log(x, 10));
            Console.WriteLine(y);


        }
    }
}