using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace BigK
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        // Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void AllowDrag(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void keyField_Enter(object sender, EventArgs e)
        {
            if (keyField.Texts == "Key")
            {
                keyField.Texts = "";
            }
        }

        private void keyField_Leave(object sender, EventArgs e)
        {
            if (keyField.Texts == "")
            {
                keyField.Texts = "Key";
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (keyField.Texts == "ok")
            {
                // Close current form
                this.Close();

                // Open main form on new thread
                Thread th = new Thread(openMainForm);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                MessageBox.Show("Invalid Key");
            }
        }

        private void openMainForm(object ojb)
        {
            Application.Run(new Main());
        }
    }
}
