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
            this.numBtn3 = new System.Windows.Forms.Button();
            this.numBtn2 = new System.Windows.Forms.Button();
            this.numBtn1 = new System.Windows.Forms.Button();
            this.numBtn4 = new System.Windows.Forms.Button();
            this.numBtn5 = new System.Windows.Forms.Button();
            this.numBtn6 = new System.Windows.Forms.Button();
            this.numBtn7 = new System.Windows.Forms.Button();
            this.numBtn8 = new System.Windows.Forms.Button();
            this.numBtn9 = new System.Windows.Forms.Button();
            this.opBtnPlus = new System.Windows.Forms.Button();
            this.opBtnMinus = new System.Windows.Forms.Button();
            this.opBtnDivide = new System.Windows.Forms.Button();
            this.opBtnMultiply = new System.Windows.Forms.Button();
            this.opBtnBack = new System.Windows.Forms.Button();
            this.opBtnEqual = new System.Windows.Forms.Button();
            this.numBtn0 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputDisp
            // 
            this.inputDisp.BackColor = System.Drawing.Color.Olive;
            this.inputDisp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputDisp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.inputDisp.Location = new System.Drawing.Point(12, 12);
            this.inputDisp.Name = "inputDisp";
            this.inputDisp.ReadOnly = true;
            this.inputDisp.Size = new System.Drawing.Size(120, 26);
            this.inputDisp.TabIndex = 0;
            this.inputDisp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // numBtn3
            // 
            this.numBtn3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numBtn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.numBtn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numBtn3.Location = new System.Drawing.Point(63, 3);
            this.numBtn3.Name = "numBtn3";
            this.numBtn3.Size = new System.Drawing.Size(24, 24);
            this.numBtn3.TabIndex = 2;
            this.numBtn3.Text = "3";
            this.numBtn3.UseVisualStyleBackColor = false;
            this.numBtn3.Click += new System.EventHandler(this.numberButton_click);
            // 
            // numBtn2
            // 
            this.numBtn2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numBtn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.numBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numBtn2.Location = new System.Drawing.Point(33, 3);
            this.numBtn2.Name = "numBtn2";
            this.numBtn2.Size = new System.Drawing.Size(24, 24);
            this.numBtn2.TabIndex = 1;
            this.numBtn2.Text = "2";
            this.numBtn2.UseVisualStyleBackColor = false;
            this.numBtn2.Click += new System.EventHandler(this.numberButton_click);
            // 
            // numBtn1
            // 
            this.numBtn1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numBtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.numBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numBtn1.Location = new System.Drawing.Point(3, 3);
            this.numBtn1.Name = "numBtn1";
            this.numBtn1.Size = new System.Drawing.Size(24, 24);
            this.numBtn1.TabIndex = 0;
            this.numBtn1.Text = "1";
            this.numBtn1.UseVisualStyleBackColor = false;
            this.numBtn1.Click += new System.EventHandler(this.numberButton_click);
            // 
            // numBtn4
            // 
            this.numBtn4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numBtn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.numBtn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numBtn4.Location = new System.Drawing.Point(3, 33);
            this.numBtn4.Name = "numBtn4";
            this.numBtn4.Size = new System.Drawing.Size(24, 24);
            this.numBtn4.TabIndex = 5;
            this.numBtn4.Text = "4";
            this.numBtn4.UseVisualStyleBackColor = false;
            this.numBtn4.Click += new System.EventHandler(this.numberButton_click);
            // 
            // numBtn5
            // 
            this.numBtn5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numBtn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.numBtn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numBtn5.Location = new System.Drawing.Point(33, 33);
            this.numBtn5.Name = "numBtn5";
            this.numBtn5.Size = new System.Drawing.Size(24, 24);
            this.numBtn5.TabIndex = 4;
            this.numBtn5.Text = "5";
            this.numBtn5.UseVisualStyleBackColor = false;
            this.numBtn5.Click += new System.EventHandler(this.numberButton_click);
            // 
            // numBtn6
            // 
            this.numBtn6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numBtn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.numBtn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numBtn6.Location = new System.Drawing.Point(63, 33);
            this.numBtn6.Name = "numBtn6";
            this.numBtn6.Size = new System.Drawing.Size(24, 24);
            this.numBtn6.TabIndex = 7;
            this.numBtn6.Text = "6";
            this.numBtn6.UseVisualStyleBackColor = false;
            this.numBtn6.Click += new System.EventHandler(this.numberButton_click);
            // 
            // numBtn7
            // 
            this.numBtn7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numBtn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.numBtn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numBtn7.Location = new System.Drawing.Point(3, 63);
            this.numBtn7.Name = "numBtn7";
            this.numBtn7.Size = new System.Drawing.Size(24, 24);
            this.numBtn7.TabIndex = 8;
            this.numBtn7.Text = "7";
            this.numBtn7.UseVisualStyleBackColor = false;
            this.numBtn7.Click += new System.EventHandler(this.numberButton_click);
            // 
            // numBtn8
            // 
            this.numBtn8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numBtn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.numBtn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numBtn8.Location = new System.Drawing.Point(33, 63);
            this.numBtn8.Name = "numBtn8";
            this.numBtn8.Size = new System.Drawing.Size(24, 24);
            this.numBtn8.TabIndex = 9;
            this.numBtn8.Text = "8";
            this.numBtn8.UseVisualStyleBackColor = false;
            this.numBtn8.Click += new System.EventHandler(this.numberButton_click);
            // 
            // numBtn9
            // 
            this.numBtn9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numBtn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.numBtn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numBtn9.Location = new System.Drawing.Point(63, 63);
            this.numBtn9.Name = "numBtn9";
            this.numBtn9.Size = new System.Drawing.Size(24, 24);
            this.numBtn9.TabIndex = 10;
            this.numBtn9.Text = "9";
            this.numBtn9.UseVisualStyleBackColor = false;
            this.numBtn9.Click += new System.EventHandler(this.numberButton_click);
            // 
            // opBtnPlus
            // 
            this.opBtnPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opBtnPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.opBtnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opBtnPlus.Location = new System.Drawing.Point(93, 3);
            this.opBtnPlus.Name = "opBtnPlus";
            this.opBtnPlus.Size = new System.Drawing.Size(24, 24);
            this.opBtnPlus.TabIndex = 3;
            this.opBtnPlus.Text = "+";
            this.opBtnPlus.UseVisualStyleBackColor = false;
            this.opBtnPlus.Click += new System.EventHandler(this.operatorButton_click);
            // 
            // opBtnMinus
            // 
            this.opBtnMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opBtnMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.opBtnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opBtnMinus.Location = new System.Drawing.Point(93, 33);
            this.opBtnMinus.Name = "opBtnMinus";
            this.opBtnMinus.Size = new System.Drawing.Size(24, 24);
            this.opBtnMinus.TabIndex = 6;
            this.opBtnMinus.Text = "-";
            this.opBtnMinus.UseVisualStyleBackColor = false;
            this.opBtnMinus.Click += new System.EventHandler(this.operatorButton_click);
            // 
            // opBtnDivide
            // 
            this.opBtnDivide.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opBtnDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.opBtnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opBtnDivide.Location = new System.Drawing.Point(93, 93);
            this.opBtnDivide.Name = "opBtnDivide";
            this.opBtnDivide.Size = new System.Drawing.Size(24, 24);
            this.opBtnDivide.TabIndex = 13;
            this.opBtnDivide.Text = "/";
            this.opBtnDivide.UseVisualStyleBackColor = false;
            this.opBtnDivide.Click += new System.EventHandler(this.operatorButton_click);
            // 
            // opBtnMultiply
            // 
            this.opBtnMultiply.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opBtnMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.opBtnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opBtnMultiply.Location = new System.Drawing.Point(93, 63);
            this.opBtnMultiply.Name = "opBtnMultiply";
            this.opBtnMultiply.Size = new System.Drawing.Size(24, 24);
            this.opBtnMultiply.TabIndex = 11;
            this.opBtnMultiply.Text = "*";
            this.opBtnMultiply.UseVisualStyleBackColor = false;
            this.opBtnMultiply.Click += new System.EventHandler(this.operatorButton_click);
            // 
            // opBtnBack
            // 
            this.opBtnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opBtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.opBtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opBtnBack.Location = new System.Drawing.Point(3, 93);
            this.opBtnBack.Name = "opBtnBack";
            this.opBtnBack.Size = new System.Drawing.Size(24, 24);
            this.opBtnBack.TabIndex = 16;
            this.opBtnBack.Text = "←";
            this.opBtnBack.UseVisualStyleBackColor = false;
            this.opBtnBack.Click += new System.EventHandler(this.operatorButton_click);
            // 
            // opBtnEqual
            // 
            this.opBtnEqual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opBtnEqual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.opBtnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opBtnEqual.Location = new System.Drawing.Point(63, 93);
            this.opBtnEqual.Name = "opBtnEqual";
            this.opBtnEqual.Size = new System.Drawing.Size(24, 24);
            this.opBtnEqual.TabIndex = 12;
            this.opBtnEqual.Text = "=";
            this.opBtnEqual.UseVisualStyleBackColor = false;
            this.opBtnEqual.Click += new System.EventHandler(this.operatorButton_click);
            // 
            // numBtn0
            // 
            this.numBtn0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numBtn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.numBtn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numBtn0.Location = new System.Drawing.Point(33, 93);
            this.numBtn0.Name = "numBtn0";
            this.numBtn0.Size = new System.Drawing.Size(24, 24);
            this.numBtn0.TabIndex = 14;
            this.numBtn0.Text = "0";
            this.numBtn0.UseVisualStyleBackColor = false;
            this.numBtn0.Click += new System.EventHandler(this.numberButton_click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(144, 174);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.inputDisp);
            this.ForeColor = System.Drawing.Color.White;
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

