namespace Activity5 {
    partial class main {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.statsDisplay = new System.Windows.Forms.TextBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.statsDisplay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(763, 526);
            this.panel1.TabIndex = 0;
            // 
            // statsDisplay
            // 
            this.statsDisplay.BackColor = System.Drawing.Color.Gray;
            this.statsDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statsDisplay.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statsDisplay.Location = new System.Drawing.Point(20, 20);
            this.statsDisplay.Multiline = true;
            this.statsDisplay.Name = "statsDisplay";
            this.statsDisplay.ReadOnly = true;
            this.statsDisplay.Size = new System.Drawing.Size(723, 486);
            this.statsDisplay.TabIndex = 0;
            // 
            // openFile
            // 
            this.openFile.FileName = "textfile";
            this.openFile.Title = "Open File for Processing";
            // 
            // saveFile
            // 
            this.saveFile.Title = "Save Stats File";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(763, 526);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "main";
            this.Text = "Text Stats";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private OpenFileDialog openFile;
        private SaveFileDialog saveFile;
        private TextBox statsDisplay;
    }
}