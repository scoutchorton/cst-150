using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity1
{
    public partial class MainForm : Form
    {
        // Display values
        string num1 = "";
        string op = "";
        string num2 = "";

        // Display flags
        bool error = false;
        bool equals = false;

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clear display and add in the numbers + operators
        /// </summary>
        private void updateDisplay()
        {
            inputDisp.ResetText();

            if (error)
            {
                inputDisp.AppendText("Err");
                return;
            }

            if (equals)
                inputDisp.AppendText("= ");

            if (num1.Length > 0)
                inputDisp.AppendText(num1);
            if (op.Length > 0)
                inputDisp.AppendText(" " + op);
            if (num2.Length > 0)
                inputDisp.AppendText(" " + num2);
        }

        /// <summary>
        /// Cleans up the flags and display values
        /// </summary>
        private void cleanState()
        {
            // The second number probably caused an error (divide by zero), so clean it up
            if(error)
                num2 = "";

            error = false;
            equals = false;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        { }

        /// <summary>
        /// Handle number button presses and add data to the number displays
        /// </summary>
        /// <param name="sender">Component that sent the event</param>
        /// <param name="e">Event data</param>
        private void numberButton_click(object sender, EventArgs e)
        {
            // Make sure the error display is handled
            cleanState();

            // Decide which number to add to
            int numIndex = (op.Length == 0) ? 1 : 2;

            // Add data to specific number
            switch(numIndex)
            {
                case 1:
                    num1 += (sender as Button).Text;
                    break;
                case 2:
                    num2 += (sender as Button).Text;
                    break;
            }

            updateDisplay();
        }

        /// <summary>
        /// Handle the non-number button presses
        /// </summary>
        /// <param name="sender">Component that sent the event</param>
        /// <param name="e">Event data</param>
        private void operatorButton_click(object sender, EventArgs e)
        {
            // Make sure the error display is handled
            cleanState();

            // Get operator
            string opName = (sender as Button).Text;

            // Perform operation
            switch (opName)
            {
                // Normal math operations update the op variable
                case "+":
                case "-":
                case "*":
                case "/":
                    op = opName;

                    // Force the first number to be zero when nothing was entered before doing the calculation
                    if (num1.Length == 0)
                        num1 = "0";
                    break;

                // Backspace removes from available string
                case "←":
                    if (num2.Length > 0)
                        num2 = num2.Remove(num2.Length - 1);
                    else if (op.Length > 0)
                        op = "";
                    else if (num1.Length > 0)
                        num1 = num1.Remove(num1.Length - 1);
                    break;

                // Perform calculation
                case "=":
                    int result = 0;

                    // Calculate based on operator
                    try
                    {

                        switch(op)
                        {
                            case "+":
                                result = int.Parse(num1) + int.Parse(num2);
                                break;
                            case "-":
                                result = int.Parse(num1) - int.Parse(num2);
                                break;
                            case "*":
                                result = int.Parse(num1) * int.Parse(num2);
                                break;
                            case "/":
                                result = int.Parse(num1) / int.Parse(num2);
                                break;
                        }
                    }
                    catch
                    {
                        error = true;
                        break;
                    }

                    // Update display values
                    num1 = result.ToString();
                    op = "";
                    num2 = "";
                    equals = true;
                    break;
            }

            // Update value displayed in text field
            updateDisplay();
        }
    }
}
