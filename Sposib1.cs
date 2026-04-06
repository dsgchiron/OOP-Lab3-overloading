using System;


namespace Sposib1
{
    class Program
    {
        static double Calculate(double x, double y)
        {
            if (x > 4 && y < 5)
            {
                return Math.Pow(x, 2) - (x * y) - (2 * x * Math.Pow(y, 2));
            }
            else if (x < 4 && y < 5)
            {
                return y + (2 * x) - (y * Math.Exp(x));
            }
            else
            {
                return Math.Abs(Math.Log(x)) - Math.Log(Math.Abs(y));
            }
        }
        static float Calculate(float x, float y)
        {
            if (x > 4 && y < 5)
            {
                return (float)(Math.Pow(x, 2) - (x * y) - (2 * x * Math.Pow(y, 2)));
            }
            else if (x < 4 && y < 5)
            {
                return (float)(y + (2 * x) - (y * Math.Exp(x)));
            }
            else
            {
                return (float)(Math.Abs(Math.Log(x)) - Math.Log(Math.Abs(y)));
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("\nВведіть дані для типу double:");
            Console.Write("Введіть x: ");
            double xDouble = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть y: ");
            double yDouble = Convert.ToDouble(Console.ReadLine());
            double resultDouble = Calculate(xDouble, yDouble);
            Console.WriteLine($"Результат (double): {resultDouble}");
            Console.WriteLine("\nВведіть дані для типу float:");
            Console.Write("Введіть x: ");
            float xFloat = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введіть y: ");
            float yFloat = Convert.ToSingle(Console.ReadLine());
            float resultFloat = Calculate(xFloat, yFloat);
            Console.WriteLine($"Результат (float): {resultFloat}");
            Console.ReadKey();
        }
    }
}
