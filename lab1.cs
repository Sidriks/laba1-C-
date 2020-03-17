using System;
using System.Globalization;
namespace lab1 
{
    class Program
    {
               
        static void Main()
        {
            Console.WriteLine("Реализовать функцию вычисления частного двух вещественных чисел");

            Console.WriteLine("Введите значение А");
            string str = Console.ReadLine();
            int a = Convert.ToInt32(str);
            Console.WriteLine("Введите значение B");
            string str2 = Console.ReadLine();
            int b = Convert.ToInt32(str2);

        }

    }
}