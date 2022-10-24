namespace Activity12 {
    public class Activity {
        public static int Main(String[] args) {
            // Require filename be provided
            if(args.Length < 1) {
                Console.Error.WriteLine("Expected a filename argument.");
                return 1;
            }
            String filename = args[0];

            // Require file exists
            if(!File.Exists(filename)) {
                Console.Error.WriteLine("Expected an existing file.");
                return 1;
            }

            // Hand control over to parsing function
            parseFile(filename);

            return 0;
        }

        private static char? lastLetter(String word) {
            char letter = '\0';

            // Reverse through the word to find the first (technically last) letter for comparison later
            foreach(char ch in word.Reverse()) {
                // Found from Google: https://www.geeksforgeeks.org/c-sharp-char-isletter-method
                if(!Char.IsLetter(ch)) continue;

                letter = Char.ToLower(ch);
                break;
            }

            return letter == 't' || letter == 'e' ? letter : null;
        }

        private static bool checkWord(String word) {
            // Ignore strings with no characters
            if(word.Length == 0) return false;
            // Let lastLetter handle the logic
            return lastLetter(word) != null;
        }

        private static void parseFile(String filename) {
            // Load and parse initial data
            String filedata = File.ReadAllText(filename);
            filedata = filedata.ReplaceLineEndings(" ");
            String[] words = filedata.Split(" ");
            List<String> foundWords = new List<String>();

            // Parse words
            foreach(String word in words) {
                if(checkWord(word))
                    foundWords.Add(word);
            }
            foundWords.Sort();

            // Output final result
            Console.WriteLine(String.Format("There are {0} words that end with 'e' or 't'.", foundWords.Count));
            Console.WriteLine(String.Join(", ", foundWords));
        }
    }
}