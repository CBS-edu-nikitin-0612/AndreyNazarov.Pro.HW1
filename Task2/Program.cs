using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Все месяца");
            Months months = new();
            foreach (var month in months)
            {
                Console.WriteLine(month);
            }

            Console.WriteLine("\nВсе месяца 31 день");
            foreach (var month in months.GetMonths(31))
            {
                Console.WriteLine(month);
            }
            Console.WriteLine("\nФевраль");
            Console.WriteLine(months[2]);

            //Console.WriteLine(months[31]);
        }
    }
}
