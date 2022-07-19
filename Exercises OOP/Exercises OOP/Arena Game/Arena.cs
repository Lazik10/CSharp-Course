using Exercises_OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_OOP.Arena_Game
{
    internal class Arena
    {
        private Warrior firstWarrior;
        private Warrior secondWarrior;
        private Dice dice;
        private int turn;
        private int[] results;

        public Arena(Warrior firstWarrior, Warrior secondWarrios, Dice dice)
        {
            this.firstWarrior = firstWarrior;
            this.secondWarrior = secondWarrios;
            this.dice = dice;
            this.turn = 1;
            this.results = new int[3] { 0, 0, 0 };
        }

        private void DrawArena()
        {
            Console.Clear();
            Intro();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write((firstWarrior + " " + firstWarrior.GetClass()).PadRight(30));
            Console.Write((secondWarrior.GetClass() + " " + secondWarrior).PadLeft(30));
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("health : ".PadRight(9));
            Console.Write(string.Format("{0}", firstWarrior.ShowLife(true).PadRight(21)));
            Console.Write(string.Format("{0}", secondWarrior.ShowLife(false), secondWarrior).PadLeft(21));
            Console.Write(" : health".PadLeft(9));
            Console.ResetColor();
            Console.WriteLine();

            if (firstWarrior is Mage mage)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("mana : ".PadRight(9));
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Write(string.Format("{0}", mage.ShowMana(true)));
                Console.ResetColor();
                Console.Write(" ");
            }
            else
                Console.Write(string.Format("").PadRight(30));

            if (secondWarrior is Mage mage1)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(" ");
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Write(string.Format("{0}", mage1.ShowMana(false)));
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(string.Format(" : mana".PadLeft(9)));
                Console.ResetColor();
            }

            Console.WriteLine();
        }

        public void StartBattle()
        {
            bool nextBattle = true;
            do
            {
                int battleCount = 0;
                int maxBattles = 10;
                ClearResults();

                while (battleCount < maxBattles)
                {
                    Intro();

                    while (firstWarrior.isAlive() && secondWarrior.isAlive())
                    {
                        DrawArena();

                        Console.WriteLine();
                        Summary();
                        Console.WriteLine(string.Format("Battle: " + battleCount + "     Turn: " + turn).PadLeft(35));
                        turn++;

                        firstWarrior.Attack(secondWarrior);
                        Console.WriteLine();
                        PrintBattleMessage(firstWarrior.Message());
                        PrintBattleMessage(secondWarrior.Message());

                        secondWarrior.Attack(firstWarrior);
                        Console.WriteLine();
                        PrintBattleMessage(secondWarrior.Message());
                        PrintBattleMessage(firstWarrior.Message());
                    }

                    battleCount++;
                    turn = 0;
                    DrawArena();
                    Winner();
                    HealWarriors();
                }

                Console.Write("Next battle? [y/n]");
                if (Console.ReadLine() != "y")
                    nextBattle = false;
            } while (nextBattle);
            
        }

        private void PrintBattleMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ResetColor();
            Thread.Sleep(100);
        }

        private void Intro()
        {
            Console.WriteLine(@"                                             ");
            Console.WriteLine(@"                 /\                          ");
            Console.WriteLine(@"                /  \   _ __ ___ _ __   __ _  ");
            Console.WriteLine(@"               / /\ \ | '__/ _ \ '_ \ / _` | ");
            Console.WriteLine(@"              / ____ \| | |  __/ | | | (_| | ");
            Console.WriteLine(@"             /_/    \_\_|  \___|_| |_|\__,_| ");
            Console.WriteLine(@"                                             ");

            Console.WriteLine("Welcome in arena!");
            Console.WriteLine("This fight is between {0} {1} and {2} {3}. ", firstWarrior, firstWarrior.GetClass(), secondWarrior, secondWarrior.GetClass());
            Console.WriteLine("Let the battle begin!");
            Console.WriteLine();
        }

        private void Winner()
        {
            Console.WriteLine();
            if (firstWarrior.isAlive() && !secondWarrior.isAlive())
            {
                Console.WriteLine("Winner is {0}", firstWarrior);
                results[0] += 1;
            }
            else if (!firstWarrior.isAlive() && secondWarrior.isAlive())
            {
                Console.WriteLine("Winner is {0}", secondWarrior);
                results[2] += 1;
            }
            else
            {
                Console.WriteLine("Both warriors died in the arena!");
                results[1] += 1;
            }
        }

        private void Summary()
        {
            Console.WriteLine();
            Console.WriteLine(@"{0} wins: {1}      Draws:    {4}        {2} wins: {3}    ", 
                                firstWarrior, results[0], secondWarrior, results[2], results[1]);
        }

        private void HealWarriors()
        {
            firstWarrior.HealFull();
            secondWarrior.HealFull();
        }

        private void ClearResults()
        {
            for(int i = 0; i < results.Length; i++)
            {
                results[i] = 0;
            }
        }
    }
}
