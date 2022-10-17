namespace Activity11 {
    class Program {
        public static void Main(string[] args) {
            // Use the empty constructor that defaults to a D6
            Die die1 = new Die();
            Die die2 = new Die();

            int rollCount = 0;
            int result1 = 0;
            int result2 = 0;

            do {
                // Perform roll
                result1 = die1.rollDie();
                result2 = die2.rollDie();
                rollCount++;

                // Report results
                Console.WriteLine(String.Format("#{2}    1: {0}  2: {1}", result1, result2, rollCount));
                if(result1 == 1 && result2 == 1)
                    Console.WriteLine("Hiss!! Snake eyes!!");
            } while(!(result1 == 1 && result2 == 1));

            Console.WriteLine(String.Format("Took {0} roll{1} to get snake eyes.", rollCount, rollCount == 1 ? "" : "s"));
        }
    }
}