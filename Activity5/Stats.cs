namespace Activity5 {
    public partial class main : Form {
        List<string> words = new List<string>();

        string first = "";
        string last = "";
        string longest = "";
        string mostVowels = "";
        int vowelCount = 0;

        public main() {
            string stats = "";
            InitializeComponent();

            // Prompt to get the file for opening and check for a file
            openFile.ShowDialog();
            if(openFile.FileName.Length == 0)
                Close();

            // Get the stats of the file
            parseFile(openFile.FileName);
            stats += String.Concat("First: ", first, Environment.NewLine);
            stats += String.Concat("Last: ", last, Environment.NewLine);
            stats += String.Concat("Longest: ", longest, Environment.NewLine);
            stats += String.Concat("Most vowels: ", mostVowels, Environment.NewLine);

            // Display stats in the window and write stats to the file
            saveFile.FileName = Path.ChangeExtension(openFile.FileName, ".stats" + Path.GetExtension(openFile.FileName));
            saveFile.ShowDialog();
            if(saveFile.FileName.Length == 0)
                Close();

            File.WriteAllText(saveFile.FileName, stats);
            statsDisplay.AppendText(stats);
        }

        public void parseFile(string filename) {
            var lines = File.ReadLines(filename);
            string fileData = "";
            string word;

            // Read file line by line (avoids issues with line endings and File.ReadAllText)
            foreach(string line in lines) {
                fileData += line;
                fileData += " ";
            }
            string[] rawWords = fileData.Split(' ');

            // Grab list of words
            for(int index = 0; index < rawWords.Count(); index++) {
                word = rawWords[index].ToLower();

                // Add element to word list if not found
                if(words.IndexOf(word) == -1)
                    words.Add(word);
            }

            // Parse words
            for(int index = 0; index < words.Count; index++) {
                word = rawWords[index];

                // Count vowels and update if needed
                int tempCount = countVowels(word);
                if(tempCount > vowelCount) {
                    vowelCount = tempCount;
                    mostVowels = word;
                }

                // Check for alphabetical order
                if(word.CompareTo(first) < 0 || first.Length == 0)
                    first = word;
                if(word.CompareTo(last) > 0)
                    last = word;

                // Check for longest word
                if(longest.Length < word.Length)
                    longest = word;
            }
        }

        public int countVowels(string word) {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int count = 0;

            // Count each character for being a vowel
            foreach(char character in word) {
                if(Array.IndexOf(vowels, character) != -1)
                    count++;
            }

            return count;
        }
    }
}