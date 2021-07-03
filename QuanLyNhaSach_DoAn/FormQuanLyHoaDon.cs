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
    public partial class FormQuanLyHoaDon : Form
    {
        XuLy dt = new XuLy();

        public FormQuanLyHoaDon()
        {
            InitializeComponent();
        }

        public string _textbox1
        {
            set { lbltenuser.Text = value; }
        }

        private void FormQuanLyHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void datadshd_SelectionChanged(object sender, EventArgs e)
        {
            if (datagridViewDSHD.CurrentCell != null)
            {
                btnXoa.Enabled = true;
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            datagridViewDSHD.ClearSelection();
            dt.SearchQLHD(datagridViewDSHD, txtSearch.Text);
        }

        private void FormQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            datagridViewDSHD.DataSource = dt.LoadThemHD();
            dt.DataBlindsHD(dt.LoadThemHD(), lblHDChon);
            lbltonghd.Text = dt.tonghd(datagridViewDSHD).ToString();
            lbldoanhthu.Text = dt.tongdoanhthu(datagridViewDSHD).ToString();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (dt.XoaHD(datagridViewDSHD, lblHDChon.Text) == true)
            {
                dt.LuuHD();
                MessageBox.Show("Đã xóa hóa đơn");
                lbltonghd.Text = dt.tonghd(datagridViewDSHD).ToString();
                lbldoanhthu.Text = dt.tongdoanhthu(datagridViewDSHD).ToString();
            }
        }
    }
}
