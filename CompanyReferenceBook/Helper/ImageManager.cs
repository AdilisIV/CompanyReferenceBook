using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CompanyReferenceBook.Helper
{
    static class ImageManager
    {
        public static readonly Image iconTeam = Properties.Resources.sidemenu_icon_team_2x;
        public static readonly Image iconInsights = Properties.Resources.sidemenu_icon_insights_2x;
        public static readonly Image iconMeetingNotes = Properties.Resources.sidemenu_icon_meetingNotes_2x;
        public static readonly Image iconReports = Properties.Resources.sidemenu_icon_reports_2x;
        public static readonly Image iconRoadmap = Properties.Resources.sidemenu_icon_roadmap_2x;
        public static readonly Image iconTasks = Properties.Resources.sidemenu_icon_tasks_2x;
        public static readonly Image iconUX = Properties.Resources.sidemenu_icon_ux_2x;


        internal static Image getImage(string name)
        {
            if (name == "sidemenu-icon-team")
            {
                return iconTeam;
            }
            else if (name == "sidemenu-icon-insights")
            {
                return iconInsights;
            }
            else if (name == "sidemenu-icon-meetingNotes")
            {
                return iconMeetingNotes;
            }
            else if (name == "sidemenu-icon-reports")
            {
                return iconReports;
            }
            else if (name == "sidemenu-icon-roadmap")
            {
                return iconRoadmap;
            }
            else if (name == "sidemenu-icon-tasks")
            {
                return iconTasks;
            }
            else if (name == "sidemenu-icon-ux")
            {
                return iconUX;
            } else
            {
                return iconTeam; // default
            }
        }
    }
}
