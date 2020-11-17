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
    public partial class ComboBox : Form
    {
        public ComboBox()
        {
            InitializeComponent();
        }

        string name;

        private void ComboBox_Load(object sender, EventArgs e)
        {
            cmbCourse.Items.Add(" C# Programming ");
            cmbCourse.Items.Add(" C++ Programming ");
            cmbCourse.Items.Add(" C Programming ");
            cmbCourse.Items.Add(" Java Programming ");
            cmbCourse.Items.Add(" PHP Programming ");
        }

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            name = cmbCourse.SelectedItem.ToString();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show(name);
        }
    }
}
