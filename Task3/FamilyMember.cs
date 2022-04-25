using System.Collections;
using System.Collections.Generic;
using System;

namespace Task3
{
    internal class FamilyMember
    {
        public FamilyMember(string name, int birthyear, FamilyMember reletive = null, FamilyMember child = null)
        {
            Name = name;
            Birthyear = birthyear;
            if (reletive != null)
                Reletives.Add(reletive);
            if (child != null)
                Childs.Add(child);
        }

        public string Name { get; private set; }
        public int Birthyear { get; private set; }
        public List<FamilyMember> Reletives { get; private set; } = new();
        public List<FamilyMember> Childs { get; private set; } = new();
        public IEnumerable<FamilyMember> GetChilds()
        {
            foreach (var child in Childs)
            {
                yield return child;
                foreach (var ChildsChild in child.GetChilds())
                {
                    yield return ChildsChild;
                }
            }
            yield break;
        }
        public IEnumerable<FamilyMember> GetRelatives()
        {
            foreach (var relative in Reletives)
            {
                yield return relative;
                foreach (var relativesRelative in relative.GetRelatives())
                {
                    yield return relativesRelative;
                }
            }
            yield break;
        }
        public override string ToString()
        {
            return $"Name: {Name} Birthyear: {Birthyear}";
        }
    }
}
