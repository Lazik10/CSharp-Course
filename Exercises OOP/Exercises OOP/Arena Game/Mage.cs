using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_OOP.Arena_Game
{
    internal class Mage : Warrior
    {
        private int _mana;
        private int _maxMana;
        private int _magicAttack;

        public Mage(string name, Dice dice) : base(name, dice)
        {
            _attack = 19;
            _defense = 18;
            _magicAttack = 34;
            _maxMana = 100;
            _mana = _maxMana;
            _maxHP = 100;
            _currentHP = _maxHP;
        }
        public Mage(string name, int hp, int attack, int defense, Dice dice, int mana, int magicAttack) : base(name, hp, attack, defense, dice)
        {
            _mana = mana;
            _maxMana = mana;
            _magicAttack = magicAttack;
        }

        public override void Attack(Warrior enemy)
        {
            int attack = 0;
            if (_mana >= _maxMana)
            {
                attack = _magicAttack + _dice.Throw();
                _mana = 0;
                _message = string.Format("{0} used magic attack for {1} HP", this, attack);
                enemy.Defend(attack);
            }
            else
            {
                base.Attack(enemy);
                _mana += 10;
            }
        }

        public string ShowMana(bool side)
        {
            return GraphicResource(side, _mana, _maxMana);
        }

        public override void HealFull()
        {
            base.HealFull();
            _mana = _maxMana;
        }

        public override string GetClass()
        {
            return "mage";
        }
    }
}
