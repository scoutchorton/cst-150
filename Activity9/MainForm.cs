using Microsoft.VisualBasic;
using System.Security.Policy;
using System.Threading;
using System;
using System.Reflection.Metadata.Ecma335;

/**
 * Although the property was set in the Designer, I was having an issue with
 * the text auto highlighting. Turns out the TabStop property needed to be
 * disabled to prevent it from auto selecting everything (since it's the only
 * component to have a focus on).
 * 
 * https://www.codeproject.com/Questions/238150/Removing-highlight-from-TextBox-or-turn-Highlighti
 */

namespace Activity9 {
    public partial class MainForm : Form {
        // Found out about the Random class from here: https://www.tutorialsteacher.com/articles/generate-random-numbers-in-csharp
        Random rng = new Random();

        public MainForm() {
            InitializeComponent();

            printResult("Sum of 1 and 5");
            sum(1, 5);
            printResult();

            printResult("Average of 37.3, 72.6, 27.5, 85.1, and 46.4", avg(37.3, 72.6, 27.5, 85.1, 46.4));
            
            printResult("Sum of two random numbers", sum());

            printResult("Shorter string of my sister's and my name (Caleb and Mikala)");
            shorter("Caleb", "Mikala");
            printResult();

            // Generated using JavaScript:
            // Array(10).fill(0).map(() => Math.random() * 100).map(num => num.toFixed(2)).join(', ');
            printResult("Biggest double value from array (52.93, 93.70, 56.33, 89.11, 3.69, 53.95, 90.08, 88.88, 90.94, 2.91)");
            double[] doubleList = { 52.93, 93.70, 56.33, 89.11, 3.69, 53.95, 90.08, 88.88, 90.94, 2.91 };
            max(doubleList);
            printResult();

            // Joining an int array: https://stackoverflow.com/a/145864
            printResult("Fifty random ints", String.Join(", ", randInts()));

            printResult("Two booleans are the same (false and true)", areSame(false, true).ToString());
            
            printResult("Double Pi", product(Math.PI, 2).ToString());

            // Generated using JavaScript:
            // Array(30).fill(0).map(() => Math.random() * 100).map(num => parseInt(num)).join(', ');
            // Initializing a 2D array docs:
            // https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/multidimensional-arrays#array-initialization
            int[,] intListList = new int[,] {
                { 33, 37, 46, 59, 0 },
                { 48, 18, 56, 47, 78 },
                { 28, 50, 24, 94, 2 },
                { 86, 60, 18, 10, 68 },
                { 22, 50, 76, 19, 61 },
                { 71, 70, 1, 91, 19 }
            };
            printResult("Average of 2D int array", product(Math.PI, 2).ToString());
        }

        /**
         * Utility functions
         */

        // I didn't want to continue to write CRLF
        private void addNewLine() {
            stdtextbox.Text += "\r\n";
        }

        // Handle new lines and indentation for output
        /// <summary>
        /// Print header of the prompt and prepare line for output
        /// </summary>
        /// <param name="prompt"></param>
        private void printResult(string prompt) {
            stdtextbox.Text += prompt;
            stdtextbox.Text += ":";
            addNewLine();
            stdtextbox.Text += "  ";
        }
        /// <summary>
        /// Print the closing newlines
        /// </summary>
        private void printResult() {
            addNewLine();
            addNewLine();
        }
        /// <summary>
        /// Print the header and result
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="result"></param>
        private void printResult(string prompt, string result) {
            printResult(prompt);
            stdtextbox.Text += result;
            printResult();
        }
        /// <summary>
        /// Print the header and result converting from an int to a string
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="result"></param>
        private void printResult(string prompt, int result) {
            printResult(prompt, result.ToString());
        }
        /// <summary>
        /// Print the header and result converting from a float to a string
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="result"></param>
        private void printResult(string prompt, double result) {
            printResult(prompt, result.ToString());
        }

        /**
         * Required functions for the assignment
         */

        // Write a method that takes two integers and displays their sum.
        private void sum(int num1, int num2) {
            int sumValue = num1 + num2;
            stdtextbox.Text += sumValue.ToString();
        }


        // Write a method that takes five doubles and returns their average.
        private double avg(double num1, double num2, double num3, double num4, double num5) {
            return (num1 + num2 + num3 + num4 + num5) / 5;
        }

        // Write a method that returns the sum of two randomly generated integers.
        private int sum() {
            int num1 = rng.Next();
            int num2 = rng.Next();
            return num1 + num2;
        }

        // Write a method that takes three integers and returns true if their sum is divisible by 3, false otherwise.
        private bool sumDivBy3(int num1, int num2, int num3) {
            // When divisible by 3, modulos will return 0 making the function return true on the result
            return ((num1 + num2 + num3) % 3) == 0;
        }

        // Write a method that takes two strings and displays the string that has fewer characters.
        private void shorter(string str1, string str2) {
            // Defaults to str1 if the strings are equal length
            if(str1.Length <= str2.Length)
                stdtextbox.Text += str1;
            else
                stdtextbox.Text += str2;
        }

        // Write a method that takes an array of doubles and returns the largest value in the array.
        private void max(double[] nums) {
            double maxValue = 0;

            foreach(double num in nums) {
                if(num > maxValue)
                    maxValue = num;
            }

            stdtextbox.Text += maxValue.ToString();
        }
        
        // Write a method that generates and returns an array of fifty integer values.
        private int[] randInts() {
            int[] nums = new int[50];

            for(int index = 0; index < nums.Length; index++)
                nums[index] = rng.Next();

            return nums;
        }

        // Write a method that takes two bool variables and returns true if they have the same value, false otherwise.
        private bool areSame(bool bool1, bool bool2) {
            return bool1 == bool2;
        }
        
        // Write a method that takes an int and a double and returns their product.
        private double product(double num2, int num1) {
            // Switch order for compatibility
            return product(num1, num2);
        }
        private double product(int num1, double num2) {
            return num1 * num2;
        }
        
        // Write a method that takes a two-dimensional array of integers and returns the average of the entries.
        private double avg(int[][] nums) {
            int sum = 0;
            int len = 0;

            foreach(int[] innerNums in nums) {
                foreach(int num in innerNums) {
                    sum += num;
                    len++;
                }
            }

            return ((double)sum) / len;
        }
    }
}