namespace Activity2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.feetLabel = new System.Windows.Forms.Label();
            this.cubitsLabel = new System.Windows.Forms.Label();
            this.feetInput = new System.Windows.Forms.TextBox();
            this.cubitsInput = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // feetLabel
            // 
            this.feetLabel.AutoSize = true;
            this.feetLabel.Location = new System.Drawing.Point(29, 39);
            this.feetLabel.Name = "feetLabel";
            this.feetLabel.Size = new System.Drawing.Size(45, 19);
            this.feetLabel.TabIndex = 0;
            this.feetLabel.Text = "Feet";
            this.feetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cubitsLabel
            // 
            this.cubitsLabel.AutoSize = true;
            this.cubitsLabel.Location = new System.Drawing.Point(11, 71);
            this.cubitsLabel.Name = "cubitsLabel";
            this.cubitsLabel.Size = new System.Drawing.Size(63, 19);
            this.cubitsLabel.TabIndex = 1;
            this.cubitsLabel.Text = "Cubits";
            this.cubitsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // feetInput
            // 
            this.feetInput.Location = new System.Drawing.Point(80, 36);
            this.feetInput.Name = "feetInput";
            this.feetInput.Size = new System.Drawing.Size(125, 26);
            this.feetInput.TabIndex = 2;
            this.feetInput.Text = "0";
            this.feetInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cubitsInput
            // 
            this.cubitsInput.Location = new System.Drawing.Point(80, 68);
            this.cubitsInput.Name = "cubitsInput";
            this.cubitsInput.Size = new System.Drawing.Size(125, 26);
            this.cubitsInput.TabIndex = 3;
            this.cubitsInput.Text = "0";
            this.cubitsInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(120, 102);
            this.convertButton.Margin = new System.Windows.Forms.Padding(5);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(85, 26);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusLabel.Location = new System.Drawing.Point(0, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(230, 19);
            this.statusLabel.TabIndex = 5;
            this.statusLabel.Text = "lorem ipsum";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(230, 141);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.cubitsInput);
            this.Controls.Add(this.feetInput);
            this.Controls.Add(this.cubitsLabel);
            this.Controls.Add(this.feetLabel);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "CubitConverter 3000";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label feetLabel;
        private Label cubitsLabel;
        private TextBox feetInput;
        private TextBox cubitsInput;
        private Button convertButton;
        private Label statusLabel;
    }
}