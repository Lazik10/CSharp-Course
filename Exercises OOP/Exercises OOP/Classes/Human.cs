using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_OOP.Classes
{
    internal class Human
    {
        private string Name;
        private int Age;
        private Human? FriendName;
        protected int Rest;
        public Dog? Dog;
        private Human Mother;
        private Human Father;

        public Human()
        {
            Name = "John Doe";
            Age = 0;
            FriendName = null;
            Rest = 0;
            Dog = null;
        }

        public Human(string name)
        {
            Name = name;
            Age = 0;
            FriendName = null;
            Rest = 0;
            Dog = null;
        }

        public Human(string name, int age)
        {
            Age = age;
            Name = name;
        }

        public void SetName(string name) { Name = name; }
        public string GetName() { return Name; }
        public void SetAge(int age) { Age = age; }
        public int GetAge() { return Age; }
        public void SetFriend(Human friend) { FriendName = friend; }
        public Human GetFriend() { return FriendName; }

        public override string ToString() { return String.Format("{0} ({1})", Name, Age); }

        public void Sleep(int numberOfHours)
        {
            Rest -= numberOfHours;
            if (Rest < 0)
                Rest = 0;
            Console.WriteLine($"I slept for {numberOfHours}");
        }

        public void Run(int numberOfKilometres)
        {
            if (numberOfKilometres + Rest > 20)
                Console.WriteLine("Can't run any longer, I am too tired!");
            else
            {
                Console.WriteLine($"Ran for {numberOfKilometres}");
                Rest += numberOfKilometres;
            }
        }
        public void AdoptDog(Dog dog)
        {
            Dog = dog;
        }

        public void SetParents(Human father, Human mother)
        {
            this.Father = father;
            this.Mother = mother;
        }

        public Human GetFather()
        {
            return this.Father;
        }

        public Human GetMother()
        {
            return this.Mother;
        }

        public void PrintParents()
        {
            // Father's side
            if (Father != null)
            {
                Console.WriteLine(Father);
                Father.PrintParents();
                Console.WriteLine(Mother);
                Mother.PrintParents();
            }
            // Mother's side
            else if (Mother != null)
            {
                Console.WriteLine(Father);
                Mother.PrintParents();
                Console.WriteLine(Mother);
                Mother.PrintParents();
            }
        }

        public void WakeUp()
        {
            Console.WriteLine("Jsem vzhuru");
        }

        public virtual void WakeUpWithParams(object? sender, AlarmParametres e)
        {
            if (sender is null || e is null)
                return;

            Console.WriteLine("Člověk vstává");
        }
    }
}
