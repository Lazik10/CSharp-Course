using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercises_OOP.Classes;

namespace Exercises_OOP
{
    internal class FamilyTree
    {
        private Human human;

        public FamilyTree(Human human)
        {
            this.human = human;
            PrintFamilyTree();
        }

        public void PrintFamilyTree()
        {
            Console.WriteLine("Rodokmen pro osobu " + human);
            Console.WriteLine(human);
            human.PrintParents();
        }
    }
}
