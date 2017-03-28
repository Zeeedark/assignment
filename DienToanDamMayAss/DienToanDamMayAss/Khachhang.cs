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
    public partial class Khachhang : Form
    {
        // Khai Bao
        TB_KhachhangTableAdapter _TB_KhachhangTableAdapter = new TB_KhachhangTableAdapter();

        public Khachhang()
        {
            InitializeComponent();
            // Show Data
            DataTable DT = _TB_KhachhangTableAdapter.GetData();
            dsKhachHang.DataSource = DT.DefaultView;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ItemKhachHang _ItemKhachHang = new ItemKhachHang("");
            _ItemKhachHang.ShowDialog();
            if (_ItemKhachHang.check == true) {
                DataTable DT = _TB_KhachhangTableAdapter.GetData();
                dsKhachHang.DataSource = DT.DefaultView;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string s = dsKhachHang.CurrentRow.Cells["MaKH"].Value.ToString();
            ItemKhachHang _ItemKhachHang = new ItemKhachHang(s);
            _ItemKhachHang.ShowDialog();
            if (_ItemKhachHang.check == true)
            {
                DataTable DT = _TB_KhachhangTableAdapter.GetData();
                dsKhachHang.DataSource = DT.DefaultView;
            }
        }

        private void dsKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
