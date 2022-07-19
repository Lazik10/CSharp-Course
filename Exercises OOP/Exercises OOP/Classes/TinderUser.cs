using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_OOP.Classes
{
    internal class TinderUser
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public EyeColor EyeColor { get; private set; }
        public HairColor HairColor { get; private set; }

        public TinderUser(string name, string surname, DateTime dateOfBirth, EyeColor eyeColor, HairColor hairColor)
        {
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            EyeColor = eyeColor;
            HairColor = hairColor;
        }

        public override bool Equals(object? obj)
        {
            if (obj is TinderUser user && this == user)
                return true;
            return false;
        }

        public static bool operator ==(TinderUser a, TinderUser b) => a.Name == b.Name && a.Surname == b.Surname && a.DateOfBirth == b.DateOfBirth
                   && a.EyeColor == b.EyeColor && a.HairColor == b.HairColor;

        public static bool operator !=(TinderUser a, TinderUser b) => !(a == b);

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Surname, DateOfBirth, EyeColor, HairColor);
        }
    }
}
