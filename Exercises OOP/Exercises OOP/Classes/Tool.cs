using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_OOP.Classes
{
    internal abstract class Tool
    {
        public double Weight { get; set; }
        public string Name { get; set; }

        abstract public string Work();
    }

    internal class Chainsaw : Tool
    {
        public Chainsaw(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }
        public override string Work()
        {
            return "Řežu";
        }

        public override string ToString()
        {
            return Name;
        }
    }

    internal class Screwdriver : Tool
    {
        public Screwdriver(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }
        public override string Work()
        {
            return "Šroubuji";
        }
        public override string ToString()
        {
            return Name;
        }
    }

    internal class ElectricScrewdriver : Screwdriver
    {
        public int BatteryCapacity { get; private set; }


        public ElectricScrewdriver(string name, double weight, int batteryCapacity) : base(name, weight)
        {
            BatteryCapacity = batteryCapacity;
        }
    }

    internal class Hammer : Tool
    {
        public bool BothHanded { private set; get; }

        public Hammer(string name, double weight, bool bothHanded)
        {
            Name = name;
            Weight= weight;
            BothHanded = bothHanded;
        }
        public override string Work()
        {
            return "Zatloukám";
        }
        public override string ToString()
        {
            return Name;
        }
    }

    internal class Box /*: IEnumerable<Tool>*/
    {
        public double MaxWeight { get; init; }

        public double CurrentWeight { private set; get; }

        private List<Tool> toolList = new List<Tool>();

        /*
        public IEnumerable<Tool> Tools
        {
            get { return toolList.ToArray(); }
        }
        */

        public Box(double maxWeight)
        {
            MaxWeight = maxWeight;
        }

        public void AddTool(Tool tool)
        {
            if (tool.Weight + CurrentWeight > MaxWeight)
            {
                //Console.WriteLine("Can't put this tool inside the box, it would be too heavy!");
                return;
            }

            toolList.Add(tool);
            CurrentWeight += tool.Weight;
        }

        public void Remove(Tool tool)
        {
            toolList.Remove(tool);
            CurrentWeight -= tool.Weight;
        }

        public double AllBothHandedHammersWeight()
        {
            double weight = 0;
            foreach (var item in toolList)
            {
                if (item is Hammer)
                {
                    if ((item as Hammer).BothHanded == true)
                    {
                        weight += item.Weight;
                    }
                }
            }
            return weight;
        }

        public void ToolsWork()
        {
            foreach (var item in toolList)
            {
                Console.WriteLine(item.Work());
            }
        }

        public void Content()
        {
            if (toolList.Count == 0)
            {
                Console.WriteLine("Bedna je prázdná.");
                return;
            }

            Console.Write("V bedně je: ");
            Console.Write(string.Join(", ", toolList));
            Console.WriteLine();
        }
    }
}
