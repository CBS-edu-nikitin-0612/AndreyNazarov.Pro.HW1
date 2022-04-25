using System.Collections.Generic;
using System.Linq;

namespace Task4
{
    internal class Dictionary
    {
        private List<Element> dictionary = new List<Element>();
        public void Add(string eng, string rus, string ua)
        {
            dictionary.Add(new Element(eng, rus, ua));
        }

        public string GetRus(string ua)
        {
            return dictionary.Where(e => e.Ua == ua).Select(e => e.Rus).First();
        }
        public string GetEng(string ua)
        {
            return dictionary.Where(e => e.Ua == ua).Select(e => e.Eng).First();
        }
    }
}
