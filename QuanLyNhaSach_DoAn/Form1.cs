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
    public partial class Form1 : Form
    {
        XuLy dt = new XuLy();

        public Form1()
        {
            InitializeComponent();  
        }

        public string _textbox1
        {
            set { label2.Text = value; }
        }

        public string gettenuser
        {
            get { return label2.Text; }
        }
       
   
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Program.frmDN.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Visible = false ;
            if (dt.RoleNV(label2.Text) == true)
            {
                formquanlyhd.Enabled = false;
                label4.Text = "Chức vụ của bạn: Nhân viên bán hàng";
            }
            else{label4.Text="Chức vụ của bạn: Quản Lý";}                 
        }

        private void formsach_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            FormSach frmsach = new FormSach();
            label2.Text = gettenuser;
            frmsach._textbox1 = gettenuser;            
            frmsach.Show();         
        }

        private void formbanhang_Click(object sender, EventArgs e)
        {
            label2.Visible  = false;
            FormBanHang frmbh = new FormBanHang();
            label2.Text = gettenuser;
            frmbh._textbox1 = gettenuser;          
            frmbh.Show();
        }

        private void formtaikhoan_Click(object sender, EventArgs e)
        {
            label2.Visible   = false;
            FormTaiKhoan frmtk = new FormTaiKhoan();
            label2.Text = gettenuser;
            frmtk._textbox1 = gettenuser;           
            frmtk.Show();
        }

        private void formquanlyhd_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            FormQuanLyHoaDon frmqlhd = new FormQuanLyHoaDon();
            label2.Text = gettenuser;
            frmqlhd._textbox1 = gettenuser;
            frmqlhd.Show();
        }   
    }
}
