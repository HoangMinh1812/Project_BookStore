using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace QuanLyNhaSach_DoAn
{
    public class XuLy
    {
        SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-Q47SI2A\\SQLEXPRESS2012;Initial Catalog=QL_NHASACH;User ID=sa;Password=sa2012");
        DataSet ds_QLNS = new DataSet();
        SqlDataAdapter ds_Sach;
        SqlDataAdapter ds_HoaDon;
        SqlDataAdapter ds_qlnv;
        SqlDataAdapter ds_kh;
        SqlDataAdapter ds_ql;
        SqlDataAdapter ds_hoadon1;
        public XuLy()
        {
            //NhanVien
            ds_qlnv = new SqlDataAdapter("select* from NHANVIEN", cnn);
            ds_qlnv.Fill(ds_QLNS, "NHANVIEN");
            DataColumn[] khoachinhnv = new DataColumn[1];
            khoachinhnv[0] = ds_QLNS.Tables["NHANVIEN"].Columns[0];
            ds_QLNS.Tables["NHANVIEN"].PrimaryKey = khoachinhnv;
            //Quan ly
            ds_ql = new SqlDataAdapter("select* from QUANLY", cnn);
            ds_ql.Fill(ds_QLNS, "QUANLY");
            DataColumn[] khoachinhql = new DataColumn[1];
            khoachinhql[0] = ds_QLNS.Tables["QUANLY"].Columns[0];
            ds_QLNS.Tables["QUANLY"].PrimaryKey = khoachinhql;
        }

        public bool KTDNNV(string pTenDN, string pMatKhau)
        {
            try
            {
                DataRow dr_NV = ds_QLNS.Tables["NHANVIEN"].Rows.Find(pTenDN);
                if (dr_NV == null)
                    return false;
                else
                {
                    if (dr_NV["matkhau"].ToString().Trim() == pMatKhau)
                        return true;
                    else
                        return false;
                }
            }
            catch { return false; }
        }

        public bool KTDNQL(string pTenDN, string pMatKhau)
        {
            try
            {
                DataRow dr_QL = ds_QLNS.Tables["QUANLY"].Rows.Find(pTenDN);
                if (dr_QL == null)
                    return false;
                else
                {
                    if (dr_QL["matkhau"].ToString().Trim() == pMatKhau)
                        return true;
                    else
                        return false;
                }
            }
            catch { return false; }
        }

        public bool RoleNV(string ten)
        {
            DataRow dr_checknv = ds_QLNS.Tables["NHANVIEN"].Rows.Find(ten);
            if (dr_checknv != null)
                return true;
            else
                return false;
        }

        public bool RoleQL(string ten)
        {
            DataRow dr_checkql = ds_QLNS.Tables["QUANLY"].Rows.Find(ten);
            if (dr_checkql != null)
                return true;
            else
                return false;
        }

        //form SACH
        public DataTable LoadChuDe()
        {
            SqlDataAdapter ds_Chude = new SqlDataAdapter("select *from CHUDE", cnn);
            ds_Chude.Fill(ds_QLNS, "CHUDE");
            return ds_QLNS.Tables["CHUDE"];
        }

        public DataTable LoadNXB()
        {
            SqlDataAdapter ds_nxb = new SqlDataAdapter("select *from NHAXUATBAN", cnn);
            ds_nxb.Fill(ds_QLNS, "NHAXUATBAN");
            return ds_QLNS.Tables["NHAXUATBAN"];
        }

        public DataTable LoadTG()
        {
            SqlDataAdapter ds_tg = new SqlDataAdapter("select *from TACGIA", cnn);
            ds_tg.Fill(ds_QLNS, "TACGIA");
            return ds_QLNS.Tables["TACGIA"];
        }

        public DataTable LoadSach()
        {
            ds_Sach = new SqlDataAdapter("select * from SACH", cnn);
            ds_Sach.Fill(ds_QLNS, "SACH");
            DataColumn[] khoachinhsach = new DataColumn[1];
            khoachinhsach[0] = ds_QLNS.Tables["SACH"].Columns[0];
            ds_QLNS.Tables["SACH"].PrimaryKey = khoachinhsach;
            return ds_QLNS.Tables["SACH"];
        }

        public void DataBlindsSach(DataTable pDT, Label pMa, Label pTen, Label pGia, Label pSl, Label pMoTa)
        {
            pMa.DataBindings.Clear();
            pTen.DataBindings.Clear();
            pGia.DataBindings.Clear();
            pSl.DataBindings.Clear();
            pMoTa.DataBindings.Clear();

            pMa.DataBindings.Add("Text", pDT, "masach");
            pTen.DataBindings.Add("Text", pDT, "tensach");
            pGia.DataBindings.Add("Text", pDT, "gia");
            pSl.DataBindings.Add("Text", pDT, "soluong");
            pMoTa.DataBindings.Add("Text", pDT, "mota");
        }

        public void Search(DataGridView pdg, string timkiem, RadioButton ma, RadioButton ten)
        {
            if (ma.Checked == true)
            {
                foreach (DataGridViewRow row in pdg.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(timkiem))
                    {
                        pdg.Rows[row.Index].Selected = true;
                        break;
                    }
                }
            }
            else if (ten.Checked == true)
            {
                foreach (DataGridViewRow row in pdg.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(timkiem))
                    {
                        pdg.Rows[row.Index].Selected = true;
                        break;
                    }
                }
            }
        }

        public void Them(DataGridView pdg)
        {
            pdg.AllowUserToAddRows = true;
            pdg.ReadOnly = false;
            //khong dc sua cac dong tren datagirdView da co du lieu
            for (int i = 0; i < pdg.Rows.Count - 1; i++)
            {
                pdg.Rows[i].ReadOnly = true;
            }
            pdg.FirstDisplayedScrollingRowIndex = pdg.Rows.Count - 1;
        }

        public bool LuuSach()
        {
            try
            {
                SqlDataAdapter dsSachluu = new SqlDataAdapter("select*from SACH", cnn);
                SqlCommandBuilder build = new SqlCommandBuilder(dsSachluu);
                dsSachluu.Update(ds_QLNS, "SACH");
                return true;
            }
            catch { return false; }
        }

        public bool Xoa(DataGridView pdg, string pMa)
        {
            pdg.ReadOnly = false;
            try
            {
                DataRow dr_xoasach = ds_QLNS.Tables["SACH"].Rows.Find(pMa);
                if (dr_xoasach != null)
                {
                    dr_xoasach.Delete();
                }
                return true;
            }
            catch { return false; }
        }

        public void SuaSach(DataGridView pdg, string tenuser)
        {
            pdg.ReadOnly = false;
            for (int i = 0; i < pdg.Rows.Count - 1; i++)
            {
                pdg.Rows[i].ReadOnly = false;
            }
            if (RoleQL(tenuser))
            {
                pdg.Columns[0].ReadOnly = true;
            }
            else
            {
                pdg.Columns[0].ReadOnly = true;
                pdg.Columns[2].ReadOnly = true;
                pdg.Columns[3].ReadOnly = true;
            }
            pdg.AllowUserToAddRows = false;
        }

        //Form ban hang
        public DataTable LoadSP()
        {
            SqlDataAdapter ds_SPsach = new SqlDataAdapter("select masach,tensach,gia from SACH", cnn);
            ds_SPsach.Fill(ds_QLNS, "SACH");
            return ds_QLNS.Tables["SACH"];
        }

        public DataTable LoadThemHD()
        {
            ds_hoadon1 = new SqlDataAdapter("select * from HOADON", cnn);
            ds_hoadon1.Fill(ds_QLNS, "HOADON");
            DataColumn[] khoachinhhd = new DataColumn[1];
            khoachinhhd[0] = ds_QLNS.Tables["HOADON"].Columns[0];
            ds_QLNS.Tables["HOADON"].PrimaryKey = khoachinhhd;
            return ds_QLNS.Tables["HOADON"];
        }

        public void ThemSPvaoCart(DataGridView pdg, string ma, string ten, string gia)
        {
            string[] row = { ma, ten, gia };
            pdg.Rows.Add(row);
        }

        public int tongtien(DataGridView pdg)
        {
            int thanhtien = 0;
            for (int i = 0; i < pdg.Rows.Count; i++)
            {
                thanhtien += int.Parse(pdg.Rows[i].Cells[2].Value.ToString());
            }
            return thanhtien;
        }

        public void DataBlindsSPSACH(DataTable pDT, TextBox pMa, TextBox pten, TextBox gia)
        {
            pMa.DataBindings.Clear();
            pten.DataBindings.Clear();
            gia.DataBindings.Clear();

            pMa.DataBindings.Add("Text", pDT, "masach");
            pten.DataBindings.Add("Text", pDT, "tensach");
            gia.DataBindings.Add("Text", pDT, "gia");

        }

        public void SearchSPHD(DataGridView pdg, string timkiem, RadioButton ma, RadioButton ten)
        {
            if (ma.Checked == true)
            {
                foreach (DataGridViewRow row in pdg.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(timkiem))
                    {
                        pdg.Rows[row.Index].Selected = true;
                        break;
                    }
                }
            }
            else if (ten.Checked == true)
            {
                foreach (DataGridViewRow row in pdg.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(timkiem))
                    {
                        pdg.Rows[row.Index].Selected = true;
                        break;
                    }
                }
            }
        }

        public int RandomMa(DataGridView pdg)
        {
            Random rd = new Random();
            int ma = rd.Next(1, 10000);
            foreach (DataGridViewRow row in pdg.Rows)
            {
                if (String.Compare(row.Cells[0].Value.ToString(), ma.ToString(), true) == 0)
                {
                    ma = rd.Next(1, 10000);
                }
            }
            return ma;
        }

        public bool ThemHD(string mahd, string tennv, string khach, string ngay, string tongtien)
        {
            try
            {
                DataRow dr_themhd = ds_QLNS.Tables["HOADON"].NewRow();
                dr_themhd["mahd"] = mahd;
                dr_themhd["nguoiban"] = tennv;
                dr_themhd["khachmua"] = khach;
                dr_themhd["ngaymua"] = ngay;
                dr_themhd["tongtien"] = tongtien;
                ds_QLNS.Tables["HOADON"].Rows.Add(dr_themhd);
                return true;
            }
            catch { return false; }
        }

        public bool LuuHD()
        {
            try
            {
                SqlDataAdapter dsluuhd = new SqlDataAdapter("select*from HOADON", cnn);
                SqlCommandBuilder build = new SqlCommandBuilder(dsluuhd);
                dsluuhd.Update(ds_QLNS, "HOADON");
                return true;
            }
            catch { return false; }
        }

        //Form Tài khoản
        public DataTable LoadQLNV()
        {
            ds_qlnv = new SqlDataAdapter("select* from NHANVIEN", cnn);
            ds_qlnv.Fill(ds_QLNS, "NHANVIEN");
            DataColumn[] khoachinhnv = new DataColumn[1];
            khoachinhnv[0] = ds_QLNS.Tables["NHANVIEN"].Columns[0];
            ds_QLNS.Tables["NHANVIEN"].PrimaryKey = khoachinhnv;
            return ds_QLNS.Tables["NHANVIEN"];
        }

        public void ThemNV(DataGridView pdg)
        {
            pdg.AllowUserToAddRows = true;
            pdg.ReadOnly = false;
            //khong dc sua cac dong tren datagirdView da co du lieu
            for (int i = 0; i < pdg.Rows.Count - 1; i++)
            {
                pdg.Rows[i].ReadOnly = true;
            }
            pdg.FirstDisplayedScrollingRowIndex = pdg.Rows.Count - 1;
        }

        public bool XoaNV(DataGridView pdg, string ptentk)
        {
            pdg.ReadOnly = false;
            try
            {
                DataRow dr_xoanv = ds_QLNS.Tables["NHANVIEN"].Rows.Find(ptentk);
                if (dr_xoanv != null)
                {
                    dr_xoanv.Delete();
                }
                return true;
            }
            catch { return false; }
        }

        public bool Doimkql(string ten, string mkht, string mkmoi, string mkmoi2)
        {
            try
            {
                DataRow dr_doiql = ds_QLNS.Tables["QUANLY"].Rows.Find(ten);
                if (dr_doiql != null)
                {
                    if (dr_doiql["matkhau"].ToString().Trim() == mkht)
                    {
                        if (String.Compare(mkmoi, mkmoi2, true) == 0)
                        {
                            dr_doiql["matkhau"] = mkmoi;
                            return true;
                        }
                        else
                            return false;
                    }
                    else
                        return false;
                }
                else
                    return false;
            }
            catch { return false; }
        }

        public bool Doimknv(string ten, string mkht, string mkmoi, string mkmoi2)
        {
            try
            {
                DataRow dr_doinv = ds_QLNS.Tables["NHANVIEN"].Rows.Find(ten);
                if (dr_doinv != null)
                {
                    if (dr_doinv["matkhau"].ToString().Trim() == mkht)
                    {
                        if (String.Compare(mkmoi, mkmoi2, true) == 0)
                        {
                            dr_doinv["matkhau"] = mkmoi;
                            return true;
                        }
                        else
                            return false;
                    }
                    else
                        return false;
                }
                else
                    return false;
            }
            catch { return false; }
        }

        public bool LuuQL()
        {
            try
            {
                SqlDataAdapter dsluuql = new SqlDataAdapter("select*from QUANLY", cnn);
                SqlCommandBuilder build = new SqlCommandBuilder(dsluuql);
                dsluuql.Update(ds_QLNS, "QUANLY");
                return true;
            }
            catch { return false; }
        }

        public bool LuuNV()
        {
            try
            {
                SqlDataAdapter dsluunv = new SqlDataAdapter("select*from NHANVIEN", cnn);
                SqlCommandBuilder build = new SqlCommandBuilder(dsluunv);
                dsluunv.Update(ds_QLNS, "NHANVIEN");
                return true;
            }
            catch { return false; }
        }

        public void DataBlindsNV(DataTable pDT, Label tk)
        {
            tk.DataBindings.Clear();
            tk.DataBindings.Add("Text", pDT, "tknhanvien");
        }

        public void SearchNV(DataGridView pdg, string timkiem)
        {
            foreach (DataGridViewRow row in pdg.Rows)
            {
                if (row.Cells[0].Value.ToString().Trim().Equals(timkiem))
                {
                    pdg.Rows[row.Index].Selected = true;
                    break;
                }
            }
        }

        //Form quản lý hóa đơn
        public void SearchQLHD(DataGridView pdg, string timkiem)
        {
            foreach (DataGridViewRow row in pdg.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals(timkiem))
                {
                    pdg.Rows[row.Index].Selected = true;
                    break;
                }
            }
        }

        public void DataBlindsHD(DataTable pDT, Label mahd)
        {
            mahd.DataBindings.Clear();
            mahd.DataBindings.Add("Text", pDT, "mahd");
        }

        public bool XoaHD(DataGridView pdg, string pma)
        {
            pdg.ReadOnly = false;
            try
            {
                DataRow dr_xoahd = ds_QLNS.Tables["HOADON"].Rows.Find(pma);
                if (dr_xoahd != null)
                {
                    dr_xoahd.Delete();
                }
                return true;
            }
            catch { return false; }
        }

        public int tongdoanhthu(DataGridView pdg)
        {
            int doanhthu = 0;
            for (int i = 0; i < pdg.Rows.Count; i++)
            {
                doanhthu += int.Parse(pdg.Rows[i].Cells[4].Value.ToString());
            }
            return doanhthu;
        }

        public int tonghd(DataGridView pdg)
        {
            int tongsohd = pdg.Rows.Count;
            return tongsohd;
        }
    }
}

