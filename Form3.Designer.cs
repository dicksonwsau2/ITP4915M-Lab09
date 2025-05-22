namespace ITP4915M_Lab09
{
    partial class Form3
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
            pnlFilter = new Panel();
            btnReset = new Button();
            btnFill = new Button();
            txtDept = new TextBox();
            lblPrompt = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDisplay).BeginInit();
            pnlFilter.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDisplay
            // 
            dgvDisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDisplay.Dock = DockStyle.Fill;
            dgvDisplay.Location = new Point(0, 0);
            dgvDisplay.Name = "dgvDisplay";
            dgvDisplay.Size = new Size(919, 450);
            dgvDisplay.TabIndex = 0;
            // 
            // pnlFilter
            // 
            pnlFilter.Controls.Add(btnReset);
            pnlFilter.Controls.Add(btnFill);
            pnlFilter.Controls.Add(txtDept);
            pnlFilter.Controls.Add(lblPrompt);
            pnlFilter.Dock = DockStyle.Bottom;
            pnlFilter.Location = new Point(0, 410);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Padding = new Padding(6);
            pnlFilter.Size = new Size(919, 40);
            pnlFilter.TabIndex = 1;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnReset.Location = new Point(835, 9);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 3;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnFill
            // 
            btnFill.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFill.Location = new Point(754, 8);
            btnFill.Name = "btnFill";
            btnFill.Size = new Size(75, 23);
            btnFill.TabIndex = 2;
            btnFill.Text = "Search";
            btnFill.UseVisualStyleBackColor = true;
            btnFill.Click += btnFill_Click;
            // 
            // txtDept
            // 
            txtDept.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDept.Location = new Point(133, 9);
            txtDept.Name = "txtDept";
            txtDept.Size = new Size(615, 23);
            txtDept.TabIndex = 1;
            // 
            // lblPrompt
            // 
            lblPrompt.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPrompt.AutoSize = true;
            lblPrompt.Location = new Point(9, 12);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(118, 15);
            lblPrompt.TabIndex = 0;
            lblPrompt.Text = "Department contains";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 450);
            Controls.Add(pnlFilter);
            Controls.Add(dgvDisplay);
            MaximumSize = new Size(935, 489);
            Name = "Form3";
            Text = "Searching by a filter in a DataAdapter";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDisplay).EndInit();
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDisplay;
        private Panel pnlFilter;
        private Label lblPrompt;
        private Button btnReset;
        private Button btnFill;
        private TextBox txtDept;
    }
}