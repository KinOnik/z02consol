using System;

namespace _2_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("\n\tВведите координаты точки:\n\t\tX: ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write("\t\tY: ");
                double y = Convert.ToDouble(Console.ReadLine());
                if (y < 12 && y > Math.Abs(x))
                {
                    Console.Write("\n\n\tТочка внутри фигуры!\n\n");
                }
                else if (y == 12 || y == Math.Abs(x))
                {
                    Console.Write("\n\n\tТочка на границе фигуры!\n\n");
                }
                else
                {
                    Console.Write("\n\n\tТочка вне фигуры!\n\n");
                }
            }
            catch (Exception)
            {
                Console.Write("\n\n\t****Ошибка, введено некорректное значение****\n\n");
            }
        }
    }
}
