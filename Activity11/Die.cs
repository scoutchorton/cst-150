using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity11 {
    /// <summary>
    /// Basic Exception to express when an error occurs with a number of sides
    /// on a die
    /// </summary>
    class SideCountException : Exception {
        public SideCountException() { }
        public SideCountException(string message) : base(message) { }
    }

    class Die {
        private int sides;
        // Use of the Random class found from here: https://www.tutorialsteacher.com/articles/generate-random-numbers-in-csharp
        private Random rng = new Random();

        /// <summary>
        /// Create a die by default with 6 sides.
        /// </summary>
        // Using default values derived from this answer: https://stackoverflow.com/a/4009032
        public Die() : this(6) {}

        /// <summary>
        /// Create a die with a specific number of sides.
        /// </summary>
        /// <param name="sides"></param>
        public Die(int sides) {
            if(sides < 4) throw new SideCountException("Minimum number of sides is 4.");
            if(sides > 20) throw new SideCountException("Maximum number of sides is 20.");

            this.sides = sides;
        }

        /// <summary>
        /// Roll a random number for the die.
        /// </summary>
        /// <returns>The number between 1 and the max side.</returns>
        public int rollDie() {
            // Minimum is inclusive, so go from 1
            // Maximum is exclusive, so go one above (a D20 includes the 20 face, so it would be included if the max is 21)
            return rng.Next(1, sides + 1);
        }
    }
}
