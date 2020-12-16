using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyReferenceBook.Helper
{
    public class EmojiDBHelper
    {
        Dictionary<string, string> emojiDictionary = new Dictionary<string, string>
        {
            {"👯‍♀", "sidemenu-icon-team" },
            {"🎒", "sidemenu-icon-tasks" },
            {"🤷‍♂ ", "sidemenu-icon-ux" },
            {"💬", "sidemenu-icon-meetingNotes" },
            {"👨‍🏫", "sidemenu-icon-reports" },
            {"🚎", "sidemenu-icon-roadmap" },
            {"✍", "sidemenu-icon-insights" }
        };

        public EmojiDBHelper()
        {

        }

        public string getDbEmojiRepresentation(string emoji)
        {
            return emojiDictionary[emoji];
        }

        public string[] getEmojiList()
        {
            return emojiDictionary.Keys.ToArray();
        }
    }
}
