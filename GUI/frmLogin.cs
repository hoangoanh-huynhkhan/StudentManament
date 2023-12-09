using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmLogin : Form
    {
        private bool is__show = false;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btn__show_Click(object sender, EventArgs e)
        {
            if (!is__show)
            {
                txt__password.PasswordChar = '\0';
                btn__show.Image = global::GUI.Properties.Resources.hide__1_;
                is__show = true;
            }
            else
            {
                txt__password.PasswordChar = '*';
                is__show = false;
                btn__show.Image = global::GUI.Properties.Resources.show__1_;
            }
        }

        private void txt__password_TextChanged(object sender, EventArgs e)
        {
            if(txt__password.Text.Length != 0)
            {
                btn__show.Visible = true;
            }
            else
            {
                btn__show.Visible = false;
            }
        }

        private void btn__close_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn đóng ứng dụng hay không?", "Hệ thống",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
