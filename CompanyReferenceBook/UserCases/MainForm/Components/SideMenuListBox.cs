using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompanyReferenceBook.Helper;

namespace CompanyReferenceBook.UserCases.MainForm.Components
{
    public class SideMenuListBox: ListBox
    {
        public SideMenuListBox()
        {
            DrawMode = DrawMode.OwnerDrawFixed;
            ItemHeight = 38;
            Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular);
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            const TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.VerticalCenter;

            if (e.Index >= 0)
            {
                e.DrawBackground();

                var textRect = e.Bounds;
                textRect.X += 14 + 24 + 5;
                textRect.Width -= 20;

                SideMenuListItem cellItem = Items[e.Index] as SideMenuListItem;

                string itemText = DesignMode ? "SideMenuListBoxControl" : cellItem.Title;
                TextRenderer.DrawText(e.Graphics, itemText, e.Font, textRect, Color.Gray, flags);

                Rectangle imgRect = new Rectangle(14, e.Bounds.Y + 5, 24, 24);
                Image image = ImageManager.getImage(cellItem.IconImage);
                e.Graphics.DrawImage(image, imgRect);

                e.DrawFocusRectangle();
            }
        }
    }
}
