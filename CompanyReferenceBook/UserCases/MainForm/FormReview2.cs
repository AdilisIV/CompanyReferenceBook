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
using CompanyReferenceBook.UserCases.TextNoteForm;
using CompanyReferenceBook.UserCases.AddTextNoteForm;

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
            updateUI();
            loadUserNotes();
            displaySideMenu();
            updateListBoxDataSource();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            // обновление бокового меню из данных бд которые возможно обновились
            Console.WriteLine("MainForm_Activated");
            loadUserNotes();
            updateListBoxDataSource();

            Console.WriteLine("See count of element = " + _menuBindingList.Count());
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addNewPageComboBox.Show();
            addNewPageComboBox.DroppedDown = true;
        }

        private void addNewPageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            addNewPageComboBox.Hide();
            if (addNewPageComboBox.SelectedItem.ToString() == "Пустая страница")
            {
                AddTextNoteForm s = new AddTextNoteForm();
                s.Show();
            } else
            {
                // нужно будет дописать добавление страницы с таблицей...
            }
        }

        void selectEvent(object sender, EventArgs e)
        {
            if (this._menuSelectedIndex == null) { return; }

            SideMenuListItem selectedItem = ((sender as SideMenuListBox).SelectedItem as SideMenuListItem);
            if (selectedItem == null) { return; }

            if (selectedItem.Title == "Команда")
            {
                TeamListForm s = new TeamListForm();
                s.Show();
            } else
            {
                TextNoteForm noteForm = new TextNoteForm(this.notesList[(sender as SideMenuListBox).SelectedIndex]);
                noteForm.Show();
            }

            this._menuSelectedIndex = this.customListControl.SelectedIndex;
            //(sender as SideMenuListBox).ClearSelected();
        }


        // private

        private void Mouse_MoveOut_FromComboBox_With(object sender, EventArgs e)
        {
            addNewPageComboBox.Hide();
        }

        private void updateUI()
        {
            addNewPageComboBox.Hide();
            addNewPageComboBox.Items.Add("Пустая страница");
            addNewPageComboBox.Items.Add("Страница с таблицей");
        }

        private void loadUserNotes()
        {
            this.notesList.Clear();

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
                        int noteId = reader.GetInt32(noteIdCol);
                        NoteModel model = new NoteModel(noteId);
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
            customListControl.DataSource = _menuBindingList;
            customListControl.BindingContext = new BindingContext();
            customListControl.ClearSelected();
            this._menuSelectedIndex = 0; // локальная переменная
        }

        private void updateListBoxDataSource()
        {
            _menuBindingList.Clear();

            for (int i = 0; i < this.notesList.Count(); i++)
            {
                NoteModel model = this.notesList[i];
                _menuBindingList.Add(new SideMenuListItem { Title = model.title, IconImage = model.icon });
            }
        }

    }
}
