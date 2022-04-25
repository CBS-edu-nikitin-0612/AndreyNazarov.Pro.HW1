using System.Collections;
using System.Collections.Generic;
using System;

namespace Task3
{
    internal class FamilyTree
    {
        private FamilyMember _curMember;

        public FamilyTree(FamilyMember familyMember)
        {
            _curMember = familyMember;
        }
        private FamilyTree() { }

        public FamilyMember AddChild(string name, int birthyear, bool moveForward = true)
        {
            FamilyMember tempMember = new FamilyMember(name, birthyear);
            _curMember.Childs.Add(tempMember);
            tempMember.Reletives.Add(_curMember);
            if (moveForward) _curMember = tempMember;
            return _curMember;
        }
        public FamilyMember AddRelative(string name, int birthyear, bool moveForward = true)
        {
            FamilyMember tempMember = new FamilyMember(name, birthyear);
            _curMember.Reletives.Add(tempMember);
            tempMember.Childs.Add(_curMember);
            if (moveForward) _curMember = tempMember;
            return _curMember;
        }
        public IEnumerable GetMembers(int Birthyear)
        {
            foreach (var member in this)
            {
                if (member.Birthyear == Birthyear)
                    yield return member;
            }
        }

        //Выглядит ужасно, можно это упроситить?
        public IEnumerator<FamilyMember> GetEnumerator()
        {
            //возвращаем тукущего родственника
            yield return _curMember;
            // перебираем наследников
            foreach (var child in _curMember.Childs)
            {
                // возвращаем наследника
                yield return child;
                //перебираем наследников наследника
                foreach (var childsChild in child.GetChilds())
                {
                    // возвращаем наследника
                    yield return childsChild;
                }
                //перебираем родитилей
                foreach (var relativesRelative in child.GetRelatives())
                {
                    //возвращаем ародителя
                    yield return relativesRelative;
                }
            }
            foreach (var relative in _curMember.Reletives)
            {
                yield return relative;
                foreach (var relativesRelative in relative.GetRelatives())
                {
                    yield return relativesRelative;
                }
                foreach (var childsChild in relative.GetChilds())
                {
                    yield return childsChild;
                }
            }
        }
    }
}
