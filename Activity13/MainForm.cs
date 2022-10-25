namespace Activity13 {
    enum WinState {
        NO_WIN,
        USER_WIN,
        COMP_WIN
    }

    enum Marker {
        NULL = '-',
        USER = 'X',
        COMP = 'O'
    }

    public partial class MainForm : Form {

        /// <summary>
        /// Alias array to labels that make up the tic tac toe grid
        /// </summary>
        private Label[][] gridLabels;
        /// <summary>
        /// Raw data for the grid to be pushed to the labels
        /// </summary>
        private Marker[][] gridData;

        /// <summary>
        /// Boolean value for the user turn. True for user, false for computer
        /// </summary>
        private bool isUserTurn;
        private Random rng = new Random();

        public MainForm() {
            InitializeComponent();

            // Assign each label to the list in left to right and top to bottom order
            gridLabels = new Label[3][] {
                new Label[3] { x0y0, x1y0, x2y0 },
                new Label[3] { x0y1, x1y1, x2y1 },
                new Label[3] { x0y2, x1y2, x2y2 }
            };
            // Initialize data (singular characters)
            gridData = new Marker[3][] {
                new Marker[3] { Marker.NULL, Marker.NULL, Marker.NULL },
                new Marker[3] { Marker.NULL, Marker.NULL, Marker.NULL },
                new Marker[3] { Marker.NULL, Marker.NULL, Marker.NULL }
            };
            updateGrid();

            // Randomize turn order
            isUserTurn = rng.Next() % 2 == 0 ? true : false;
            setTurnStatus();

            // Run computer's turn if needed to kickstart game
            if(!isUserTurn)
                computerTurn();
        }

        /// <summary>
        /// Switch user/computer turns
        /// </summary>
        /// <returns>userTurn</returns>
        private bool turn() {
            return (isUserTurn = !isUserTurn);
        }
        /// <summary>
        /// Computer's AI logic
        /// </summary>
        private void computerTurn() {
            int xIndex = -1;
            int yIndex = -1;

            // Find available slot to place marker
            do {
                xIndex = rng.Next(0, 3);
                yIndex = rng.Next(0, 3);
            } while(gridData[yIndex][xIndex] != Marker.NULL);

            // Set marker at new spot
            setMarker(xIndex, yIndex);

            // Concede turn back to player
            turn();

            // Update screen
            updateGrid();
            setTurnStatus();

            // Check for win
            WinState state = checkWin();
            if(state != WinState.NO_WIN)
                setWinStatus(state);
        }
        private void userTurn(object sender, EventArgs e) {
            int xIndex = -1;
            int yIndex = -1;

            // Validate status
            if(sender == null) return;
            else if(!isUserTurn) return;

            // Convert object to label
            Label label = sender as Label;

            // Short circuit for a label that is already set
            if(label.Text != ((char) Marker.NULL).ToString()) return;

            // Find index of item
            for(int y = 0; y < 3; y++) {
                for(int x = 0; x < 3; x++) {
                    if(gridLabels[y][x] == label) {
                        xIndex = x;
                        break;
                    }
                }

                if(xIndex != -1) {
                    yIndex = y;
                    break;
                }
            }

            // Ignore click if the label somehow isn't found
            if(xIndex == -1 || yIndex == -1) return;

            // Set item marker now that label is found and valid for placement
            setMarker(xIndex, yIndex);

            // Concede turn back to computer
            turn();

            // Update screen
            updateGrid();
            setTurnStatus();

            // Check for win or do computer's turn when there is no win
            WinState state = checkWin();
            if(state != WinState.NO_WIN)
                setWinStatus(state);
            else
                computerTurn();
        }
        private WinState checkWin() {
            // Iterate rows
            for(int y = 0; y < 3; y++) {
                Marker[] rowData = gridData[y];
                if(rowData[0] == rowData[1] && rowData[1] == rowData[2] && rowData[0] != Marker.NULL)
                    return rowData[0] == Marker.USER ? WinState.USER_WIN : WinState.COMP_WIN;
            }

            // Iterate columns
            for(int x = 0; x < 3; x++) {
                if(gridData[0][x] == gridData[1][x] && gridData[1][x] == gridData[2][x] && gridData[0][x] != Marker.NULL)
                    return gridData[0][x] == Marker.USER ? WinState.USER_WIN : WinState.COMP_WIN;
            }

            // Check diagonals
            if(gridData[0][0] == gridData[1][1] && gridData[1][1] == gridData[2][2] && gridData[0][0] != Marker.NULL)
                return gridData[0][0] == Marker.USER ? WinState.USER_WIN : WinState.COMP_WIN;
            else if(gridData[2][0] == gridData[1][1] && gridData[1][1] == gridData[0][2] && gridData[0][2] != Marker.NULL)
                return gridData[0][2] == Marker.USER ? WinState.USER_WIN : WinState.COMP_WIN;

            // Default on no win if nothing was found
            return WinState.NO_WIN;
        }

        /// <summary>
        /// Sets the marker based on the user's turns
        /// </summary>
        /// <param name="x">x grid coordinate</param>
        /// <param name="y">y grid coordinate</param>
        private void setMarker(int x, int y) {
            gridData[y][x] = isUserTurn ? Marker.USER : Marker.COMP;
        }
        /// <summary>
        /// Update labels from grid data
        /// </summary>
        private void updateGrid() {
            for(int y = 0; y < 3; y++) {
                for(int x = 0; x < 3; x++) {
                    gridLabels[y][x].Text = ((char) gridData[y][x]).ToString();
                }
            }
        }

        /// <summary>
        /// Update the status label
        /// </summary>
        /// <param name="msg">Message/status to display</param>
        private void setStatus(String msg) {
            status.Text = msg;
        }
        /// <summary>
        /// Update the status label with the player's turn
        /// </summary>
        private void setTurnStatus() {
            setStatus(String.Format("{0}'s turn", isUserTurn ? "User" : "Computer"));
        }
        /// <summary>
        /// Update the status label with the 
        /// </summary>
        /// <param name="state"></param>
        private void setWinStatus(WinState state) {
            if(state == WinState.NO_WIN) return;

            setStatus(String.Format("{0} win{1}!", state == WinState.USER_WIN ? "You" : "Computer", state == WinState.USER_WIN ? "" : "s"));
        }
    }
}