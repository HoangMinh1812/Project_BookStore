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
    public partial class FormSach : Form
    {
        XuLy dt = new XuLy();

        public FormSach()
        {
            InitializeComponent();
        }

        public string _textbox1
        {
            set { lblTenUser.Text = value; }
        }

        private void FormSach_Load(object sender, EventArgs e)
        {
            ((DataGridViewComboBoxColumn)dataGridView1.Columns[5]).DataSource = dt.LoadChuDe();
            ((DataGridViewComboBoxColumn)dataGridView1.Columns[5]).DisplayMember = "tencd";
            ((DataGridViewComboBoxColumn)dataGridView1.Columns[5]).ValueMember = "macd";
            ((DataGridViewComboBoxColumn)dataGridView1.Columns[6]).DataSource = dt.LoadNXB();
            ((DataGridViewComboBoxColumn)dataGridView1.Columns[6]).DisplayMember = "tennxb";
            ((DataGridViewComboBoxColumn)dataGridView1.Columns[6]).ValueMember = "manxb";
            ((DataGridViewComboBoxColumn)dataGridView1.Columns[7]).DataSource = dt.LoadTG();
            ((DataGridViewComboBoxColumn)dataGridView1.Columns[7]).DisplayMember = "tentg";
            ((DataGridViewComboBoxColumn)dataGridView1.Columns[7]).ValueMember = "matg";

            dataGridView1.DataSource = dt.LoadSach();
            dataGridView1.AllowUserToAddRows = false;

            btnInSach.Enabled = false;
            btnLuuSach.Enabled = false;
            btnSuaSach.Enabled = false;
            btnXoaSach.Enabled = false;

            dt.DataBlindsSach(dt.LoadSach(), lblmasach, lblten, lblgia, lblsoluong, lblmota);
            dataGridView1.ClearSelection();

            rdbma.Checked = true;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                if (dt.RoleQL(lblTenUser.Text))
                {
                    btnXoaSach.Enabled = true;
                    btnSuaSach.Enabled = true;
                }
                else if (dt.RoleNV(lblTenUser.Text))
                {
                    btnXoaSach.Enabled = false;
                    btnSuaSach.Enabled = true;
                }
            }
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            dt.Them(dataGridView1);
            btnLuuSach.Enabled = true;
            btnThoat.Enabled = false;
        }

        private void btnLuuSach_Click(object sender, EventArgs e)
        {
            if (dt.LuuSach())
            {
                MessageBox.Show("Lưu thành công");
                btnLuuSach.Enabled = false;
                btnThoat.Enabled = true;
            }
            else
                MessageBox.Show("Lưu thất bại");
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            dt.Xoa(dataGridView1, lblmasach.Text);
            btnThoat.Enabled = false;
            btnLuuSach.Enabled = true;
        }

        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            dt.SuaSach(dataGridView1, lblTenUser.Text);
            btnThoat.Enabled = false;
            btnLuuSach.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSach_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dt.Search(dataGridView1, txtSearch.Text, rdbma, rdbten);
        }
    }
}
