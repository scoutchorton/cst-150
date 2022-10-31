using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity15 {
    public partial class mainForm : Form {
        numberDisplay numForm = new numberDisplay();
        Random rng = new Random();

        public mainForm() {
            InitializeComponent();
            favoriteNumberBox.Minimum = decimal.MinValue;
            favoriteNumberBox.Maximum = decimal.MaxValue;
            sugarValue.Minimum = decimal.MinValue;
            sugarValue.Maximum = decimal.MaxValue;
        }

        /// <summary>
        /// Take a multidigit number and reduce down to a single digit number by adding each digit together
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public long reduceNumber(long number) {
            // Get absolute value because a negative sign would break parsing
            string numAsStr = Math.Abs(number).ToString();
            long total = 0;

            foreach(char c in numAsStr)
                total += long.Parse(c.ToString());

            if(total > 9) return reduceNumber(total);
            return total;
        }

        /// <summary>
        /// Takes form input, creates "lucky number", and shows in new form
        /// </summary>
        /// <param name="sender">Ignored</param>
        /// <param name="e">Ignored</param>
        public void generateNumber(object sender, EventArgs e) {
            // https://stackoverflow.com/a/35425123
            long timestamp = ((DateTimeOffset)birthdayPicker.Value).ToUnixTimeSeconds();
            long favNumber = (long)favoriteNumberBox.Value;
            long sweetener = (long)sugarValue.Value;

            if(sweetener == 0) {
                sweeten(null);
                sweetener = (long)sugarValue.Value;
            }

            // Reduce number down to "lucky number"
            long luckyNumber = reduceNumber((timestamp + favNumber) * sweetener);

            // Update and show form
            numForm.Close();
            numForm = new numberDisplay();
            numForm.numberOutput.Text = luckyNumber.ToString();
            numForm.Show();
        }

        /// <summary>
        /// A meh excuse to fufill the requirement for a control that programmatically updates another
        /// </summary>
        /// <param name="sender">Ignored</param>
        /// <param name="e">Ignored</param>
        public void updateSweetener(object sender, EventArgs e) {
            long timestamp = ((DateTimeOffset)birthdayPicker.Value).ToUnixTimeSeconds();
            long favNumber = (long)favoriteNumberBox.Value;

            sweeten(timestamp + favNumber);
        }

        /// <summary>
        /// Utlize the Random class to add a salt/sweetener to the random number
        /// </summary>
        /// <param name="seed"></param>
        public void sweeten(long? seed) {
            // Update seed when set
            if(seed != null)
                rng = new Random((int)seed);

            // https://stackoverflow.com/a/43258664
            /*
             * Value has to be clamped to the Int64/long max/min due to an issue with WinForm's hexidecimal conversion (sugarValue is displayed as hex)
             * When the control goes to update the text before converting to hexidecimal, the value is converted to a long which handles the hex string conversion.
             * A decimal value which is larger than a long could cause this value to overflow, giving a System.OverflowException.
             * 
             * Stack trace:
             * sugarValue.Value = ((decimal)rng.NextDouble()) * (decimal.MaxValue) - (decimal.MaxValue / 2) (my code)
             * NumericUpDown.Value setter https://github.com/dotnet/winforms/blob/4.8/src/System.Windows.Forms/src/System/Windows/Forms/NumericUpDown.cs#L374
             * NumericUpDown.UpdateEditText https://github.com/dotnet/winforms/blob/4.8/src/System.Windows.Forms/src/System/Windows/Forms/NumericUpDown.cs#L801
             * NumericUpDown.GetNumberText https://github.com/dotnet/winforms/blob/4.8/src/System.Windows.Forms/src/System/Windows/Forms/NumericUpDown.cs#L759
             * text = ((long)num).ToString("X", CultureInfo.InvariantCulture);
             *               ^-- failed/overflowed cast from decimal to long
             */
            sugarValue.Value = ((decimal)rng.NextDouble()) * (long.MaxValue) - (long.MaxValue / 2);
        }
    }
}
