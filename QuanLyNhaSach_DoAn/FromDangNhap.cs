using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach_DoAn
{
    public partial class FromDangNhap : Form
    {
        XuLy dt = new XuLy();

        public FromDangNhap()
        {
            InitializeComponent();

        }

        public string _textbox
        {
            get { return txtUsername.Text; }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (dt.KTDNNV(txtUsername.Text, txtPassword.Text) == true || dt.KTDNQL(txtUsername.Text, txtPassword.Text) == true)
            {
                Program.frmMain = new Form1();
                Program.frmMain._textbox1 = _textbox;
                Program.frmMain.Show();
                Program.frmDN.Hide();
            }
            else
            {
                MessageBox.Show("Sai ten dang nhap hoac mat khau!");
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(ctr, "Tên đăng nhập không được trống!");
            else
                this.errorProvider1.Clear();
        }

        private void FromDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(ctr, "Yêu cầu nhập mật khẩu!");
            else
                this.errorProvider1.Clear();
        }
    }
}
