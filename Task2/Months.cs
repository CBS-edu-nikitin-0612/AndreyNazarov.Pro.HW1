using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    internal class Months : IEnumerable<Month>
    {
        private Month[] _months;

        public Months()
        {
            _months = new Month[]
            {
                new Month(1,31, "Январь"),
                new Month(2,28, "Февраль"),
                new Month(3,31, "Март"),
                new Month(4,30, "Апрель"),
                new Month(5,31, "Май"),
                new Month(6,30, "Июнь"),
                new Month(7,31, "Июль"),
                new Month(8,31, "Август"),
                new Month(9,30, "Сентябрь"),
                new Month(10,31, "Октябрь"),
                new Month(11,30, "Ноябрь"),
                new Month(12,31, "Декабрь"),
            };
        }
        public Month this[int number]
        {
            get
            {
                return _months.Single(m => m.Number == number);
            }
        }

        public IEnumerable<Month> GetMonths(int countDays)
        {
            foreach (var month in _months)
            {
                if (month.CountDays == countDays)
                    yield return month;
            }
            yield break;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _months.GetEnumerator();
        }

        IEnumerator<Month> IEnumerable<Month>.GetEnumerator()
        {
            foreach (var month in _months)
            {
                yield return month;
            }
        }
    }
}
