namespace Activity12 {
    public class Activity {
        public static int Main(String[] args) {
            // Require filename be provided
            if(args.Length < 1) {
                Console.Error.WriteLine("Expected a filename argument");
                return 1;
            }

            // Hand control over to parsing function
            parseFile(args[0]);

            return 0;
        }

        private static char? lastLetter(String word) {
            return null;
        }

        private static bool checkWord(String word) {
            return false;
        }

        private static void parseFile(String filename) {

        }
    }
}