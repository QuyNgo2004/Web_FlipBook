using BUS;
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
    public partial class Login : Form
    {
        private BUS_Data data = new BUS_Data();
        public bool IsLoggedIn { get; private set; }
        public Login()
        {
            InitializeComponent();
            textBox1.KeyPress += TextBox_KeyPress;
            textBox2.KeyPress += TextBox_KeyPress;

        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra nếu phím được nhấn là phím "Enter"
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Xử lý sự kiện đăng nhập
                LoginProcess();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Hãy chắc chắn rằng bạn muốn thoát khỏi màn hình này !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginProcess();
        }

        private void LoginProcess()
        {
            // Kiểm tra thông tin đăng nhập
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Thực hiện kiểm tra đơn giản, bạn cần thay đổi thành kiểm tra thực tế
            if (username == "admin" && password == "admin")
            {
                // Đăng nhập thành công
                IsLoggedIn = true;
                // Ẩn form đăng nhập và hiển thị form chính
                this.Hide();
                Menu mainForm = new Menu();
                mainForm.Closed += (s, args) => this.Close(); // Đóng ứng dụng khi đóng form chính
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công. Vui lòng kiểm tra lại thông tin đăng nhập.");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (data.Load_Data() == true)
            {
                MessageBox.Show("Connection success!");
            }
            else
            {
                MessageBox.Show("Connection faie!");
                Close();
            }
        }
    }
}
