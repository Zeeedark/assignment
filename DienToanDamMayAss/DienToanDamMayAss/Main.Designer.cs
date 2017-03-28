namespace DienToanDamMayAss
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dSLoaiSanPhamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khacHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.db1 = new DienToanDamMayAss.DB();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(628, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dSLoaiSanPhamToolStripMenuItem,
            this.khacHangToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(74, 20);
            this.toolStripMenuItem1.Text = "Danh muc";
            // 
            // dSLoaiSanPhamToolStripMenuItem
            // 
            this.dSLoaiSanPhamToolStripMenuItem.Name = "dSLoaiSanPhamToolStripMenuItem";
            this.dSLoaiSanPhamToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.dSLoaiSanPhamToolStripMenuItem.Text = "Danh Sach Loai San Pham";
            this.dSLoaiSanPhamToolStripMenuItem.Click += new System.EventHandler(this.dSLoaiSanPhamToolStripMenuItem_Click);
            // 
            // khacHangToolStripMenuItem
            // 
            this.khacHangToolStripMenuItem.Name = "khacHangToolStripMenuItem";
            this.khacHangToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.khacHangToolStripMenuItem.Text = "Danh Sach Khach Hang";
            this.khacHangToolStripMenuItem.Click += new System.EventHandler(this.khacHangToolStripMenuItem_Click);
            // 
            // db1
            // 
            this.db1.DataSetName = "DB";
            this.db1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dSLoaiSanPhamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khacHangToolStripMenuItem;
        private DB db1;
    }
}

