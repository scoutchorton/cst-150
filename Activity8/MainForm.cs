namespace Activity8 {
    public partial class MainForm : Form {
        int carbGramsValue = 0;
        int fatGramsValue = 0;
        
        public MainForm() {
            InitializeComponent();
            UpdateOutput();
        }

        // Conversion "algorithms"
        private int CarbCalories(int count) {
            return count * 4;
        }
        private int FatCalories(int count) {
            return count * 9;
        }

        // Text handlers
        private void UpdateOutput(string? msg = null) {
            // Use default value output
            if(msg == null) {
                string[] data = {
                    "Total carbohydrate calories: " + carbGramsValue.ToString(),
                    "Total fat calories: " + fatGramsValue.ToString(),
                    "Total calories: " + (carbGramsValue + fatGramsValue).ToString()
                };
                totalOutput.Text = string.Join("\n", data);
            // Utilize custom message
            } else {
                totalOutput.Text = msg;
            }
        }


        // Event handlers
        public void handleUserInput(object sender, EventArgs e) {
            // Validate state
            if(sender == null) {
                return;
            }

            try {
                // Handle conversions by name
                string text = (sender as TextBox)!.Text;
                switch((sender as TextBox)!.Name) {
                    case "carbGrams":
                        if(text.Length == 0)
                            carbGramsValue = 0;
                        else
                            carbGramsValue = CarbCalories(int.Parse(text));
                        break;
                    case "fatGrams":
                        if(text.Length == 0)
                            fatGramsValue = 0;
                        else
                            fatGramsValue = FatCalories(int.Parse(text));
                        break;
                }
            } catch(System.FormatException) {
                // ignore
            } finally {
                UpdateOutput();
            }
        }
    }
}