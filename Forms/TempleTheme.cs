using System.Drawing;

namespace TempleManagementSystem.EventManagement
{
    // Central theme class — all colors match the dark red UI Mesada built
    public static class TempleTheme
    {
        // Colors
        public static readonly Color DarkRed     = Color.FromArgb(139, 0, 0);    // main dark red
        public static readonly Color DarkerRed   = Color.FromArgb(100, 0, 0);    // header / sidebar
        public static readonly Color LightRed    = Color.FromArgb(180, 30, 30);  // button hover
        public static readonly Color White       = Color.White;
        public static readonly Color LightGray   = Color.FromArgb(240, 240, 240);
        public static readonly Color PanelBg     = Color.FromArgb(245, 245, 245);
        public static readonly Color GridHeader  = Color.FromArgb(139, 0, 0);
        public static readonly Color GridRowSel  = Color.FromArgb(180, 30, 30);
        public static readonly Color TextDark    = Color.FromArgb(30, 30, 30);

        // Fonts
        public static readonly Font TitleFont    = new Font("Segoe UI", 20f, FontStyle.Bold);
        public static readonly Font SubtitleFont = new Font("Segoe UI", 11f, FontStyle.Italic);
        public static readonly Font HeadingFont  = new Font("Segoe UI", 13f, FontStyle.Bold);
        public static readonly Font NormalFont   = new Font("Segoe UI", 10f);
        public static readonly Font SmallFont    = new Font("Segoe UI", 9f);
        public static readonly Font ButtonFont   = new Font("Segoe UI", 10f, FontStyle.Bold);

        // Apply standard red button style
        public static void StyleButton(System.Windows.Forms.Button btn)
        {
            btn.BackColor  = DarkRed;
            btn.ForeColor  = White;
            btn.Font       = ButtonFont;
            btn.FlatStyle  = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize  = 0;
            btn.FlatAppearance.MouseOverBackColor = LightRed;
            btn.Cursor     = System.Windows.Forms.Cursors.Hand;
        }

        // Apply DataGridView style matching the UI
        public static void StyleGrid(System.Windows.Forms.DataGridView grid)
        {
            grid.BackgroundColor         = Color.White;
            grid.BorderStyle             = System.Windows.Forms.BorderStyle.None;
            grid.GridColor               = Color.FromArgb(220, 220, 220);
            grid.RowHeadersVisible       = false;
            grid.AllowUserToAddRows      = false;
            grid.AllowUserToDeleteRows   = false;
            grid.ReadOnly                = true;
            grid.SelectionMode           = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            grid.Font                    = SmallFont;
            grid.RowTemplate.Height      = 28;

            // Column headers — dark red like the UI
            grid.ColumnHeadersDefaultCellStyle.BackColor   = DarkRed;
            grid.ColumnHeadersDefaultCellStyle.ForeColor   = White;
            grid.ColumnHeadersDefaultCellStyle.Font        = new Font("Segoe UI", 9f, FontStyle.Bold);
            grid.ColumnHeadersDefaultCellStyle.Alignment   = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            grid.ColumnHeadersHeight     = 32;
            grid.EnableHeadersVisualStyles = false;

            // Row style
            grid.DefaultCellStyle.BackColor     = Color.White;
            grid.DefaultCellStyle.ForeColor     = TextDark;
            grid.DefaultCellStyle.SelectionBackColor = GridRowSel;
            grid.DefaultCellStyle.SelectionForeColor = White;
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(252, 240, 240);
        }
    }
}
