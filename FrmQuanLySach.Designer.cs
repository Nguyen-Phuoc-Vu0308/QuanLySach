namespace QuanLySach
{
    partial class FrmQuanLySach
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
            this.gbThongTinSach = new System.Windows.Forms.GroupBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtNamXuatBan = new System.Windows.Forms.TextBox();
            this.txtNhaXuatBan = new System.Windows.Forms.TextBox();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.lblNhaXuatBan = new System.Windows.Forms.Label();
            this.lblNamXuatBan = new System.Windows.Forms.Label();
            this.lblTenTacGia = new System.Windows.Forms.Label();
            this.lblMaSach = new System.Windows.Forms.Label();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.gbThongTinSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbThongTinSach
            // 
            this.gbThongTinSach.Controls.Add(this.txtMaSach);
            this.gbThongTinSach.Controls.Add(this.txtNamXuatBan);
            this.gbThongTinSach.Controls.Add(this.txtNhaXuatBan);
            this.gbThongTinSach.Controls.Add(this.txtTacGia);
            this.gbThongTinSach.Controls.Add(this.txtTenSach);
            this.gbThongTinSach.Controls.Add(this.lblNhaXuatBan);
            this.gbThongTinSach.Controls.Add(this.lblNamXuatBan);
            this.gbThongTinSach.Controls.Add(this.lblTenTacGia);
            this.gbThongTinSach.Controls.Add(this.lblMaSach);
            this.gbThongTinSach.Controls.Add(this.lblTenSach);
            this.gbThongTinSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongTinSach.Location = new System.Drawing.Point(15, 15);
            this.gbThongTinSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbThongTinSach.Name = "gbThongTinSach";
            this.gbThongTinSach.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbThongTinSach.Size = new System.Drawing.Size(742, 442);
            this.gbThongTinSach.TabIndex = 1;
            this.gbThongTinSach.TabStop = false;
            this.gbThongTinSach.Text = "Thông tin sách";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(192, 353);
            this.txtMaSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(351, 30);
            this.txtMaSach.TabIndex = 9;
            this.txtMaSach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDuLieuHopLe_KeyPress);
            // 
            // txtNamXuatBan
            // 
            this.txtNamXuatBan.Location = new System.Drawing.Point(192, 289);
            this.txtNamXuatBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNamXuatBan.Name = "txtNamXuatBan";
            this.txtNamXuatBan.Size = new System.Drawing.Size(186, 30);
            this.txtNamXuatBan.TabIndex = 8;
            this.txtNamXuatBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNamXuatBan_KeyPress);
            // 
            // txtNhaXuatBan
            // 
            this.txtNhaXuatBan.Location = new System.Drawing.Point(192, 224);
            this.txtNhaXuatBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNhaXuatBan.Name = "txtNhaXuatBan";
            this.txtNhaXuatBan.Size = new System.Drawing.Size(462, 30);
            this.txtNhaXuatBan.TabIndex = 7;
            this.txtNhaXuatBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDuLieuHopLe_KeyPress);
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(192, 158);
            this.txtTacGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTacGia.MaxLength = 1000;
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(462, 30);
            this.txtTacGia.TabIndex = 6;
            this.txtTacGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDuLieuHopLe_KeyPress);
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(8, 82);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenSach.MaxLength = 5000;
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(726, 30);
            this.txtTenSach.TabIndex = 5;
            this.txtTenSach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDuLieuHopLe_KeyPress);
            // 
            // lblNhaXuatBan
            // 
            this.lblNhaXuatBan.AutoSize = true;
            this.lblNhaXuatBan.Location = new System.Drawing.Point(2, 230);
            this.lblNhaXuatBan.Name = "lblNhaXuatBan";
            this.lblNhaXuatBan.Size = new System.Drawing.Size(134, 25);
            this.lblNhaXuatBan.TabIndex = 4;
            this.lblNhaXuatBan.Text = "Nhà Xuất Bản";
            // 
            // lblNamXuatBan
            // 
            this.lblNamXuatBan.AutoSize = true;
            this.lblNamXuatBan.Location = new System.Drawing.Point(2, 295);
            this.lblNamXuatBan.Name = "lblNamXuatBan";
            this.lblNamXuatBan.Size = new System.Drawing.Size(139, 25);
            this.lblNamXuatBan.TabIndex = 3;
            this.lblNamXuatBan.Text = "Năm Xuất Bản";
            // 
            // lblTenTacGia
            // 
            this.lblTenTacGia.AutoSize = true;
            this.lblTenTacGia.Location = new System.Drawing.Point(2, 164);
            this.lblTenTacGia.Name = "lblTenTacGia";
            this.lblTenTacGia.Size = new System.Drawing.Size(81, 25);
            this.lblTenTacGia.TabIndex = 2;
            this.lblTenTacGia.Text = "Tác Giả";
            // 
            // lblMaSach
            // 
            this.lblMaSach.AutoSize = true;
            this.lblMaSach.Location = new System.Drawing.Point(2, 356);
            this.lblMaSach.Name = "lblMaSach";
            this.lblMaSach.Size = new System.Drawing.Size(91, 25);
            this.lblMaSach.TabIndex = 1;
            this.lblMaSach.Text = "Mã Sách";
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Location = new System.Drawing.Point(311, 46);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(98, 25);
            this.lblTenSach.TabIndex = 0;
            this.lblTenSach.Text = "Tên Sách";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(22, 490);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 38);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(664, 490);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 38);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(331, 490);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(93, 38);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(842, 15);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(162, 38);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm Kiếm Sách";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // FrmQuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 604);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gbThongTinSach);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmQuanLySach";
            this.Text = "FrmQuanLySach";
            this.gbThongTinSach.ResumeLayout(false);
            this.gbThongTinSach.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbThongTinSach;
        private System.Windows.Forms.Label lblNamXuatBan;
        private System.Windows.Forms.Label lblTenTacGia;
        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label lblNhaXuatBan;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtNamXuatBan;
        private System.Windows.Forms.TextBox txtNhaXuatBan;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTimKiem;
    }
}

