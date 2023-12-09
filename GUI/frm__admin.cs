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
    public partial class frm__admin : Form
    {
        private Timer timer;
        public frm__admin()
        {
            InitializeComponent();

            // Khởi tạo Timer
            timer = new Timer();
            timer.Interval = 1000; // Đặt khoảng thời gian cập nhật là 1 giây (1000 milliseconds)
            timer.Tick += Timer_Tick;

            // Bắt đầu Timer
            timer.Start();
        }

        private void btn__close_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn thoát chương trình hay không?", "Hệ thống", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            // Gọi hàm để cập nhật thời gian hiện tại mỗi lần Timer đến
            UpdateCurrentDateTime();
        }

        private void UpdateCurrentDateTime()
        {
            // Lấy thời gian hiện tại
            DateTime currentTime = DateTime.Now;

            // Định dạng thời gian theo định dạng mong muốn (ví dụ: "dd/MM/yyyy HH:mm:ss")
            string formattedTime = currentTime.ToString("dd/MM/yyyy HH:mm:ss");

            // Hiển thị thời gian trong Label
            lbl__datetime.Text = formattedTime;
        }
    }
}
