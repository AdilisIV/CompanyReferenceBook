using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CompanyReferenceBook
{
    public partial class TeamListForm : Form
    {
        // chips
        Dictionary<string, string[]> chipsValues = new Dictionary<string, string[]>
        {
            {"#фронтэнд разработчик", new string[] { "frontend","developer", "mobile" } },
            {"#бэкенд разработчик", new string[] { "backend", "developer", "sql" } },
            {"#дизайнер", new string[] { "interface", "designer", "ux/ui" }},
            {"#менеджер", new string[] { "manager","product", "project" }},
            {"#teamlead", new string[] { "team","lead", "developer" }},
            {"#аналитик", new string[] { "analyst","sql", "product" }},
            {"#бизнес", new string[] { "business","manager", "finance" }},
            {"#продажи", new string[] { "sale","saller", "office" }},
            {"#офис менеджер", new string[] { "office","manager", "documents" }}
        };
        string currentSelectedChips = "";

        // Connection
        string path = DbConnection.GetInstance().path;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        System.Data.DataTable dt;

        public TeamListForm()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            display();
        }

        // MARK: - Private Methods

        private void display()
        {
            try
            {
                dt = new System.Data.DataTable();
                con.Open();
                adpt = new SqlDataAdapter("select * from employee", con);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // MARK: - Actions

        private void addButton_Click(object sender, EventArgs e)
        {
            Registration s = new Registration();
            s.Show();
        }

        private void searchField_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Employee_Name like '{0}%' OR Employee_FName like '{0}%' OR Addrss like '{0}%' OR Employee_Desgination like '{0}%'", searchField.Text);
        }

        private void chipsButton_Click(object sender, EventArgs e)
        {
            String btnCaption = (sender as System.Windows.Forms.Button).Text;
            String filterStr = "";
            if (btnCaption == currentSelectedChips)
            {
                filterStr = string.Format("Employee_Desgination like '{0}%'", "");
            } else
            {
                string[] searchStrings = chipsValues[btnCaption];
                filterStr = string.Format("Employee_Desgination like '{0}%' OR Employee_Desgination like '{1}%' OR Employee_Desgination like '{2}%'", searchStrings);
                currentSelectedChips = btnCaption;
            }
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = filterStr;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
