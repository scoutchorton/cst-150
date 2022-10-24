namespace Activity13 {
    public partial class MainForm : Form {
        /// <summary>
        /// Alias array to labels that make up the tic tac toe grid
        /// </summary>
        private System.Windows.Forms.Label[] gridLabels;
        private char[] gridData;

        /// <summary>
        /// Boolean value for the user turn. True for user, false for computer
        /// </summary>
        private bool userTurn;
        private Random rng = new Random();

        public MainForm() {
            InitializeComponent();

            // Assign each label to the list in left to right and top to bottom order
            gridLabels = new System.Windows.Forms.Label[] {
                x0y0,
                x1y0,
                x2y0,
                x0y1,
                x1y1,
                x2y1,
                x0y2,
                x1y2,
                x2y2
            };
            // Initialize data (singular characters)
            gridData = new char[] {
                '-', '-', '-',
                '-', '-', '-',
                '-', '-', '-'
            };

            // Randomize turn order
            userTurn = rng.Next() % 2 == 0 ? true : false;
        }

        /// <summary>
        /// Switch user/computer turns
        /// </summary>
        /// <returns>userTurn</returns>
        private bool turn() {
            return (userTurn = !userTurn);
        }

        /// <summary>
        /// Update labels from grid data
        /// </summary>
        private void updateGrid() {

        }
    }
}