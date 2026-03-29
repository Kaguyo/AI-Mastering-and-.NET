using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.Random;

namespace DelegateTurnGame.Utils
{
    public static class RNG
    {
        // Shared Random instance to avoid repetition issues
        private static readonly Random rng = new Random();

        /// <summary>
        /// Generates a random float between 0.0 (inclusive) and 100.0 (approximately exclusive).
        /// Uses NextDouble() which returns values >= 0.0 and < 1.0.
        /// </summary>
        public static float RollZeroToHundred()
        {
            // Scale the 0.0–1.0 range to 0.0–100.0
            return (float)(rng.NextDouble() * 100.0);
        }

        /// <summary>
        /// Rolls a percentile and returns true if the result is under or equal to the given chancePercentage.
        /// Example: critChance = 25 => 25% chance to return true.
        /// </summary>
        public static bool RollChance(float chancePercentage)
        {
            float roll = RollZeroToHundred();
            return roll <= chancePercentage;
        }

        /// <summary>
        /// Rolls a random integer between 0 and 100 inclusive.
        /// </summary>
        public static int RollIntZeroToHundred()
        {
            return rng.Next(0, 101);
        }
    }
}
