using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace ITP4915M_Lab09
{
    public partial class Form1 : Form
    {
        // ---------- form-level fields ----------
        private readonly DataTable dt = new DataTable();

        private readonly string connStr =
            $"Provider=Microsoft.ACE.OLEDB.12.0;" +
            $"Data Source={Path.Combine(Application.StartupPath, "Employee.accdb")};" +
            "Persist Security Info=False;";

        public Form1()
        {
            InitializeComponent();
        }

        // ---------- helper to run a query and show results ----------
        private void UpdateGrid(string sqlStr)
        {
            txtSQL.Text = "Your Search String is : " + sqlStr;

            using (OleDbDataAdapter da = new OleDbDataAdapter(sqlStr, connStr))
            {
                dt.Clear();
                da.Fill(dt);
                dgvDisplay.DataSource = dt;
                dgvDisplay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        // ---------- load full table on startup ----------
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateGrid("SELECT * FROM Employees");
        }

        // ---------- “Search by Lastname” ----------
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                MessageBox.Show("Please enter something to search for.");
                return;
            }

            string last = txtSearch.Text.Trim().Replace("'", "''");
            UpdateGrid($"SELECT * FROM Employees WHERE LastName = '{last}'");
        }

        // ---------- “Search by Name” (first + last) ----------
        private void btnSearchName_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                MessageBox.Show("Please enter something to search for.");
                return;
            }

            string name = txtSearch.Text.Trim().Replace("'", "''");
            UpdateGrid($"SELECT * FROM Employees WHERE FirstName + ' ' + LastName LIKE '%{name}%'");
        }

        // (Menu item stub—unused in Part A, safe to ignore or delete)
        private void enterCustomerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        // ---------- “Find Total Salary” ----------
        private void btnTotal_Click(object sender, EventArgs e)
        {
            UpdateGrid("SELECT * FROM Employees");   // reload all rows
            double total = 0;
            foreach (DataRow row in dt.Rows)
                total += Convert.ToDouble(row["Salary"]);
            lblTotal.Text = $"Total salary of the staff is : {total:N}";
        }

        private void mnuDataset_Click(object sender, EventArgs e)
        {
            using (Form2 f = new Form2())
                f.ShowDialog(this);   // modal over Form1
        }

        private void mnuFilterDept_Click(object sender, EventArgs e)
        {
            using (Form3 f = new Form3())
                f.ShowDialog(this);
        }
    }
}
