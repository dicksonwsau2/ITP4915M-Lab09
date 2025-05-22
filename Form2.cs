using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace ITP4915M_Lab09
{
    public partial class Form2 : Form
    {
        // ---------- fields ----------
        private readonly DataSet ds = new DataSet();
        private readonly BindingSource bsEmployees = new BindingSource();

        private readonly string connStr =
            $"Provider=Microsoft.ACE.OLEDB.12.0;" +
            $"Data Source={Path.Combine(Application.StartupPath, "Employee.accdb")};" +
            "Persist Security Info=False;";

        public Form2()
        {
            InitializeComponent();
        }

        // ---------- load all employees ----------
        private void Form2_Load(object sender, EventArgs e)
        {
            using (OleDbDataAdapter da =
                   new OleDbDataAdapter("SELECT * FROM Employees", connStr))
            {
                da.Fill(ds, "Employees");
            }

            bsEmployees.DataSource = ds.Tables["Employees"];
            dgvDisplay.DataSource = bsEmployees;
            dgvDisplay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        // ---------- Search by Rank (Title) ----------
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                MessageBox.Show("Please type a job title (e.g. Manager).");
                return;
            }

            string filter =
                $"Title = '{txtSearch.Text.Trim().Replace("'", "''")}'";
            bsEmployees.Filter = filter;
            txtSQL.Text = "Your filter string is : " + filter;
        }

        // ---------- Search by Name (First or Last) ----------
        private void btnSearchName_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                MessageBox.Show("Please type part of a name.");
                return;
            }

            string kw = txtSearch.Text.Trim().Replace("'", "''");
            string filter =
                $"LastName LIKE '%{kw}%' OR FirstName LIKE '%{kw}%'";
            bsEmployees.Filter = filter;
            txtSQL.Text = "Your filter string is : " + filter;
        }
    }
}
