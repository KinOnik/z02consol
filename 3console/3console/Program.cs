using System;

namespace _3console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool violationOfEquality = false;
            try
            {
                Console.Write("\n\tВведите нижнюю границу A: ");
                double Abuf = Convert.ToDouble(Console.ReadLine());
                Console.Write("\n\tВведите вехнюю границу B: ");
                double Bbuf = Convert.ToDouble(Console.ReadLine());
                int A = Convert.ToInt32(Math.Ceiling(Abuf));
                int B = Convert.ToInt32(Bbuf);
                if (Bbuf - B < 0)
                {
                    B -= 1;
                }

                if (A > B)
                {
                    violationOfEquality = true;
                    throw new Exception("");
                }
                Console.Write("\n\n\tfor:\n\t");
                for (int i = B; i >= A; i--)
                {
                    Console.Write($"{i * i * i} ");
                }

                int j = B;
                Console.Write("\n\n\twhile:\n\t");
                while (j >= A)
                {
                    Console.Write($"{j * j * j} ");
                    j--;
                }

                j = B;
                Console.Write("\n\n\tdo While:\n\t");
                do
                {
                    Console.Write($"{j * j * j} ");
                    j--;
                } while (j >= A);

            }
            catch (Exception) when (violationOfEquality)
            {
                Console.WriteLine("\n\n\t**** Нарушено равенство. Необходимо: A<=B ****\n\t** Либо Вы ввели одинаковые но НЕ целые числа **\n\n");
            }
            catch (Exception)
            {
                Console.WriteLine("\n\n\t**** У одной из переменных некорректное значение ****\n\n");
            }
        }
    }
}
