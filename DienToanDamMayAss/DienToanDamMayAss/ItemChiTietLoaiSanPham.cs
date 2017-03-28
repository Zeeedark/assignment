using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DienToanDamMayAss.DBTableAdapters;
using System.Data;

namespace DienToanDamMayAss
{
    public partial class ItemChiTietLoaiSanPham : Form
    {
        LoaiSanPhamTableAdapter _LoaiSanPhamTableAdapter = new LoaiSanPhamTableAdapter();
        string _maloaisp = "";
        public bool check = false;
        public ItemChiTietLoaiSanPham(string maloaisp)
        {
            InitializeComponent();
            _maloaisp = maloaisp;
            if (!string.IsNullOrEmpty(maloaisp))
            {
                DataRow row = _LoaiSanPhamTableAdapter.GetDataByMaloaiSanPham(maloaisp).FirstOrDefault();
                if (row != null)
                {
                    txtMaLoaiSP.Text = row["MaLoaiSP"].ToString();
                    txtTenLoaiSP.Text = row["TenLoaiSP"].ToString();
                    txtGhiChu.Text = row["GhiChu"].ToString();
                }
            }
        }

        private void btnLuuLai_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(_maloaisp))
                {
                    DataRow row = _LoaiSanPhamTableAdapter.GetDataByMaloaiSanPham(txtMaLoaiSP.Text).FirstOrDefault();
                    if (row != null)
                    {
                        MessageBox.Show("Ma loai sp da ton tai");
                        return;
                    }
                    _LoaiSanPhamTableAdapter.InsertLoaiSanPham(txtMaLoaiSP.Text, txtTenLoaiSP.Text, txtGhiChu.Text);
                    MessageBox.Show("Them thanh cong");
                    check = true;
                    this.Close();
                }
                else
                {
                    _LoaiSanPhamTableAdapter.UpdateLoaiSanPham(txtTenLoaiSP.Text, txtGhiChu.Text, _maloaisp);
                    MessageBox.Show("Them thanh cong");
                    check = true;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("khong thanh cong" + ex.Message);
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtMaLoaiSP.Clear();
            txtTenLoaiSP.Clear();
            txtGhiChu.Clear();
            _maloaisp = "";
        }
    }
}
