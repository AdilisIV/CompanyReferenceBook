using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyReferenceBook.UserCases.MainForm.Components
{
    public partial class SideMenuListBoxControl : ListBox
    {
        public SideMenuListBoxControl()
        {
            InitializeComponent();

            DrawMode = DrawMode.OwnerDrawFixed;
            ItemHeight = 18;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            const TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.VerticalCenter;

            if (e.Index >= 0)
            {
                e.DrawBackground();
                e.Graphics.DrawRectangle(Pens.Red, 2, e.Bounds.Y + 2, 14, 14); // Simulate an icon.

                var textRect = e.Bounds;
                textRect.X += 20;
                textRect.Width -= 20;
                string itemText = DesignMode ? "SideMenuListBoxControl" : Items[e.Index].ToString();
                TextRenderer.DrawText(e.Graphics, itemText, e.Font, textRect, e.ForeColor, flags);
                e.DrawFocusRectangle();
            }
        }
    }
}
