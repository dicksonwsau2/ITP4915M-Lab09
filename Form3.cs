using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace ITP4915M_Lab09
{
    public partial class Form3 : Form
    {
        // ---------- fields ----------
        private readonly DataTable dt = new DataTable();
        private readonly string connStr =
            $"Provider=Microsoft.ACE.OLEDB.12.0;" +
            $"Data Source={Path.Combine(Application.StartupPath, "Employee.accdb")};" +
            "Persist Security Info=False;";

        public Form3()
        {
            InitializeComponent();
        }

        // ---------- helper to (re)fill dt ----------
        private void FillGrid(string whereClause = "")
        {
            string sql = "SELECT * FROM Employees";
            if (!string.IsNullOrEmpty(whereClause))
                sql += " WHERE " + whereClause;

            using (OleDbDataAdapter da = new OleDbDataAdapter(sql, connStr))
            {
                dt.Clear();
                da.Fill(dt);
                dgvDisplay.DataSource = dt;
            }
        }

        // ---------- load all rows at startup ----------
        private void Form3_Load(object sender, EventArgs e)
        {
            FillGrid();                         // no WHERE clause
            dgvDisplay.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
        }

        // ---------- Search button ----------
        private void btnFill_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDept.Text))
            {
                MessageBox.Show("Type part of a department name first.");
                return;
            }

            // parameterised LIKE
            string kw = txtDept.Text.Trim().Replace("'", "''");
            FillGrid($"DepartmentName LIKE '%{kw}%'");
        }

        // ---------- Reset button ----------
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDept.Clear();
            FillGrid();             // reload all rows
        }
    }
}
