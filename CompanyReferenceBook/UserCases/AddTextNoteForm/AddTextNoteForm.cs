using CompanyReferenceBook.UserCases.MainForm.Components.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompanyReferenceBook.Helper;
using System.Data.SqlClient;

namespace CompanyReferenceBook.UserCases.AddTextNoteForm
{
    public partial class AddTextNoteForm : Form
    {

        private EmojiDBHelper emojiHelper;

        // Connection
        string path = DbConnection.GetInstance().path;
        SqlConnection con;


        public AddTextNoteForm()
        {
            InitializeComponent();

            emojiComboBox.Hide();

            con = new SqlConnection(path);
            emojiHelper = new EmojiDBHelper();
        }

        private void displayUI()
        {
            this.noteIconButton.Image = ImageManager.defaultNoteImage();
            this.txtPageTitle.Text = "Заголовок страницы...";
            this.richTextBox.Text = "Type something...";

            string[] emojiList = emojiHelper.getEmojiList();
            for (int i = 0; i < emojiList.Length; i++)
            {
                emojiComboBox.Items.Add(emojiList[i]);
            }
        }

        private void savePageButton_Click(object sender, EventArgs e)
        {
            updateNoteInDb();
            MessageBox.Show("Еее, бой! Страничка добавлена;-)");
        }

        private void noteIconButton_Click(object sender, EventArgs e)
        {
            emojiComboBox.Show();
            emojiComboBox.DroppedDown = true;
        }

        private void TextNoteForm_Load(object sender, EventArgs e)
        {
            displayUI();
        }

        private void emojiComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            emojiComboBox.Hide();

            string emojiRep = getEmojiRep();

            this.noteIconButton.Image = ImageManager.getImage(emojiRep);
        }

        // private

        private void updateNoteInDb()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO UserNotes (title,icon,note_text,table_data) VALUES (@title,@icon,@note_text,@table_data)";
            cmd.Parameters.AddWithValue("@title", this.txtPageTitle.Text);
            string emojiRep = getEmojiRep();
            cmd.Parameters.AddWithValue("@icon", emojiRep);
            cmd.Parameters.AddWithValue("@note_text", this.richTextBox.Text);
            cmd.Parameters.AddWithValue("@table_data", "");

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private string getEmojiRep()
        {
            string[] emojiList = emojiHelper.getEmojiList();
            int selectedIdx = 0;
            if (emojiComboBox.SelectedIndex >= 0)
            {
                selectedIdx = emojiComboBox.SelectedIndex;
            }
            string emoji = emojiList[selectedIdx];
            string emojiRep = emojiHelper.getDbEmojiRepresentation(emoji);
            return emojiRep;
        }

        private void Mouse_MoveOut_FromComboBox_With(object sender, EventArgs e)
        {
            emojiComboBox.Hide();
        }
    }
}
