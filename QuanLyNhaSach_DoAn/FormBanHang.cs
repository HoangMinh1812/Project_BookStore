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
    public partial class FormBanHang : Form
    {
        XuLy dt = new XuLy();

        public FormBanHang()
        {
            InitializeComponent();
        }
        public string _textbox1
        {
            set { lbltenuser.Text = value; }
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            txtma.Enabled = txtgia.Enabled = txttensach.Enabled = false;
            datagridViewSP.DataSource = dt.LoadSach();
            dt.DataBlindsSPSACH(dt.LoadSach(), txtma, txttensach, txtgia);
            panel1.Hide();
            datahdtest.DataSource = dt.LoadThemHD();
            btnConfirm.Enabled = false;
            lblnguoiban.Text = lbltenuser.Text;
            lblngay.Text = DateTime.Now.ToString();
            btnClear.Enabled = false;
            panel2.Hide();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btncart_Click(object sender, EventArgs e)
        {
            btnConfirm.Enabled = true;
            btnClear.Enabled = true;
            dt.ThemSPvaoCart(datagridViewCart, txtma.Text, txttensach.Text, txtgia.Text);
            lblTongTien.Text = dt.tongtien(datagridViewCart).ToString();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            datagridViewSP.ClearSelection();
            dt.SearchSPHD(datagridViewSP, txtSearch.Text, rdbma, rdbten);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbltienhd.Text = lblTongTien.Text;
            lblsoluongcart.Text = datagridViewCart.Rows.Count.ToString();
            panel1.Show();
            btnClear.Enabled = btnConfirm.Enabled = false;
            btnCart.Enabled = false;
            btnthoat.Enabled = false;
            lblmahd.Text = dt.RandomMa(datahdtest).ToString();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            datagridViewCart.Rows.Clear();
            lblTongTien.Text = "";
            btnConfirm.Enabled = btnClear.Enabled = false;
            btnCart.Enabled = true;
            btnthoat.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            datagridViewCart.Rows.Clear();
            btnConfirm.Enabled = btnClear.Enabled = false;
            lblTongTien.Text = "";
        }

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            if (dt.ThemHD(lblmahd.Text, lblnguoiban.Text, txtkhachmua.Text, lblngay.Text, lbltienhd.Text))
            {
                dt.LuuHD();
                MessageBox.Show("Thanh toán thành công");
            }
            lblTongTien.Text = "";
            panel1.Hide();
            btnCart.Enabled = true;
            datagridViewCart.Rows.Clear();
            btnthoat.Enabled = true;
        }
    }
}
