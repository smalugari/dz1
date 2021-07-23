using System;

namespace dz1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите цену молока: ");
            var milk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите цену шоколада: ");
            var choco = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите цену кофе: ");
            var coffee = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сумма покупки: " + (milk + choco + coffee));
        }
    }
}
