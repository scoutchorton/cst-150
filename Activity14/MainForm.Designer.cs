namespace Activity14 {
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
            this.verbGroup = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.luileili = new System.Windows.Forms.RadioButton();
            this.io = new System.Windows.Forms.RadioButton();
            this.tu = new System.Windows.Forms.RadioButton();
            this.noi = new System.Windows.Forms.RadioButton();
            this.voi = new System.Windows.Forms.RadioButton();
            this.loro = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tenseListBox = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.resultsBox = new System.Windows.Forms.TextBox();
            this.verbLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.verbGroup.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.verbLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // verbGroup
            // 
            this.verbGroup.BackColor = System.Drawing.Color.Black;
            this.verbGroup.Controls.Add(this.verbLayoutPanel);
            this.verbGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.verbGroup.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.verbGroup.Location = new System.Drawing.Point(3, 3);
            this.verbGroup.Name = "verbGroup";
            this.verbGroup.Size = new System.Drawing.Size(394, 219);
            this.verbGroup.TabIndex = 0;
            this.verbGroup.TabStop = false;
            this.verbGroup.Text = "Verb";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Location = new System.Drawing.Point(3, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 219);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conjugation";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.luileili, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.io, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tu, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.noi, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.voi, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.loro, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33445F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33442F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33113F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(388, 197);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // luileili
            // 
            this.luileili.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.luileili.AutoSize = true;
            this.luileili.Location = new System.Drawing.Point(3, 133);
            this.luileili.Name = "luileili";
            this.luileili.Size = new System.Drawing.Size(188, 61);
            this.luileili.TabIndex = 3;
            this.luileili.TabStop = true;
            this.luileili.Tag = "lui lei li";
            this.luileili.Text = "lui, lei, li (he, she, it)";
            this.luileili.UseVisualStyleBackColor = true;
            this.luileili.CheckedChanged += new System.EventHandler(this.conjugationChanges);
            // 
            // io
            // 
            this.io.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.io.AutoSize = true;
            this.io.Location = new System.Drawing.Point(3, 3);
            this.io.Name = "io";
            this.io.Size = new System.Drawing.Size(188, 59);
            this.io.TabIndex = 0;
            this.io.TabStop = true;
            this.io.Tag = "io";
            this.io.Text = "io (I)";
            this.io.UseVisualStyleBackColor = true;
            this.io.CheckedChanged += new System.EventHandler(this.conjugationChanges);
            // 
            // tu
            // 
            this.tu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tu.AutoSize = true;
            this.tu.Location = new System.Drawing.Point(3, 68);
            this.tu.Name = "tu";
            this.tu.Size = new System.Drawing.Size(188, 59);
            this.tu.TabIndex = 1;
            this.tu.TabStop = true;
            this.tu.Tag = "tu";
            this.tu.Text = "tu (you, singular)";
            this.tu.UseVisualStyleBackColor = true;
            this.tu.CheckedChanged += new System.EventHandler(this.conjugationChanges);
            // 
            // noi
            // 
            this.noi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noi.AutoSize = true;
            this.noi.Location = new System.Drawing.Point(197, 3);
            this.noi.Name = "noi";
            this.noi.Size = new System.Drawing.Size(188, 59);
            this.noi.TabIndex = 2;
            this.noi.TabStop = true;
            this.noi.Tag = "noi";
            this.noi.Text = "noi (we)";
            this.noi.UseVisualStyleBackColor = true;
            this.noi.CheckedChanged += new System.EventHandler(this.conjugationChanges);
            // 
            // voi
            // 
            this.voi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.voi.AutoSize = true;
            this.voi.Location = new System.Drawing.Point(197, 68);
            this.voi.Name = "voi";
            this.voi.Size = new System.Drawing.Size(188, 59);
            this.voi.TabIndex = 4;
            this.voi.TabStop = true;
            this.voi.Tag = "voi";
            this.voi.Text = "voi (you, plural)";
            this.voi.UseVisualStyleBackColor = true;
            this.voi.CheckedChanged += new System.EventHandler(this.conjugationChanges);
            // 
            // loro
            // 
            this.loro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loro.AutoSize = true;
            this.loro.Location = new System.Drawing.Point(197, 133);
            this.loro.Name = "loro";
            this.loro.Size = new System.Drawing.Size(188, 61);
            this.loro.TabIndex = 5;
            this.loro.TabStop = true;
            this.loro.Tag = "loro";
            this.loro.Text = "loro (they)";
            this.loro.UseVisualStyleBackColor = true;
            this.loro.CheckedChanged += new System.EventHandler(this.conjugationChanges);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox4, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.verbGroup, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Black;
            this.groupBox4.Controls.Add(this.tenseListBox);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox4.Location = new System.Drawing.Point(403, 228);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(394, 219);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tense";
            // 
            // tenseListBox
            // 
            this.tenseListBox.BackColor = System.Drawing.Color.Black;
            this.tenseListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tenseListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tenseListBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tenseListBox.FormattingEnabled = true;
            this.tenseListBox.ItemHeight = 15;
            this.tenseListBox.Items.AddRange(new object[] {
            "Normal",
            "Past",
            "Present"});
            this.tenseListBox.Location = new System.Drawing.Point(3, 19);
            this.tenseListBox.Name = "tenseListBox";
            this.tenseListBox.Size = new System.Drawing.Size(388, 197);
            this.tenseListBox.TabIndex = 0;
            this.tenseListBox.SelectedValueChanged += new System.EventHandler(this.tenseChanges);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Black;
            this.groupBox3.Controls.Add(this.resultsBox);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Location = new System.Drawing.Point(403, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(394, 219);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Results";
            // 
            // resultsBox
            // 
            this.resultsBox.BackColor = System.Drawing.Color.DimGray;
            this.resultsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.resultsBox.Location = new System.Drawing.Point(3, 19);
            this.resultsBox.Multiline = true;
            this.resultsBox.Name = "resultsBox";
            this.resultsBox.ReadOnly = true;
            this.resultsBox.Size = new System.Drawing.Size(388, 197);
            this.resultsBox.TabIndex = 0;
            // 
            // verbLayoutPanel
            // 
            this.verbLayoutPanel.AutoScroll = true;
            this.verbLayoutPanel.Controls.Add(this.checkBox1);
            this.verbLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.verbLayoutPanel.Location = new System.Drawing.Point(3, 19);
            this.verbLayoutPanel.Name = "verbLayoutPanel";
            this.verbLayoutPanel.Size = new System.Drawing.Size(388, 197);
            this.verbLayoutPanel.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(203, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Test Check Box (updated on load)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel2);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Italian Verb Conjugator";
            this.verbGroup.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.verbLayoutPanel.ResumeLayout(false);
            this.verbLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox verbGroup;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private RadioButton io;
        private RadioButton tu;
        private RadioButton luileili;
        private RadioButton noi;
        private RadioButton voi;
        private RadioButton loro;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private TextBox resultsBox;
        private ListBox tenseListBox;
        private FlowLayoutPanel verbLayoutPanel;
        private CheckBox checkBox1;
    }
}