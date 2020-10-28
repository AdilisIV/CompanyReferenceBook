using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyReferenceBook
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        string name;
        string designation;
        int salary;
        string gender;
        string review;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            name = txtName.Text;
            designation = txtDesignation.Text;
            salary = int.Parse(txtSalary.Text);
            gender = rbtnMale.Checked ? "Male" : "Female";
            review = chkGood.Checked ? "Good" : "Very Good";

            display();
        }

        public void display()
        {
            dt.Columns.Add("Name");
            dt.Columns.Add("Designation");
            dt.Columns.Add("Salary");
            dt.Columns.Add("Gender");
            dt.Columns.Add("Review");

            DataRow row = dt.NewRow();
            row[0] = name;
            row[1] = designation;
            row[2] = salary;
            row[3] = gender;
            row[4] = review;

            dt.Rows.Add(row);
            dtDataGridView.DataSource = dt;
        }
    }
}
