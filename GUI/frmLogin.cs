using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Entities;
using BUS;
using System.Threading;

namespace GUI
{
    public partial class frmLogin : Form
    {
        private bool is__show = false;
        private EmployerBUS employerBUS;
        private List<Employer> employers;
        public frmLogin()
        {
            employerBUS = new EmployerBUS();
            InitializeComponent();
            this.Load += FrmLogin_Load;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            employers = new List<Employer>();
            employers = employerBUS.GetAll();
        }

        private Employer GetEmployerByUsername(string username)
        {
            return employers.FirstOrDefault(x => x.EmployerUserName == username);
        }

        private Employer CheckUser()
        {
            Employer user = GetEmployerByUsername(txt__username.Text);

            if(user == null)
            {
                throw new Exception("Không tìm thấy tài khoản!");
            }

            
            if(user.EmployerPassword != txt__password.Text)
            {
                throw new Exception("Mật khẩu không chính xác!");
            }
            return user;
        }

        private void btn__login_Click(object sender, EventArgs e)
        {
            try
            {
                var user = CheckUser();
                switch (user.EmployerRole)
                {
                    case 0:
                        this.Hide();
                        frm__client client = new frm__client();
                        client.ShowDialog();
                        break;
                    case 1:
                        this.Hide();
                        frm__admin admin = new frm__admin();
                        admin.ShowDialog();
                        break;
                    default:
                        throw new Exception("Chưa cập nhật giao diện cho công việc của bạn!");
                }
            }catch(Exception ex)
            {
                Alert(ex.Message, frm__alert.AlertType.Error);
            }
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

        public void Alert(string msg, frm__alert.AlertType type)
        {
            Thread aleart = new Thread(new ThreadStart(() => Application.Run(new frm__alert(msg, type))));
            aleart.Start();
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
