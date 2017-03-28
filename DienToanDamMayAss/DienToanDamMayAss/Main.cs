using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DienToanDamMayAss;

namespace DienToanDamMayAss
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void dSLoaiSanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemDSLoaiSanPham frm = new ItemDSLoaiSanPham();
            frm.ShowDialog();
        }

        private void khacHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Khachhang dskhachhang = new Khachhang();
            dskhachhang.ShowDialog();
        }
    }
}
