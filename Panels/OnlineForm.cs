using System;
using System.Drawing;
using System.Windows.Forms;

namespace BigK.Panels
{
    public partial class OnlineForm : Form
    {
        CustomTextBox intro = new CustomTextBox();

        public OnlineForm()
        {
            InitializeComponent();
        }

        private void OnlineForm_Load(object sender, EventArgs e)
        {
            Controls.Add(intro);
        }

    }

    public class CustomTextBox : TextBox
    {
        public CustomTextBox()
        {
            SetStyle(ControlStyles.UserPaint, true);
            Size = new Size(560, 342);
            Font = new Font("Souses", 12);
            BorderStyle = BorderStyle.None;
            Location = new Point(12, 12);
            BackColor = Color.FromArgb(32, 32, 32);
            Multiline = true;
            WordWrap = true;
            TextAlign = HorizontalAlignment.Center;
            ForeColor = Color.FromArgb(236, 240, 241);
            Enabled = false;
            Text = "\nWelcome to AstolfoHook Zombies v2.1\n" +
                    "\nYou can attach the tool at any time you'd like\n" +
                    "(recommended to do so after pressing Zombies from the\n" +
                    "main menu)\n\nBe sure to detach the tool or close it before ending the\n" +
                    "game or completing an exfil (just as a safety measure)\n\n" +
                    "Enjoy!\n\n" +
                    "---------- Known issues ----------\n" +
                    "- Enabling thermal turns off godmode\n" +
                    "- Turning off Lobby Godmode turns off host's godmode\n";

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush drawBrush = new SolidBrush(Color.FromArgb(236, 240, 241));

            e.Graphics.DrawString(Text, Font, drawBrush, 0f, 0f);
        }
    }
}
