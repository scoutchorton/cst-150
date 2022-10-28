namespace Activity14 {
    public partial class MainForm : Form {
        Tense tense = Tense.NORMAL;
        Conjugation conjugation = Conjugation.INFINITIVE;
        List<Verb> verbsToConjugate = new List<Verb>();

        Verb[] verbs = {
            new Verb("mangi", VerbEnding.ARE),
            new Verb("ascolt", VerbEnding.ARE),
            new Verb("dorm", VerbEnding.IRE),
            new Verb("lavor", VerbEnding.ARE),
            new Verb("aspett", VerbEnding.ARE),
            new Verb("cant", VerbEnding.ARE),
            new Verb("vol", VerbEnding.ARE),
            new Verb("suon", VerbEnding.ARE),
            new Verb("parl", VerbEnding.ARE),
            new Verb("prend", VerbEnding.ERE),
        };

        public MainForm() {
            InitializeComponent();

            // Update verb list with stored verb data
            verbLayoutPanel.Controls.Clear();
            foreach(Verb verb in verbs) {
                CheckBox btn = new CheckBox();
                btn.Text = verb.conjugate(Conjugation.INFINITIVE, Tense.NORMAL);
                btn.Tag = verb; // Keep reference for later
                btn.CheckedChanged += new System.EventHandler(this.verbChanges);
                btn.Dock = DockStyle.Top;

                verbLayoutPanel.Controls.Add(btn);
            }

            // Set default values
            io.Checked = true;
            tenseListBox.SelectedItem = "Normal";

            // Update display
            updateConjugations();
        }

        /// <summary>
        /// Handle when the conjugation redio buttons update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void conjugationChanges(object sender, EventArgs e) {
            var button = (RadioButton)sender;

            // Only handle checked buttons
            if(!button.Checked) return;

            // Change conjugation
            switch(button.Tag) {
                case "io":
                    conjugation = Conjugation.IO;
                    break;
                case "tu":
                    conjugation = Conjugation.TU;
                    break;
                case "lui lei li":
                    conjugation = Conjugation.LUI_LEI_LI;
                    break;
                case "noi":
                    conjugation = Conjugation.NOI;
                    break;
                case "voi":
                    conjugation = Conjugation.VOI;
                    break;
                case "loro":
                    conjugation = Conjugation.LORO;
                    break;
                default:
                    conjugation = Conjugation.INFINITIVE;
                    break;
            }

            // Update display
            updateConjugations();
        }

        /// <summary>
        /// Handle when the conjugation redio buttons update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tenseChanges(object sender, EventArgs e) {
            var listbox = (ListBox)sender;

            // Update internal state
            switch(listbox.SelectedItem.ToString()) {
                case "Past":
                    tense = Tense.PAST;
                    break;
                case "Present":
                    tense = Tense.PRESENT;
                    break;
                case "Normal":
                default:
                    tense = Tense.NORMAL;
                    break;
            }

            // Update display
            updateConjugations();
        }

        /// <summary>
        /// Handle internal list state of verbs that need processing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void verbChanges(object sender, EventArgs e) {
            var checkbox = (CheckBox)sender;

            // Handle state update with internal list
            if(checkbox.Checked && !verbsToConjugate.Contains((Verb)checkbox.Tag))
                verbsToConjugate.Add((Verb)checkbox.Tag);
            else
                verbsToConjugate.Remove((Verb)checkbox.Tag);

            // Update display
            updateConjugations();
        }

        private void updateConjugations() {
            // Clear previous results state
            resultsBox.Text = "";

            // Iterate over verbs and conjugate
            foreach(Verb verb in verbsToConjugate) {
                resultsBox.Text += verb.conjugate(conjugation, tense);
                resultsBox.Text += Environment.NewLine;
            }

            // Default text
            if(verbsToConjugate.Count == 0)
                resultsBox.Text = "Please select a verb or verbs to the left.";
        }
    }
}