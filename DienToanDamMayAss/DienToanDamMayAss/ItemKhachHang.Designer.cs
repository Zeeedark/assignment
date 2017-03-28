namespace DienToanDamMayAss
{
    partial class ItemKhachHang
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
            this.Makh = new System.Windows.Forms.Label();
            this.TenKH = new System.Windows.Forms.Label();
            this.Sdt = new System.Windows.Forms.Label();
            this.diaChi = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Makh
            // 
            this.Makh.AutoSize = true;
            this.Makh.Location = new System.Drawing.Point(24, 13);
            this.Makh.Name = "Makh";
            this.Makh.Size = new System.Drawing.Size(85, 13);
            this.Makh.TabIndex = 0;
            this.Makh.Text = "Ma Khach Hang";
            // 
            // TenKH
            // 
            this.TenKH.AutoSize = true;
            this.TenKH.Location = new System.Drawing.Point(24, 56);
            this.TenKH.Name = "TenKH";
            this.TenKH.Size = new System.Drawing.Size(89, 13);
            this.TenKH.TabIndex = 0;
            this.TenKH.Text = "Ten Khach Hang";
            // 
            // Sdt
            // 
            this.Sdt.AutoSize = true;
            this.Sdt.Location = new System.Drawing.Point(24, 95);
            this.Sdt.Name = "Sdt";
            this.Sdt.Size = new System.Drawing.Size(75, 13);
            this.Sdt.TabIndex = 0;
            this.Sdt.Text = "So Dien Thoai";
            // 
            // diaChi
            // 
            this.diaChi.AutoSize = true;
            this.diaChi.Location = new System.Drawing.Point(24, 128);
            this.diaChi.Name = "diaChi";
            this.diaChi.Size = new System.Drawing.Size(41, 13);
            this.diaChi.TabIndex = 0;
            this.diaChi.Text = "Dia Chi";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(24, 166);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 0;
            this.Email.Text = "Email";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(146, 13);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(270, 20);
            this.txtMaKH.TabIndex = 11;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(146, 49);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(270, 20);
            this.txtTenKH.TabIndex = 10;
            this.txtTenKH.TextChanged += new System.EventHandler(this.txtTenKH_TextChanged);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(146, 88);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(270, 20);
            this.txtSDT.TabIndex = 9;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(146, 121);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(270, 20);
            this.txtDiaChi.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(146, 159);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(270, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // btnLuu
            // 
            this.btnLuu.AutoSize = true;
            this.btnLuu.Location = new System.Drawing.Point(146, 205);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Luu Lai";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(296, 205);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(75, 23);
            this.btnLamLai.TabIndex = 2;
            this.btnLamLai.Text = "Lam Lai";
            this.btnLamLai.UseVisualStyleBackColor = true;
            // 
            // ItemKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 261);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.diaChi);
            this.Controls.Add(this.Sdt);
            this.Controls.Add(this.TenKH);
            this.Controls.Add(this.Makh);
            this.Name = "ItemKhachHang";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Makh;
        private System.Windows.Forms.Label TenKH;
        private System.Windows.Forms.Label Sdt;
        private System.Windows.Forms.Label diaChi;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnLamLai;
    }
}