﻿namespace AppQuanLyKho.View
{
    partial class PhieuXuat
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.tbThanhToan = new System.Windows.Forms.TextBox();
            this.tbTenSP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbDonGia = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbMaSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTenKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDSSP = new System.Windows.Forms.GroupBox();
            this.dataGridViewDSSP = new System.Windows.Forms.DataGridView();
            this.gbTTSP = new System.Windows.Forms.GroupBox();
            this.tbGhiChu = new System.Windows.Forms.TextBox();
            this.tbMaPN = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.dTNgayBan = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMaKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbDSSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSSP)).BeginInit();
            this.gbTTSP.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1077, 452);
            this.flowLayoutPanel1.TabIndex = 41;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.tbTenKH);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.gbDSSP);
            this.panel1.Controls.Add(this.gbTTSP);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 787);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.tbThanhToan);
            this.groupBox1.Controls.Add(this.tbTenSP);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbDonGia);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tbMaSP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbSL);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(28, 325);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(976, 185);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(639, 110);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(251, 35);
            this.btnLuu.TabIndex = 45;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // tbThanhToan
            // 
            this.tbThanhToan.Location = new System.Drawing.Point(679, 69);
            this.tbThanhToan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbThanhToan.Name = "tbThanhToan";
            this.tbThanhToan.ReadOnly = true;
            this.tbThanhToan.Size = new System.Drawing.Size(248, 26);
            this.tbThanhToan.TabIndex = 37;
            this.tbThanhToan.TextChanged += new System.EventHandler(this.tbThanhToan_TextChanged);
            // 
            // tbTenSP
            // 
            this.tbTenSP.Location = new System.Drawing.Point(174, 69);
            this.tbTenSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTenSP.Name = "tbTenSP";
            this.tbTenSP.ReadOnly = true;
            this.tbTenSP.Size = new System.Drawing.Size(198, 26);
            this.tbTenSP.TabIndex = 33;
            this.tbTenSP.Click += new System.EventHandler(this.tbMaSP_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(581, 72);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Thanh toán";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 72);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 20);
            this.label9.TabIndex = 32;
            this.label9.Text = "Tên sản phẩm";
            // 
            // tbDonGia
            // 
            this.tbDonGia.Location = new System.Drawing.Point(174, 114);
            this.tbDonGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDonGia.Name = "tbDonGia";
            this.tbDonGia.ReadOnly = true;
            this.tbDonGia.Size = new System.Drawing.Size(198, 26);
            this.tbDonGia.TabIndex = 31;
            this.tbDonGia.Click += new System.EventHandler(this.tbMaSP_Click);
            this.tbDonGia.TextChanged += new System.EventHandler(this.tbDonGia_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 117);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "Đơn giá";
            // 
            // tbMaSP
            // 
            this.tbMaSP.Location = new System.Drawing.Point(174, 23);
            this.tbMaSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMaSP.Name = "tbMaSP";
            this.tbMaSP.ReadOnly = true;
            this.tbMaSP.Size = new System.Drawing.Size(198, 26);
            this.tbMaSP.TabIndex = 29;
            this.tbMaSP.Click += new System.EventHandler(this.tbMaSP_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Mã sản phẩm";
            // 
            // tbSL
            // 
            this.tbSL.Location = new System.Drawing.Point(681, 23);
            this.tbSL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSL.Name = "tbSL";
            this.tbSL.Size = new System.Drawing.Size(246, 26);
            this.tbSL.TabIndex = 27;
            this.tbSL.TextChanged += new System.EventHandler(this.tbSL_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(581, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Số Lượng";
            // 
            // tbTenKH
            // 
            this.tbTenKH.Location = new System.Drawing.Point(894, 12);
            this.tbTenKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTenKH.Name = "tbTenKH";
            this.tbTenKH.ReadOnly = true;
            this.tbTenKH.Size = new System.Drawing.Size(148, 26);
            this.tbTenKH.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(363, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 50);
            this.label1.TabIndex = 41;
            this.label1.Text = "Phiếu xuất kho";
            // 
            // gbDSSP
            // 
            this.gbDSSP.Controls.Add(this.dataGridViewDSSP);
            this.gbDSSP.Location = new System.Drawing.Point(28, 520);
            this.gbDSSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbDSSP.Name = "gbDSSP";
            this.gbDSSP.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbDSSP.Size = new System.Drawing.Size(976, 254);
            this.gbDSSP.TabIndex = 44;
            this.gbDSSP.TabStop = false;
            this.gbDSSP.Text = "Danh sách sản phẩm";
            // 
            // dataGridViewDSSP
            // 
            this.dataGridViewDSSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDSSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSSP.Location = new System.Drawing.Point(28, 45);
            this.dataGridViewDSSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewDSSP.Name = "dataGridViewDSSP";
            this.dataGridViewDSSP.RowHeadersWidth = 62;
            this.dataGridViewDSSP.Size = new System.Drawing.Size(915, 200);
            this.dataGridViewDSSP.TabIndex = 0;
            this.dataGridViewDSSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDSSP_CellClick);
            this.dataGridViewDSSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDSSP_CellContentClick);
            // 
            // gbTTSP
            // 
            this.gbTTSP.Controls.Add(this.tbGhiChu);
            this.gbTTSP.Controls.Add(this.tbMaPN);
            this.gbTTSP.Controls.Add(this.label10);
            this.gbTTSP.Controls.Add(this.label8);
            this.gbTTSP.Controls.Add(this.btnThemKH);
            this.gbTTSP.Controls.Add(this.dTNgayBan);
            this.gbTTSP.Controls.Add(this.label5);
            this.gbTTSP.Controls.Add(this.tbTen);
            this.gbTTSP.Controls.Add(this.label4);
            this.gbTTSP.Controls.Add(this.tbMaKH);
            this.gbTTSP.Controls.Add(this.label3);
            this.gbTTSP.Location = new System.Drawing.Point(28, 85);
            this.gbTTSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTTSP.Name = "gbTTSP";
            this.gbTTSP.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTTSP.Size = new System.Drawing.Size(976, 231);
            this.gbTTSP.TabIndex = 43;
            this.gbTTSP.TabStop = false;
            this.gbTTSP.Text = "Thông tin khách hàng";
            // 
            // tbGhiChu
            // 
            this.tbGhiChu.Location = new System.Drawing.Point(585, 29);
            this.tbGhiChu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbGhiChu.Multiline = true;
            this.tbGhiChu.Name = "tbGhiChu";
            this.tbGhiChu.Size = new System.Drawing.Size(342, 119);
            this.tbGhiChu.TabIndex = 26;
            // 
            // tbMaPN
            // 
            this.tbMaPN.Location = new System.Drawing.Point(174, 34);
            this.tbMaPN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMaPN.Name = "tbMaPN";
            this.tbMaPN.ReadOnly = true;
            this.tbMaPN.Size = new System.Drawing.Size(198, 26);
            this.tbMaPN.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(510, 38);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Ghi chú";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Mã phiếu xuất";
            // 
            // btnThemKH
            // 
            this.btnThemKH.Location = new System.Drawing.Point(639, 177);
            this.btnThemKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(251, 35);
            this.btnThemKH.TabIndex = 18;
            this.btnThemKH.Text = "Thêm khách hàng mới";
            this.btnThemKH.UseVisualStyleBackColor = true;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // dTNgayBan
            // 
            this.dTNgayBan.Location = new System.Drawing.Point(174, 168);
            this.dTNgayBan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dTNgayBan.Name = "dTNgayBan";
            this.dTNgayBan.Size = new System.Drawing.Size(280, 26);
            this.dTNgayBan.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 173);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ngày xuất";
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(174, 126);
            this.tbTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(198, 26);
            this.tbTen.TabIndex = 6;
            this.tbTen.Click += new System.EventHandler(this.tbTen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên khách hàng";
            // 
            // tbMaKH
            // 
            this.tbMaKH.Location = new System.Drawing.Point(174, 80);
            this.tbMaKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMaKH.Name = "tbMaKH";
            this.tbMaKH.Size = new System.Drawing.Size(198, 26);
            this.tbMaKH.TabIndex = 4;
            this.tbMaKH.TextChanged += new System.EventHandler(this.tbMaKH_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã khách hàng";
            // 
            // PhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 525);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PhieuXuat";
            this.Text = "HoaDonBanHang";
            this.Load += new System.EventHandler(this.PhieuXuat_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PhieuXuat_KeyDown);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbDSSP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSSP)).EndInit();
            this.gbTTSP.ResumeLayout(false);
            this.gbTTSP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbThanhToan;
        private System.Windows.Forms.TextBox tbTenSP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbDonGia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbMaSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTenKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.GroupBox gbDSSP;
        private System.Windows.Forms.DataGridView dataGridViewDSSP;
        private System.Windows.Forms.GroupBox gbTTSP;
        private System.Windows.Forms.TextBox tbGhiChu;
        private System.Windows.Forms.TextBox tbMaPN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.DateTimePicker dTNgayBan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMaKH;
        private System.Windows.Forms.Label label3;
    }
}