namespace Task2
{
    internal class Month
    {
        public Month(int number, int countDays, string name)
        {
            Number = number;
            CountDays = countDays;
            Name = name;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Number: {Number}, Days count: {CountDays}";
        }

        public int Number { get; private set; }
        public int CountDays { get; private set; }
        public string Name { get; private set; }
    }
}
