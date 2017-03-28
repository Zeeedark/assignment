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

namespace DienToanDamMayAss
{
    public partial class ItemKhachHang : Form
    {
        TB_KhachhangTableAdapter _KhachhangTableAdapter = new TB_KhachhangTableAdapter();
        public bool check = false;
        public string _maKH = null;
        public ItemKhachHang(string maKH)
        {
            _maKH = maKH;
            InitializeComponent();
            txtMaKH.Focus();
            if (!string.IsNullOrEmpty(_maKH))
            {
                DataRow row = _KhachhangTableAdapter.GetDataByMaKhachHang(maKH).FirstOrDefault();
                if (row != null) {
                    txtMaKH.Text = row["MaKH"].ToString();
                    txtTenKH.Text = row["TenKH"].ToString();
                    txtSDT.Text = row["Sdt"].ToString();
                    txtDiaChi.Text = row["DiaChi"].ToString();
                    txtEmail.Text = row["Email"].ToString();
                }
            }
         }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_maKH))
            {
                _KhachhangTableAdapter.InsertKhachHang(txtMaKH.Text, txtTenKH.Text, txtSDT.Text, txtDiaChi.Text, txtEmail.Text);
                check = true;
                MessageBox.Show("Sua Thanh Cong");
            }
            else {
                _KhachhangTableAdapter.UpdateQuery(txtTenKH.Text, txtSDT.Text, txtDiaChi.Text, txtEmail.Text, _maKH);
                check = true;
                MessageBox.Show("Sua Khong thanh Cong");
            }
        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
