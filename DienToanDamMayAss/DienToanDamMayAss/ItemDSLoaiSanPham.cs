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
    public partial class ItemDSLoaiSanPham : Form
    {
        LoaiSanPhamTableAdapter _LoaiSanPhamTableAdapter = new LoaiSanPhamTableAdapter();

        public ItemDSLoaiSanPham()
        {
            InitializeComponent();
            DataTable DT = _LoaiSanPhamTableAdapter.GetData();
            dtgLoaiSanPham.DataSource = DT.DefaultView;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ItemChiTietLoaiSanPham frm = new ItemChiTietLoaiSanPham("");
            frm.ShowDialog();
            if(frm.check == true)
            {
                DataTable DT = _LoaiSanPhamTableAdapter.GetData();
                dtgLoaiSanPham.DataSource = DT.DefaultView;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string s = dtgLoaiSanPham.CurrentRow.Cells["MaLoaiSP"].Value.ToString();
            ItemChiTietLoaiSanPham frm = new ItemChiTietLoaiSanPham(s);
            frm.ShowDialog();
            if (frm.check == true)
            {
                DataTable DT = _LoaiSanPhamTableAdapter.GetData();
                dtgLoaiSanPham.DataSource = DT.DefaultView;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
