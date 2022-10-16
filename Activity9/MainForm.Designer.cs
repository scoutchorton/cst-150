namespace Activity9 {
    partial class MainForm {
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
            this.stdtextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // stdtextbox
            // 
            this.stdtextbox.BackColor = System.Drawing.Color.Black;
            this.stdtextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stdtextbox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stdtextbox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.stdtextbox.Location = new System.Drawing.Point(0, 0);
            this.stdtextbox.Multiline = true;
            this.stdtextbox.Name = "stdtextbox";
            this.stdtextbox.ReadOnly = true;
            this.stdtextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.stdtextbox.Size = new System.Drawing.Size(800, 450);
            this.stdtextbox.TabIndex = 1;
            this.stdtextbox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stdtextbox);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox stdtextbox;
    }
}