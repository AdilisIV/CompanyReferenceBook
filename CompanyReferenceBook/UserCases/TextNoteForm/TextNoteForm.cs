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


namespace CompanyReferenceBook.UserCases.TextNoteForm
{
    public partial class TextNoteForm : Form
    {
        private NoteModel model;
        private EmojiDBHelper emojiHelper;

        // Connection
        string path = DbConnection.GetInstance().path;
        SqlConnection con;


        public TextNoteForm(NoteModel model)
        {
            InitializeComponent();
            emojiComboBox.Hide();
            this.model = model;

            con = new SqlConnection(path);
            emojiHelper = new EmojiDBHelper();
        }

        private void displayUI()
        {
            this.noteIconButton.Image = ImageManager.getImage(model.icon);
            this.txtPageTitle.Text = model.title;
            this.richTextBox.Text = model.text;

            string[] emojiList = emojiHelper.getEmojiList();
            for (int i = 0; i < emojiList.Length; i++)
            {
                emojiComboBox.Items.Add(emojiList[i]);
            }
        }

        private void savePageButton_Click(object sender, EventArgs e)
        {
            updateNoteInDb();
            MessageBox.Show("Еее, герл! Страничка обновлена;-)");
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
            cmd.CommandText = "UPDATE UserNotes SET title=@title, icon=@icon, note_text=@note_text" +
                    " WHERE id=@id";
            cmd.Parameters.AddWithValue("@id", model.id);
            cmd.Parameters.AddWithValue("@title", this.txtPageTitle.Text);
            string emojiRep = getEmojiRep();
            cmd.Parameters.AddWithValue("@icon", emojiRep);
            cmd.Parameters.AddWithValue("@note_text", this.richTextBox.Text);

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private string getEmojiRep()
        {
            string[] emojiList = emojiHelper.getEmojiList();

            string emojiRep;
            if (emojiComboBox.SelectedIndex >= 0) // значение в comboBox было изменено
            {
                string emoji = emojiList[emojiComboBox.SelectedIndex];
                emojiRep = emojiHelper.getDbEmojiRepresentation(emoji);
            } else // значение в comboBox осталось прежним -1 (возьмем тот emoji которые уже установлен для note)
            {
                emojiRep = model.icon;
            }

            return emojiRep;
        }

        private void Mouse_MoveOut_FromComboBox_With(object sender, EventArgs e)
        {
            emojiComboBox.Hide();
        }
    }
}
