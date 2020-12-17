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
    public partial class Login : Form
    {
        string path = DbConnection.GetInstance().path;
        SqlConnection con;
        public Login()
        {
            InitializeComponent();
            con = new SqlConnection(path);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUName.Text=="" && txtPassword.Text=="")
                {
                    MessageBox.Show(" Please Enter User Name and Password");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("select * from LoginUsers where U_Name=@Name and U_Pass=@Pass", con);
                    cmd.Parameters.Add("@Name", txtUName.Text);
                    cmd.Parameters.Add("@Pass", txtPassword.Text);
                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adpt.Fill(ds);

                    int count = ds.Tables[0].Rows.Count;

                    if(count==1)
                    {
                        MessageBox.Show(" You have Successfully Logged In");
                        MainForm ob = new MainForm();
                        this.Hide();
                        ob.Show();
                    }
                    else
                    {
                        MessageBox.Show(" Please Check User Name and Password");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            

            //SqlConnection con=new SqlConnection()

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            New_user_registration om = new New_user_registration();
            this.Hide();
            om.Show();
        }

        private void txtUName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
