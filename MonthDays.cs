using System;

namespace cSharpDemo
{
    class MonthDays
    {
        static void Main(string[] args)
        {
            Console.Write("Enter month number :");
            int month = Int32.Parse(Console.ReadLine());
            int days;

            switch (month)
            {
                case 2:
                    days = 28;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    days = 30;
                    break;
                default:
                    days = 31;
                    break;
            }

    Console.WriteLine(days);
        }
    }
}
