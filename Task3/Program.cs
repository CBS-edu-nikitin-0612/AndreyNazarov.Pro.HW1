using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            FamilyMember tempMember = new FamilyMember("Вова1", 1900);
            FamilyTree familyTree = new FamilyTree(tempMember);
            tempMember = familyTree.AddChild("Вова2", 1910);
            familyTree.AddChild("Вова3", 1920, false);
            familyTree.AddChild("Вова4", 1920, false);
            familyTree.AddChild("Вова5", 1940);
            familyTree.AddChild("Вова6", 1950);
            familyTree.AddChild("Вова7", 1960);

            Console.WriteLine("Наследники Вовы 2го");
            foreach (var member in tempMember.GetChilds())
            {
                Console.WriteLine(member);
            }

            Console.WriteLine("\nВсе дерево");
            foreach (var member in familyTree)
            {
                Console.WriteLine(member);
            }

            Console.WriteLine("\nЧлены с годом рождения 1940");
            foreach (var member in familyTree.GetMembers(1940))
            {
                Console.WriteLine(member);
            }
        }
    }
}
