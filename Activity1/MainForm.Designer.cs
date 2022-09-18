namespace Activity1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputDisp = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.numBtn0 = new System.Windows.Forms.Button();
            this.opBtnDivide = new System.Windows.Forms.Button();
            this.opBtnEqual = new System.Windows.Forms.Button();
            this.opBtnPlus = new System.Windows.Forms.Button();
            this.numBtn3 = new System.Windows.Forms.Button();
            this.numBtn2 = new System.Windows.Forms.Button();
            this.numBtn1 = new System.Windows.Forms.Button();
            this.numBtn4 = new System.Windows.Forms.Button();
            this.numBtn5 = new System.Windows.Forms.Button();
            this.numBtn6 = new System.Windows.Forms.Button();
            this.opBtnMinus = new System.Windows.Forms.Button();
            this.numBtn7 = new System.Windows.Forms.Button();
            this.numBtn8 = new System.Windows.Forms.Button();
            this.numBtn9 = new System.Windows.Forms.Button();
            this.opBtnMultiply = new System.Windows.Forms.Button();
            this.opBtnBack = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputDisp
            // 
            this.inputDisp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputDisp.Location = new System.Drawing.Point(12, 12);
            this.inputDisp.Name = "inputDisp";
            this.inputDisp.ReadOnly = true;
            this.inputDisp.Size = new System.Drawing.Size(120, 26);
            this.inputDisp.TabIndex = 0;
            this.inputDisp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.inputDisp.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Controls.Add(this.numBtn3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.numBtn2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.numBtn1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.numBtn4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.numBtn5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.numBtn6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.numBtn7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.numBtn8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.numBtn9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.opBtnPlus, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.opBtnMinus, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.opBtnDivide, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.opBtnMultiply, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.opBtnBack, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.opBtnEqual, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.numBtn0, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 44);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(120, 120);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // numBtn0
            // 
            this.numBtn0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numBtn0.Location = new System.Drawing.Point(33, 93);
            this.numBtn0.Name = "numBtn0";
            this.numBtn0.Size = new System.Drawing.Size(24, 24);
            this.numBtn0.TabIndex = 14;
            this.numBtn0.Text = "0";
            this.numBtn0.UseVisualStyleBackColor = true;
            // 
            // opBtnDivide
            // 
            this.opBtnDivide.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opBtnDivide.Location = new System.Drawing.Point(93, 93);
            this.opBtnDivide.Name = "opBtnDivide";
            this.opBtnDivide.Size = new System.Drawing.Size(24, 24);
            this.opBtnDivide.TabIndex = 13;
            this.opBtnDivide.Text = "/";
            this.opBtnDivide.UseVisualStyleBackColor = true;
            // 
            // opBtnEqual
            // 
            this.opBtnEqual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opBtnEqual.Location = new System.Drawing.Point(63, 93);
            this.opBtnEqual.Name = "opBtnEqual";
            this.opBtnEqual.Size = new System.Drawing.Size(24, 24);
            this.opBtnEqual.TabIndex = 12;
            this.opBtnEqual.Text = "=";
            this.opBtnEqual.UseVisualStyleBackColor = true;
            // 
            // opBtnPlus
            // 
            this.opBtnPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opBtnPlus.Location = new System.Drawing.Point(93, 3);
            this.opBtnPlus.Name = "opBtnPlus";
            this.opBtnPlus.Size = new System.Drawing.Size(24, 24);
            this.opBtnPlus.TabIndex = 3;
            this.opBtnPlus.Text = "+";
            this.opBtnPlus.UseVisualStyleBackColor = true;
            // 
            // numBtn3
            // 
            this.numBtn3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numBtn3.Location = new System.Drawing.Point(63, 3);
            this.numBtn3.Name = "numBtn3";
            this.numBtn3.Size = new System.Drawing.Size(24, 24);
            this.numBtn3.TabIndex = 2;
            this.numBtn3.Text = "3";
            this.numBtn3.UseVisualStyleBackColor = true;
            this.numBtn3.Click += new System.EventHandler(this.button3_Click);
            // 
            // numBtn2
            // 
            this.numBtn2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numBtn2.Location = new System.Drawing.Point(33, 3);
            this.numBtn2.Name = "numBtn2";
            this.numBtn2.Size = new System.Drawing.Size(24, 24);
            this.numBtn2.TabIndex = 1;
            this.numBtn2.Text = "2";
            this.numBtn2.UseVisualStyleBackColor = true;
            this.numBtn2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numBtn1
            // 
            this.numBtn1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numBtn1.Location = new System.Drawing.Point(3, 3);
            this.numBtn1.Name = "numBtn1";
            this.numBtn1.Size = new System.Drawing.Size(24, 24);
            this.numBtn1.TabIndex = 0;
            this.numBtn1.Text = "1";
            this.numBtn1.UseVisualStyleBackColor = true;
            this.numBtn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numBtn4
            // 
            this.numBtn4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numBtn4.Location = new System.Drawing.Point(3, 33);
            this.numBtn4.Name = "numBtn4";
            this.numBtn4.Size = new System.Drawing.Size(24, 24);
            this.numBtn4.TabIndex = 5;
            this.numBtn4.Text = "4";
            this.numBtn4.UseVisualStyleBackColor = true;
            // 
            // numBtn5
            // 
            this.numBtn5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numBtn5.Location = new System.Drawing.Point(33, 33);
            this.numBtn5.Name = "numBtn5";
            this.numBtn5.Size = new System.Drawing.Size(24, 24);
            this.numBtn5.TabIndex = 4;
            this.numBtn5.Text = "5";
            this.numBtn5.UseVisualStyleBackColor = true;
            // 
            // numBtn6
            // 
            this.numBtn6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numBtn6.Location = new System.Drawing.Point(63, 33);
            this.numBtn6.Name = "numBtn6";
            this.numBtn6.Size = new System.Drawing.Size(24, 24);
            this.numBtn6.TabIndex = 7;
            this.numBtn6.Text = "6";
            this.numBtn6.UseVisualStyleBackColor = true;
            // 
            // opBtnMinus
            // 
            this.opBtnMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opBtnMinus.Location = new System.Drawing.Point(93, 33);
            this.opBtnMinus.Name = "opBtnMinus";
            this.opBtnMinus.Size = new System.Drawing.Size(24, 24);
            this.opBtnMinus.TabIndex = 6;
            this.opBtnMinus.Text = "-";
            this.opBtnMinus.UseVisualStyleBackColor = true;
            // 
            // numBtn7
            // 
            this.numBtn7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numBtn7.Location = new System.Drawing.Point(3, 63);
            this.numBtn7.Name = "numBtn7";
            this.numBtn7.Size = new System.Drawing.Size(24, 24);
            this.numBtn7.TabIndex = 8;
            this.numBtn7.Text = "7";
            this.numBtn7.UseVisualStyleBackColor = true;
            this.numBtn7.Click += new System.EventHandler(this.button9_Click);
            // 
            // numBtn8
            // 
            this.numBtn8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numBtn8.Location = new System.Drawing.Point(33, 63);
            this.numBtn8.Name = "numBtn8";
            this.numBtn8.Size = new System.Drawing.Size(24, 24);
            this.numBtn8.TabIndex = 9;
            this.numBtn8.Text = "8";
            this.numBtn8.UseVisualStyleBackColor = true;
            // 
            // numBtn9
            // 
            this.numBtn9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numBtn9.Location = new System.Drawing.Point(63, 63);
            this.numBtn9.Name = "numBtn9";
            this.numBtn9.Size = new System.Drawing.Size(24, 24);
            this.numBtn9.TabIndex = 10;
            this.numBtn9.Text = "9";
            this.numBtn9.UseVisualStyleBackColor = true;
            // 
            // opBtnMultiply
            // 
            this.opBtnMultiply.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opBtnMultiply.Location = new System.Drawing.Point(93, 63);
            this.opBtnMultiply.Name = "opBtnMultiply";
            this.opBtnMultiply.Size = new System.Drawing.Size(24, 24);
            this.opBtnMultiply.TabIndex = 11;
            this.opBtnMultiply.Text = "*";
            this.opBtnMultiply.UseVisualStyleBackColor = true;
            // 
            // opBtnBack
            // 
            this.opBtnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opBtnBack.Location = new System.Drawing.Point(3, 93);
            this.opBtnBack.Name = "opBtnBack";
            this.opBtnBack.Size = new System.Drawing.Size(24, 24);
            this.opBtnBack.TabIndex = 16;
            this.opBtnBack.Text = "←";
            this.opBtnBack.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(144, 174);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.inputDisp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Activity 1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputDisp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button numBtn1;
        private System.Windows.Forms.Button numBtn2;
        private System.Windows.Forms.Button numBtn3;
        private System.Windows.Forms.Button numBtn7;
        private System.Windows.Forms.Button opBtnPlus;
        private System.Windows.Forms.Button numBtn4;
        private System.Windows.Forms.Button numBtn5;
        private System.Windows.Forms.Button numBtn6;
        private System.Windows.Forms.Button opBtnMinus;
        private System.Windows.Forms.Button numBtn0;
        private System.Windows.Forms.Button opBtnDivide;
        private System.Windows.Forms.Button opBtnEqual;
        private System.Windows.Forms.Button numBtn8;
        private System.Windows.Forms.Button numBtn9;
        private System.Windows.Forms.Button opBtnMultiply;
        private System.Windows.Forms.Button opBtnBack;
    }
}

