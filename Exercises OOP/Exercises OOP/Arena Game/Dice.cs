using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_OOP
{
    /// <summary>
    /// This class represents board game dice
    /// </summary>
    internal class Dice
    {
        /// <summary>
        /// Number of sides an a dice
        /// </summary>
        private int sides;
        /// <summary>
        /// Random number generator
        /// </summary>
        private static Random random = new Random();
        /// <summary>
        /// Stores the last thrown number
        /// </summary>
        private int lastThrow;

        /// <summary>
        /// Generates 6 side dice
        /// </summary>
        public Dice()
        {
            sides = 6;
        }

        /// <summary>
        /// Generates dice with specified number of sides
        /// </summary>
        /// <param name="sides">Number of sides on a dice</param>
        public Dice(int sides)
        {
            this.sides = sides;
        }

        /// <summary>
        /// Returns number of sides on a dice
        /// </summary>
        /// <returns>Number of sides</returns>
        public int GetNumberOfSides()
        {
            return sides;
        }

        /// <summary>
        /// Returns last thrown number
        /// </summary>
        /// <returns>Number from 1 to number of sides</returns>
        public int LastThrownNumber()
        {
            return lastThrow;
        }

        /// <summary>
        /// Returns thrown number
        /// </summary>
        /// <returns>Current thrown number</returns>
        public int Throw()
        {
            // random.Next(); - returns random number in range of int
            // random.Next("upper bound"); - returns random number between 0 and "upper bound" BUT NOT THE UPPER BOUND ITSELF!!!
            // random.Next("from", "up to"); - returns random number between "lower bound" and "upper bound" BUT NOT THE UPPER BOUND ITSELF!!!
            lastThrow  = random.Next(1, sides + 1);
            return lastThrow;
        }

        /// <summary>
        /// Returns string info about the Dice (how many sides it has)
        /// </summary>
        /// <returns>Returns string info about the Dice (how many sides it has)</returns>
        public override string ToString()
        {
            return $"{sides} side dice";
            // return String.Format("Dice with {0} sides", sides);
        }

        /// <summary>
        /// Generates number of throws with the dice
        /// </summary>
        /// <param name="numberOfThrows">Number of throws</param>
        public void ThrowManyTimes(int numberOfThrows)
        {
            for (int i = 0; i < numberOfThrows; i++)
            {
                Throw();
                Console.Write(lastThrow + " ");
            }
        }
    }
}
