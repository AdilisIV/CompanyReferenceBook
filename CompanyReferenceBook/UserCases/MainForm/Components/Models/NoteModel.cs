using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyReferenceBook.UserCases.MainForm.Components.Models
{

    public class NoteModel
    {
        public int id;
        public string title;
        public string icon;
        public string text;
        public string tableData;

        public NoteModel(int id, string title, string icon)
        {
            this.id = id;
            this.title = title;
            this.icon = icon;
            this.text = "";
            this.tableData = "";
        }

        public NoteModel(int id, string title, string icon, string text)
        {
            this.id = id;
            this.title = title;
            this.icon = icon;
            this.text = text;
        }

        public NoteModel(int id)
        {
            this.id = id;
            this.title = "";
            this.icon = "";
            this.text = "";
            this.tableData = "";
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {title}  Icon: {icon}  Text: {text}  TableData: {tableData}");
        }
    }
}
