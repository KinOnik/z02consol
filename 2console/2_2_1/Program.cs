using System;

namespace _2_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("\n\tВведите количество прошедших месяцев: ");
                int countPassMonth = Convert.ToInt32(Console.ReadLine());
                DateTime date = DateTime.Now;
                DateTime oldDate = date.AddMonths(-countPassMonth);
                int oldMonth= oldDate.Month;
                string oldMonthStr = "";
                switch (oldMonth)
                {
                    case 01:
                        oldMonthStr = "Январь";
                        break;
                    case 02:
                        oldMonthStr = "Февраль";
                        break;
                    case 03:
                        oldMonthStr = "Март";
                        break;
                    case 04:
                        oldMonthStr = "Апрель";
                        break;
                    case 05:
                        oldMonthStr = "Май";
                        break;
                    case 06:
                        oldMonthStr = "Июнь";
                        break;
                    case 07:
                        oldMonthStr = "Июль";
                        break;
                    case 08:
                        oldMonthStr = "Август";
                        break;
                    case 09:
                        oldMonthStr = "Сентябрь";
                        break;
                    case 10:
                        oldMonthStr = "Октябрь";
                        break;
                    case 11:
                        oldMonthStr = "Ноябрь";
                        break;
                    case 12:
                        oldMonthStr = "Декабрь";
                        break;
                }
                Console.Write($"\n\t{countPassMonth} месяца назад был: {oldMonthStr}\n\n");

            }
            catch (Exception)
            {
                Console.WriteLine("\n\n\t****Некорректное значение месяца! (необходимо число)****\n\n");
            }
        }
    }
}