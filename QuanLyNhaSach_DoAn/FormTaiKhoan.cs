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
    public partial class FormTaiKhoan : Form
    {
        XuLy dt = new XuLy();

        public FormTaiKhoan()
        {
            InitializeComponent();
        }

        public string _textbox1
        {
            set { lbltenuser.Text = value; }
        }

        private void FormQLyNhanVien_Load(object sender, EventArgs e)
        {
            datagridViewQLNV.DataSource = dt.LoadQLNV();
            btnSaThai.Enabled = false;
            dt.DataBlindsNV(dt.LoadQLNV(), lblTenNV);
            txtten.Text = lbltenuser.Text;
            lblTenNV.Visible = false;
            btnSaThai.Enabled = false;
            btnluu.Enabled = false;
            txtten.Enabled = false;
            if (dt.RoleNV(lbltenuser.Text))
            {
                groupBox1.Hide();
            }
        }

        private void dataGridViewqlnv_SelectionChanged(object sender, EventArgs e)
        {
            if (datagridViewQLNV.CurrentCell != null)
            {
                btnSaThai.Enabled = true;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormQLyNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btnsathai_Click(object sender, EventArgs e)
        {
            dt.XoaNV(datagridViewQLNV, lblTenNV.Text);
            btnluu.Enabled = true;
            btnthoat.Enabled = false;
        }

        private void btnthemnv_Click(object sender, EventArgs e)
        {
            dt.ThemNV(datagridViewQLNV);
            btnluu.Enabled = true;
            btnthoat.Enabled = false;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (dt.LuuNV())
            { MessageBox.Show("Lưu thành công !!!"); }
            btnthoat.Enabled = true;
        }

        private void btndoimk_Click(object sender, EventArgs e)
        {
            if (dt.Doimkql(txtten.Text, txtmk.Text, txtnewmk.Text, txtnewmkxn.Text) == true)
            {
                if (dt.LuuQL() == true)
                {
                    MessageBox.Show("Đổi mật khẩu thành công");
                }
            }
            else if (dt.Doimknv(txtten.Text, txtmk.Text, txtnewmk.Text, txtnewmkxn.Text) == true)
            {
                if (dt.LuuNV() == true)
                {
                    MessageBox.Show("Đổi mật khẩu thành công");
                }
            }
        }
    }
}
