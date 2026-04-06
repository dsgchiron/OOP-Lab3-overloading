using System;


namespace Sposib2
{
    class Program
    {
        static void Calculate(double x, double y, out double result)
        {
            if (x > 4 && y < 5)
            {
                result = Math.Pow(x, 2) - (x * y) - (2 * x * Math.Pow(y, 2));
            }
            else if (x < 4 && y < 5)
            {
                result = y + (2 * x) - (y * Math.Exp(x));
            }
            else
            {
                result = Math.Abs(Math.Log(x)) - Math.Log(Math.Abs(y));
            }
        }
        static void Calculate(float x, float y, out float result)
        {
            if (x > 4 && y < 5)
            {
                result = (float)(Math.Pow(x, 2) - (x * y) - (2 * x * Math.Pow(y, 2)));
            }
            else if (x < 4 && y < 5)
            {
                result = (float)(y + (2 * x) - (y * Math.Exp(x)));
            }
            else
            {
                result = (float)(Math.Abs(Math.Log(x)) - Math.Log(Math.Abs(y)));
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("\nВведіть дані для типу double:");
            Console.Write("Введіть x: ");
            double xDouble = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть y: ");
            double yDouble = Convert.ToDouble(Console.ReadLine());
            double resultDouble;
            Calculate(xDouble, yDouble, out resultDouble);
            Console.WriteLine($"Результат (double): {resultDouble}");
            Console.WriteLine("\nВведіть дані для типу float:");
            Console.Write("Введіть x: ");
            float xFloat = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введіть y: ");
            float yFloat = Convert.ToSingle(Console.ReadLine());
            float resultFloat;
            Calculate(xFloat, yFloat, out resultFloat);
            Console.WriteLine($"Результат (float): {resultFloat}");
           
            Console.ReadKey();
        }
    }
}
