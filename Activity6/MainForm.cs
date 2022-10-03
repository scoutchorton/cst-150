namespace Activity2
{
    public partial class MainForm : Form
    {
        const string STATUS_DEFAULT = "Enter in values";

        // Conversion consts (1 Hebrew cubit = 17.5 inches)
        const double FEET_TO_HCUBITS = 12 / 17.5;
        const double HCUBITS_TO_FEET = 17.5 / 12;

        // Unit storage
        double feet = 0;
        double hcubits = 0;

        public MainForm()
        {
            InitializeComponent();
            statusLabel.Text = STATUS_DEFAULT;
        }

        /// <summary>
        /// Use the constant value to convert feet into Hebrew cubits
        /// </summary>
        /// <param name="feet"></param>
        /// <returns>Converted value</returns>
        private double feetToHcubits(double feet)
        {
            return feet * FEET_TO_HCUBITS;
        }

        /// <summary>
        /// Use the constant value to convert Hebrew cubits into feet
        /// </summary>
        /// <param name="hcubits"></param>
        /// <returns>Converted value</returns>
        private double hcubitsToFeet(double hcubits)
        {
            return hcubits * HCUBITS_TO_FEET;
        }

        /// <summary>
        /// Separate function to handle interacting with interface and running conversions
        /// </summary>
        private void handleConversion()
        {
            bool feetChanged = false;
            bool hcubitsChanged = false;

            statusLabel.Text = STATUS_DEFAULT;
            
            // Register changes in interface and update values on the class
            try {
                feetChanged = Double.Parse(feetInput.Text) != feet;
                feet = Double.Parse(feetInput.Text);
            } catch(FormatException) {
                statusLabel.Text = "Unable to parse feet";
                return;
            }
            try {
                hcubitsChanged = Double.Parse(cubitsInput.Text) != hcubits;
                hcubits = Double.Parse(cubitsInput.Text);
            } catch(FormatException) {
                statusLabel.Text = "Unable to parse cubits";
                return;
            }

            // Run conversion (priority to feet changed)
            if (feetChanged)
            {
                hcubits = feetToHcubits(feet);
            }
            else if(hcubitsChanged)
            {
                feet = hcubitsToFeet(hcubits);
            }

            // Update displays with new values
            // https://stackoverflow.com/a/4866573
            feetInput.Text = feet.ToString("0.000");
            cubitsInput.Text = hcubits.ToString("0.000");
        }

        /// <summary>
        /// Main event handler for the conversion button
        /// </summary>
        /// <param name="sender">Component sending the eevent</param>
        /// <param name="e">Event data</param>
        private void convertButton_Click(object sender, EventArgs e)
        {
            handleConversion();
        }
    }
}