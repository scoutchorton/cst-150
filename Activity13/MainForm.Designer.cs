namespace Activity13 {
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.x0y0 = new System.Windows.Forms.Label();
            this.x1y0 = new System.Windows.Forms.Label();
            this.x2y0 = new System.Windows.Forms.Label();
            this.x0y1 = new System.Windows.Forms.Label();
            this.x1y1 = new System.Windows.Forms.Label();
            this.x2y1 = new System.Windows.Forms.Label();
            this.x0y2 = new System.Windows.Forms.Label();
            this.x1y2 = new System.Windows.Forms.Label();
            this.x2y2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.x0y0, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.x1y0, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.x2y0, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.x0y1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.x1y1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.x2y1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.x0y2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.x1y2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.x2y2, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1143, 660);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // x0y0
            // 
            this.x0y0.AutoSize = true;
            this.x0y0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.x0y0.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.x0y0.Location = new System.Drawing.Point(3, 0);
            this.x0y0.Name = "x0y0";
            this.x0y0.Size = new System.Drawing.Size(375, 220);
            this.x0y0.TabIndex = 2;
            this.x0y0.Text = "x0y0";
            this.x0y0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.x0y0.Click += new System.EventHandler(this.userTurn);
            // 
            // x1y0
            // 
            this.x1y0.AutoSize = true;
            this.x1y0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.x1y0.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.x1y0.Location = new System.Drawing.Point(384, 0);
            this.x1y0.Name = "x1y0";
            this.x1y0.Size = new System.Drawing.Size(375, 220);
            this.x1y0.TabIndex = 3;
            this.x1y0.Text = "x1y0";
            this.x1y0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.x1y0.Click += new System.EventHandler(this.userTurn);
            // 
            // x2y0
            // 
            this.x2y0.AutoSize = true;
            this.x2y0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.x2y0.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.x2y0.Location = new System.Drawing.Point(765, 0);
            this.x2y0.Name = "x2y0";
            this.x2y0.Size = new System.Drawing.Size(375, 220);
            this.x2y0.TabIndex = 4;
            this.x2y0.Text = "x2y0";
            this.x2y0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.x2y0.Click += new System.EventHandler(this.userTurn);
            // 
            // x0y1
            // 
            this.x0y1.AutoSize = true;
            this.x0y1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.x0y1.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.x0y1.Location = new System.Drawing.Point(3, 220);
            this.x0y1.Name = "x0y1";
            this.x0y1.Size = new System.Drawing.Size(375, 220);
            this.x0y1.TabIndex = 5;
            this.x0y1.Text = "label5";
            this.x0y1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.x0y1.Click += new System.EventHandler(this.userTurn);
            // 
            // x1y1
            // 
            this.x1y1.AutoSize = true;
            this.x1y1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.x1y1.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.x1y1.Location = new System.Drawing.Point(384, 220);
            this.x1y1.Name = "x1y1";
            this.x1y1.Size = new System.Drawing.Size(375, 220);
            this.x1y1.TabIndex = 6;
            this.x1y1.Text = "label6";
            this.x1y1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.x1y1.Click += new System.EventHandler(this.userTurn);
            // 
            // x2y1
            // 
            this.x2y1.AutoSize = true;
            this.x2y1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.x2y1.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.x2y1.Location = new System.Drawing.Point(765, 220);
            this.x2y1.Name = "x2y1";
            this.x2y1.Size = new System.Drawing.Size(375, 220);
            this.x2y1.TabIndex = 7;
            this.x2y1.Text = "label7";
            this.x2y1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.x2y1.Click += new System.EventHandler(this.userTurn);
            // 
            // x0y2
            // 
            this.x0y2.AutoSize = true;
            this.x0y2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.x0y2.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.x0y2.Location = new System.Drawing.Point(3, 440);
            this.x0y2.Name = "x0y2";
            this.x0y2.Size = new System.Drawing.Size(375, 220);
            this.x0y2.TabIndex = 8;
            this.x0y2.Text = "label8";
            this.x0y2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.x0y2.Click += new System.EventHandler(this.userTurn);
            // 
            // x1y2
            // 
            this.x1y2.AutoSize = true;
            this.x1y2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.x1y2.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.x1y2.Location = new System.Drawing.Point(384, 440);
            this.x1y2.Name = "x1y2";
            this.x1y2.Size = new System.Drawing.Size(375, 220);
            this.x1y2.TabIndex = 9;
            this.x1y2.Text = "label9";
            this.x1y2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.x1y2.Click += new System.EventHandler(this.userTurn);
            // 
            // x2y2
            // 
            this.x2y2.AutoSize = true;
            this.x2y2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.x2y2.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.x2y2.Location = new System.Drawing.Point(765, 440);
            this.x2y2.Name = "x2y2";
            this.x2y2.Size = new System.Drawing.Size(375, 220);
            this.x2y2.TabIndex = 10;
            this.x2y2.Text = "label10";
            this.x2y2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.x2y2.Click += new System.EventHandler(this.userTurn);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 633);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1143, 27);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.status.ForeColor = System.Drawing.SystemColors.ControlText;
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(220, 22);
            this.status.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1143, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newGameToolStripMenuItem.Text = "&New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGame);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitGame);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1143, 660);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Tic Tac Toe";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label x0y0;
        private Label x1y0;
        private Label x0y2;
        private Label x2y0;
        private Label x2y2;
        private Label x0y1;
        private Label x1y1;
        private Label x2y1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel status;
        private Label x1y2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
    }
}