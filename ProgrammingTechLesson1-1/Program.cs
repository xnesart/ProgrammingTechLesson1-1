using System;


namespace ProgrammingTechLesson1_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Вариант 4
            //по условию Х(0,001; 0,1; 1; 4), A = 1,5
            int choice = 0;
            double x = 0;
            double a = 0;
            double y = 0;
            Console.WriteLine(
                "Нажмите 1, чтобы вычислить Y по заданным значениям X, нажмите 2, чтобы ввести их вручную");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    choice = 0;
                    a = 1.5;
                    Console.WriteLine("Выберите значение X");
                    Console.WriteLine("Нажмите 1 - X = 0,001");
                    Console.WriteLine("Нажмите 2 - X = 0,1");
                    Console.WriteLine("Нажмите 3 - X = 1");
                    choice = int.Parse(Console.ReadLine());
                    if (choice == 1)
                    {
                        x = 0.001;
                        break;
                    }
                    if (choice == 2)
                    {
                        x = 0.1;
                        break;
                    }
                    if (choice == 3)
                    {
                        x = 1;
                        break;
                    }
                    else throw new ArgumentException("Вы ввели неверное значение, ошибка!");

                    break;
                case 2:
                    Console.WriteLine("Введите значение X");
                    x = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите значение A");
                    a = double.Parse(Console.ReadLine());

                    break;
            }

            y = (Math.Pow(a, x) * Math.Pow(x, a)) + (2 * Math.Pow(a, 2 * x) * Math.Pow(x, a)) -
                (2 * Math.Pow(a, x) * Math.Pow(x, 2 * a)) - (4 * Math.Pow(a, 2 * x) * Math.Pow(x, 2 * a)) /
                (Math.Log(a, 10) + Math.Log(x, 10));
            Console.WriteLine(y);
        }
    }
}