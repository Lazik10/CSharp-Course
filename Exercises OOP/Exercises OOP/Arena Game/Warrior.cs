using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_OOP.Arena_Game
{
    internal class Warrior
    {
        /// <summary>
        /// Name of the warrior
        /// </summary>
        protected string _name;
        /// <summary>
        /// Max HP
        /// </summary>
        protected int _maxHP;
        /// <summary>
        /// Current HP
        /// </summary>
        protected int _currentHP;
        /// <summary>
        /// Attack HP value
        /// </summary>
        protected int _attack;
        /// <summary>
        /// Defense HP value
        /// </summary>
        internal int _defense;
        /// <summary>
        /// Warrior's Dice
        /// </summary>
        internal Dice _dice;
        internal string _message;

        public Warrior(string name, Dice dice)
        {
            _name = name;
            _dice = new Dice();
            _maxHP = 100;
            _currentHP = _maxHP;
            _attack = 20;
            _defense = 20;
            _dice = dice;
        }

        public Warrior(string name, int maxHP, int attack, int defense, Dice dice)
        {
            _name = name;
            _maxHP = maxHP;
            _currentHP = maxHP;
            _attack = attack;
            _defense = defense;
            _dice = dice;
        }

        public override string ToString()
        {
            return _name;
        }

        public bool isAlive()
        {
            return _currentHP > 0;
        }

        /// <summary>
        /// Visual representation of warrior's health in console
        /// </summary>
        /// <param name="side">Defines if we want to align HP to the left (true) or right (false)</param>
        /// <returns>String representating warrior's life</returns>
        protected string GraphicResource(bool side, int currentResource, int maxResource)
        {
            string resource = "";
            string hpCurrent = "";
            int maxGraphicResource = 20;
            double currentGraphicResource = Math.Round(((double)currentResource / maxResource) * maxGraphicResource);

            if (isAlive() && _currentHP == 0)
                currentGraphicResource = 1;

            for (int i = 0; i < currentGraphicResource; i++)
                hpCurrent += "█";

            if (side)
                resource += hpCurrent.PadRight(maxGraphicResource);
            else
                resource += hpCurrent.PadLeft(maxGraphicResource);

            //resource += "]";

            return resource;
        }

        public string ShowLife(bool side)
        {
            return GraphicResource(side, _currentHP, _maxHP);
        }

        public virtual void Attack(Warrior enemy)
        {
            int attack = _attack + _dice.Throw();
            _message = string.Format("{0} attacks for {1} HP", this, attack);
            enemy.Defend(attack);
        }

        public void Defend(int dmg)
        {
            int defence = _defense + _dice.Throw();
            if (dmg - defence < 0)
                dmg = 0;
            else
                dmg -= defence;

            _message = string.Format("{0}'s defence is {1} so he suffered dmg for {2}", this, defence, dmg);
            ModifyHP(-dmg);
        }

        public void ModifyHP(int hp)
        {
            _currentHP += hp;

            if (_currentHP < 0)
                _currentHP = 0;
        }

        internal string Message()
        {
            return _message;
        }

        public virtual void HealFull()
        {
            _currentHP = 100;
        }

        public virtual string GetClass()
        {
            return "warrior";
        }
    }
}
