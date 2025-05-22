namespace ITP4915M_Lab09
{
    partial class Form2
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
            dgvDisplay = new DataGridView();
            lblPrompt = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnSearchName = new Button();
            txtSQL = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDisplay).BeginInit();
            SuspendLayout();
            // 
            // dgvDisplay
            // 
            dgvDisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDisplay.Dock = DockStyle.Top;
            dgvDisplay.Location = new Point(0, 0);
            dgvDisplay.Name = "dgvDisplay";
            dgvDisplay.Size = new Size(1096, 528);
            dgvDisplay.TabIndex = 0;
            // 
            // lblPrompt
            // 
            lblPrompt.AutoSize = true;
            lblPrompt.Location = new Point(12, 542);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(90, 15);
            lblPrompt.TabIndex = 1;
            lblPrompt.Text = "Search keyword";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(108, 538);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(734, 23);
            txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(848, 538);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(115, 23);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search by Rank";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnSearchName
            // 
            btnSearchName.Location = new Point(969, 538);
            btnSearchName.Name = "btnSearchName";
            btnSearchName.Size = new Size(115, 23);
            btnSearchName.TabIndex = 4;
            btnSearchName.Text = "Search by Name";
            btnSearchName.UseVisualStyleBackColor = true;
            btnSearchName.Click += btnSearchName_Click;
            // 
            // txtSQL
            // 
            txtSQL.BackColor = SystemColors.Info;
            txtSQL.Dock = DockStyle.Bottom;
            txtSQL.Location = new Point(0, 576);
            txtSQL.Name = "txtSQL";
            txtSQL.ReadOnly = true;
            txtSQL.Size = new Size(1096, 23);
            txtSQL.TabIndex = 5;
            txtSQL.Text = "Your filter string is : ";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 599);
            Controls.Add(txtSQL);
            Controls.Add(btnSearchName);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblPrompt);
            Controls.Add(dgvDisplay);
            MinimumSize = new Size(1112, 634);
            Name = "Form2";
            Text = "Searching a Dataset";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDisplay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private DataGridView dgvDisplay;
        private Label lblPrompt;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnSearchName;
        private TextBox txtSQL;
    }
}