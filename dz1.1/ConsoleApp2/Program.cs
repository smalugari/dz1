using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            var str1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            var str2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число: ");
            var str3 =  Convert.ToInt32(Console.ReadLine());

            double del = (double)str1 / str2;
            int umn = str1 * str2 * str3;
            Console.WriteLine("Рузультат деления первых двух чисел: " + del);
            Console.WriteLine("Рузультат умножения трёх чисел: " + umn);



            
        }
    }
}
