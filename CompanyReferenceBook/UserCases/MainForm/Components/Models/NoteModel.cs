using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyReferenceBook.UserCases.MainForm.Components.Models
{

    class NoteModel
    {
        public string title;
        public string icon;
        public string text;
        public string tableData;

        public NoteModel(string title, string icon)
        {
            this.title = title;
            this.icon = icon;
            this.text = "";
            this.tableData = "";
        }

        public NoteModel(string title, string icon, string text)
        {
            this.title = title;
            this.icon = icon;
            this.text = text;
        }

        public NoteModel()
        {
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
