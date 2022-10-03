namespace Activity7 {
    public partial class main : Form {
        const string REFLECTION_FORMAT = "Approximate value of pi after {0} terms";

        public main() {
            InitializeComponent();
        }

        private void calcPi(object sender, EventArgs e) {
            int terms = 0;
            double result = 0;
            double test = 0;

            // Handle parsing the text input
            try {
                terms = int.Parse(termInput.Text);
            } catch(FormatException) {
                reflectionLabel.Text = "Unable to parse term input.";
                valueLabel.Text = "0";
            }

            // Iterate over each term, using the term number as basis for the division (1 => 4/1, 2 => 4/3, 3 => 4/5, etc.)
            for(int term = 1; term <= terms; term++) {
                if(term % 2 == 0)
                    result += 4.0 / ((term * 2) - 1);
                else
                    result -= 4.0 / ((term * 2) - 1);
            }

            // Handle special zero case
            // The logic above works correctly with terms >= 1, but breaks down at zero, so an override is in place to handle that
            if(terms == 0)
                result = 4;

            // Write result
            valueLabel.Text = result.ToString();
            reflectionLabel.Text = String.Format(REFLECTION_FORMAT, terms);
        }
    }
}