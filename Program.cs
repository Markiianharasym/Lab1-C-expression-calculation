using System;

namespace Lab1_C__expression_calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter X:");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Please, enter Y:");
            double y = double.Parse(Console.ReadLine());

            Console.Write("Please, enter Z:");
            double z = double.Parse(Console.ReadLine());

            double result;
            result = Math.Pow((x + 2), 3) + Math.Pow((y + x), 1.0 / 5.0) - Math.Log(Math.Abs(Math.Sin(x + y) / Math.Cos(x + z))) / Math.Log(3);

            Console.WriteLine("The value of the expression =" + result);
        }
    }
}
