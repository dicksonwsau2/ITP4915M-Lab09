namespace ITP4915M_Lab09
{
    partial class Form1
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
            btnSearch = new Button();
            btnSearchName = new Button();
            txtSearch = new TextBox();
            txtSQL = new TextBox();
            lblSearch = new Label();
            dgvDisplay = new DataGridView();
            btnTotal = new Button();
            lblTotal = new Label();
            menuStrip1 = new MenuStrip();
            mnuDemos = new ToolStripMenuItem();
            mnuDataset = new ToolStripMenuItem();
            mnuFilterDept = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvDisplay).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(444, 295);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(169, 23);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search by Lastname";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnSearchName
            // 
            btnSearchName.Location = new Point(619, 295);
            btnSearchName.Name = "btnSearchName";
            btnSearchName.Size = new Size(169, 23);
            btnSearchName.TabIndex = 2;
            btnSearchName.Text = "Search by Name";
            btnSearchName.UseVisualStyleBackColor = true;
            btnSearchName.Click += btnSearchName_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 296);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(426, 23);
            txtSearch.TabIndex = 3;
            // 
            // txtSQL
            // 
            txtSQL.BackColor = SystemColors.Info;
            txtSQL.Location = new Point(12, 325);
            txtSQL.Name = "txtSQL";
            txtSQL.ReadOnly = true;
            txtSQL.Size = new Size(776, 23);
            txtSQL.TabIndex = 4;
            txtSQL.Text = "Your Search String is :";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(12, 278);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(270, 15);
            lblSearch.TabIndex = 5;
            lblSearch.Text = "Please enter the name and click the Search button";
            // 
            // dgvDisplay
            // 
            dgvDisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDisplay.Location = new Point(12, 22);
            dgvDisplay.Name = "dgvDisplay";
            dgvDisplay.Size = new Size(776, 224);
            dgvDisplay.TabIndex = 6;
            // 
            // btnTotal
            // 
            btnTotal.Location = new Point(12, 354);
            btnTotal.Name = "btnTotal";
            btnTotal.Size = new Size(209, 23);
            btnTotal.TabIndex = 7;
            btnTotal.Text = "Find Total Salary";
            btnTotal.UseVisualStyleBackColor = true;
            btnTotal.Click += btnTotal_Click;
            // 
            // lblTotal
            // 
            lblTotal.BackColor = SystemColors.Info;
            lblTotal.BorderStyle = BorderStyle.Fixed3D;
            lblTotal.Location = new Point(227, 354);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(561, 23);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "Total salary of the staff is : ";
            lblTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuDemos });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuDemos
            // 
            mnuDemos.DropDownItems.AddRange(new ToolStripItem[] { mnuDataset, mnuFilterDept });
            mnuDemos.Name = "mnuDemos";
            mnuDemos.Size = new Size(56, 20);
            mnuDemos.Text = "Demos";
            // 
            // mnuDataset
            // 
            mnuDataset.Name = "mnuDataset";
            mnuDataset.Size = new Size(182, 22);
            mnuDataset.Text = "Dataset Search";
            mnuDataset.Click += mnuDataset_Click;
            // 
            // mnuFilterDept
            // 
            mnuFilterDept.Name = "mnuFilterDept";
            mnuFilterDept.Size = new Size(182, 22);
            mnuFilterDept.Text = "Filter by Department";
            mnuFilterDept.Click += mnuFilterDept_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 434);
            Controls.Add(lblTotal);
            Controls.Add(btnTotal);
            Controls.Add(dgvDisplay);
            Controls.Add(lblSearch);
            Controls.Add(txtSQL);
            Controls.Add(txtSearch);
            Controls.Add(btnSearchName);
            Controls.Add(btnSearch);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(816, 473);
            Name = "Form1";
            Text = "Searching a database by a DataAdapter";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDisplay).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private Button btnSearchName;
        private TextBox txtSearch;
        private TextBox txtSQL;
        private Label lblSearch;
        private DataGridView dgvDisplay;
        private Button btnTotal;
        private Label lblTotal;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuDemos;
        private ToolStripMenuItem mnuDataset;
        private ToolStripMenuItem mnuFilterDept;
    }
}
