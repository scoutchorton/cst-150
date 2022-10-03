namespace Activity7 {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.termInput = new System.Windows.Forms.TextBox();
            this.calcPiButton = new System.Windows.Forms.Button();
            this.reflectionLabel = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.termInput, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.calcPiButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.reflectionLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.valueLabel, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 116);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter term count:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // termInput
            // 
            this.termInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.termInput.Location = new System.Drawing.Point(352, 3);
            this.termInput.Name = "termInput";
            this.termInput.Size = new System.Drawing.Size(195, 23);
            this.termInput.TabIndex = 1;
            this.termInput.Enter += new System.EventHandler(this.calcPi);
            // 
            // calcPiButton
            // 
            this.calcPiButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.calcPiButton, 2);
            this.calcPiButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.calcPiButton.Location = new System.Drawing.Point(262, 32);
            this.calcPiButton.Name = "calcPiButton";
            this.calcPiButton.Size = new System.Drawing.Size(75, 23);
            this.calcPiButton.TabIndex = 2;
            this.calcPiButton.Text = "Calculate";
            this.calcPiButton.UseVisualStyleBackColor = true;
            this.calcPiButton.Click += new System.EventHandler(this.calcPi);
            // 
            // reflectionLabel
            // 
            this.reflectionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reflectionLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.reflectionLabel, 2);
            this.reflectionLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reflectionLabel.Location = new System.Drawing.Point(230, 61);
            this.reflectionLabel.Name = "reflectionLabel";
            this.reflectionLabel.Size = new System.Drawing.Size(140, 22);
            this.reflectionLabel.TabIndex = 3;
            this.reflectionLabel.Text = "Pi iterations";
            this.reflectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valueLabel
            // 
            this.valueLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.valueLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.valueLabel, 2);
            this.valueLabel.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.valueLabel.Location = new System.Drawing.Point(290, 90);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(20, 22);
            this.valueLabel.TabIndex = 4;
            this.valueLabel.Text = "0";
            this.valueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(600, 116);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.Text = "Approximate Pi";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox termInput;
        private Button calcPiButton;
        private Label reflectionLabel;
        private Label valueLabel;
    }
}