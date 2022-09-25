namespace Activity4 {
    public partial class Form1 : Form {
        /// <summary>
        /// Create the components when creating the form
        /// </summary>
        public Form1() {
            InitializeComponent();
        }

        /// <summary>
        /// Handle when the user updates the seconds text box
        /// </summary>
        /// <param name="sender">Sending component</param>
        /// <param name="e">Event data</param>
        private void updatedSeconds(object sender, EventArgs e) {
            int intValue = 0;
            float value = 0;

            if(sender == null) return;

            // Attempt to parse as int
            if(int.TryParse((sender as TextBox).Text, out intValue)) {
                value = (float)intValue;
            // Attempt to parse as float
            } else if(float.TryParse((sender as TextBox).Text, out value)) {
                // Value is already set
            // Empty value
            } else if((sender as TextBox).Text.Length == 0) {
                value = 0;
            // Set error message because all else failed
            } else {
                statusLabel.Text = "Not a valid number.";
                return;
            }

            // Clear error message
            statusLabel.Text = "Enter seconds";

            // Calculate value
            if(value >= 86400) {
                value = value / 86400;
                valueOutput.Text = value.ToString();
                unitOutput.Text = value == 1.0 ? "day" : "days";
            } else if(value >= 3600) {
                value = value / 3600;
                valueOutput.Text = value.ToString();
                unitOutput.Text = value == 1.0 ? "hour" : "hours";
            } else if(value >= 60) {
                value = value / 60;
                valueOutput.Text = value.ToString();
                unitOutput.Text = value == 1.0 ? "minute" : "minutes";
            } else {
                valueOutput.Text = value.ToString();
                unitOutput.Text = value == 1.0 ? "second" : "seconds";
            }
        }
    }
}