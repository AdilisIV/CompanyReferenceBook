using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SideMenuListItem
{
    public string ID;
    public string Title;
    public string IconImage;

    public override string ToString()
    {
        return Title + "," + IconImage;
    }
}
