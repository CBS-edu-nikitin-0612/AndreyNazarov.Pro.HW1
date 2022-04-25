using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary dictionary = new Dictionary();

            dictionary.Add("Apple", "Яблоко", "Яблуко");
            dictionary.Add("Pen", "Ручка", "Ручка");
            dictionary.Add("Sun", "Солнце", "Сонце");
            dictionary.Add("Moon", "Луна", "Місяць");
            dictionary.Add("Table", "Стол", "Стіл");
            Console.WriteLine("UA - Сонце ,RUS - " + dictionary.GetRus("Сонце"));
            Console.WriteLine("UA - Сонце ,ENG - " + dictionary.GetEng("Сонце"));
        }
    }
}
