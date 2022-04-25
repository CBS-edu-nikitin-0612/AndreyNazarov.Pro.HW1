using System;

namespace Task4
{
    internal class Element
    {
        public Element(string eng, string rus, string ua)
        {
            Eng = eng ?? throw new ArgumentNullException(nameof(eng));
            Rus = rus ?? throw new ArgumentNullException(nameof(rus));
            Ua = ua ?? throw new ArgumentNullException(nameof(ua));
        }

        public string Eng { get; private set; }
        public string Rus { get; private set; }
        public string Ua { get; private set; }
    }
}
