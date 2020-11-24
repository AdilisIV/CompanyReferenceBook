using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CompanyReferenceBook
{
    public partial class Registration : Form
    {
        //String Connection
        string path = @"Data Source=SAMSUNG\SQLEXPRESS;Initial Catalog=registration;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;

        public Registration()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            display();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text=="" || txtFName.Text=="" || txtDesignation.Text=="" || txtID.Text=="" || txtEmail.Text=="" || txtID.Text=="" || txtAddress.Text=="")
            {
                MessageBox.Show(" Please Fill in the Blanks ");
            }
            else
            {
                try
                {
                    string gender;

                    if (rbtnMale.Checked)
                    {
                        gender = "Male";
                    }
                    else
                    {
                        gender = "Female";
                    }
                    con.Open();
                    cmd = new SqlCommand("insert into Employee (Employee_Name,Employee_FName,Employee_Desgination,Employee_Email,Emp_ID,Gender,Addrss) values ('" + txtName.Text + "','" + txtFName.Text + "','" + txtDesignation.Text + "','" + txtEmail.Text + "','" + txtID.Text + "','" + gender + "','" + txtAddress.Text + "') ", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(" You Data has Been Saved in the Datbase ");
                    clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public void clear()
        {
            txtFName.Text = "";
            txtName.Text = "";
            txtDesignation.Text = "";
            txtEmail.Text = "";
            txtID.Text = "";
            txtAddress.Text = "";
        }

        public void display()
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("select * from employee", con);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();  

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
