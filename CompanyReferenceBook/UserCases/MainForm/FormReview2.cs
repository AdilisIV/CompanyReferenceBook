using CompanyReferenceBook.UserCases.MainForm.Components;
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
using CompanyReferenceBook.UserCases.MainForm.Components.Models;
using System.Data.Common;

namespace CompanyReferenceBook
{
    public partial class MainForm : Form
    {
        SideMenuListBox customListControl;
        int? _menuSelectedIndex = null;
        List<NoteModel> notesList = new List<NoteModel>();

        // Connection
        string path = DbConnection.GetInstance().path;
        SqlConnection con;

        BindingList<SideMenuListItem> _menuBindingList;


        public MainForm()
        {
            InitializeComponent();
            con = new SqlConnection(path);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loadUserNotes();
            displaySideMenu();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        void selectEvent(object sender, EventArgs e)
        {
            //Console.WriteLine(this.customListControl.SelectedIndex.ToString());
            if (this._menuSelectedIndex == null) { return; }
            SideMenuListItem selectedItem = ((sender as SideMenuListBox).SelectedItem as SideMenuListItem);
            if (selectedItem == null)
            {
                return;
            }
            if (selectedItem.Title == "Команда")
            {
                TeamListForm s = new TeamListForm();
                s.Show();
            }

            this._menuSelectedIndex = this.customListControl.SelectedIndex;
            (sender as SideMenuListBox).ClearSelected();
        }


        // private

        private void loadUserNotes()
        {
            string sql = "select * from UserNotes";
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;

            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    int noteIdCol = reader.GetOrdinal("id");
                    int noteTitleCol = reader.GetOrdinal("title");
                    int noteIconCol = reader.GetOrdinal("icon");
                    int noteTextCol = reader.GetOrdinal("note_text");
                    int noteTableCol = reader.GetOrdinal("table_data");

                    while (reader.Read())
                    {
                        NoteModel model = new NoteModel();
                        model.title = reader.IsDBNull(noteTitleCol) ? " " : reader.GetString(noteTitleCol);
                        model.icon = reader.IsDBNull(noteTitleCol) ? " " : reader.GetString(noteIconCol);
                        model.text = reader.IsDBNull(noteTitleCol) ? " " : reader.GetString(noteTextCol);

                        notesList.Add(model);
                    }
                }
            }
            con.Close();
        }

        private void displaySideMenu()
        {
            this.customListControl = new SideMenuListBox();

            customListControl.Name = "SideMenuListBox";
            customListControl.Location = new Point(0, 28);
            customListControl.BorderStyle = BorderStyle.None;
            Size listControlSize = this.sideMenuPanel.Size;
            customListControl.Size = listControlSize;
            customListControl.SelectedIndexChanged += new EventHandler(selectEvent);

            this.sideMenuPanel.Controls.Add(customListControl);
            customListControl.ResumeLayout();

            _menuBindingList = new BindingList<SideMenuListItem>();

            for (int i = 0; i < this.notesList.Count(); i++)
            {
                NoteModel model = this.notesList[i];
                _menuBindingList.Add(new SideMenuListItem { Title = model.title, IconImage = model.icon });
            }

            customListControl.DataSource = _menuBindingList;
            customListControl.ClearSelected();
            this._menuSelectedIndex = 0; // локальная переменная
        }
    }
}
