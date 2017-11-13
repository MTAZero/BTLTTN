namespace QuanLyThuVien.GUI
{
    partial class FrmQuanLyDocGia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCaThi = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnXoaCaThi = new System.Windows.Forms.Button();
            this.btnThemCaThi = new System.Windows.Forms.Button();
            this.groupThongTinCaThi = new System.Windows.Forms.GroupBox();
            this.dateBatDau = new System.Windows.Forms.DateTimePicker();
            this.txtShiftName = new System.Windows.Forms.TextBox();
            this.cbxLoaiCaThi = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panelTimKiem = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaThi)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupThongTinCaThi.SuspendLayout();
            this.panelTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panelTimKiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 699);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.dgvCaThi);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(741, 632);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách độc giả";
            // 
            // dgvCaThi
            // 
            this.dgvCaThi.AllowUserToResizeColumns = false;
            this.dgvCaThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCaThi.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvCaThi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCaThi.ColumnHeadersHeight = 30;
            this.dgvCaThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.STT,
            this.MaDocGia,
            this.HoTen,
            this.NgaySinh,
            this.GioiTinh});
            this.dgvCaThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCaThi.EnableHeadersVisualStyles = false;
            this.dgvCaThi.GridColor = System.Drawing.Color.Black;
            this.dgvCaThi.Location = new System.Drawing.Point(3, 20);
            this.dgvCaThi.MultiSelect = false;
            this.dgvCaThi.Name = "dgvCaThi";
            this.dgvCaThi.ReadOnly = true;
            this.dgvCaThi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCaThi.RowHeadersWidth = 25;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCaThi.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCaThi.RowTemplate.Height = 30;
            this.dgvCaThi.RowTemplate.ReadOnly = true;
            this.dgvCaThi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCaThi.Size = new System.Drawing.Size(735, 609);
            this.dgvCaThi.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.groupThongTinCaThi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(741, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 632);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btnXoaCaThi);
            this.panel3.Controls.Add(this.btnThemCaThi);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 295);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(367, 100);
            this.panel3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(4, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(358, 39);
            this.button1.TabIndex = 12;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnXoaCaThi
            // 
            this.btnXoaCaThi.BackColor = System.Drawing.Color.Teal;
            this.btnXoaCaThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaCaThi.ForeColor = System.Drawing.Color.White;
            this.btnXoaCaThi.Location = new System.Drawing.Point(186, 7);
            this.btnXoaCaThi.Name = "btnXoaCaThi";
            this.btnXoaCaThi.Size = new System.Drawing.Size(176, 39);
            this.btnXoaCaThi.TabIndex = 11;
            this.btnXoaCaThi.Text = "Sửa";
            this.btnXoaCaThi.UseVisualStyleBackColor = false;
            // 
            // btnThemCaThi
            // 
            this.btnThemCaThi.BackColor = System.Drawing.Color.Teal;
            this.btnThemCaThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemCaThi.ForeColor = System.Drawing.Color.White;
            this.btnThemCaThi.Location = new System.Drawing.Point(4, 7);
            this.btnThemCaThi.Name = "btnThemCaThi";
            this.btnThemCaThi.Size = new System.Drawing.Size(176, 39);
            this.btnThemCaThi.TabIndex = 10;
            this.btnThemCaThi.Text = "Thêm";
            this.btnThemCaThi.UseVisualStyleBackColor = false;
            // 
            // groupThongTinCaThi
            // 
            this.groupThongTinCaThi.BackColor = System.Drawing.Color.White;
            this.groupThongTinCaThi.Controls.Add(this.textBox3);
            this.groupThongTinCaThi.Controls.Add(this.textBox2);
            this.groupThongTinCaThi.Controls.Add(this.label2);
            this.groupThongTinCaThi.Controls.Add(this.dateBatDau);
            this.groupThongTinCaThi.Controls.Add(this.txtShiftName);
            this.groupThongTinCaThi.Controls.Add(this.cbxLoaiCaThi);
            this.groupThongTinCaThi.Controls.Add(this.label8);
            this.groupThongTinCaThi.Controls.Add(this.label10);
            this.groupThongTinCaThi.Controls.Add(this.label12);
            this.groupThongTinCaThi.Controls.Add(this.label13);
            this.groupThongTinCaThi.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupThongTinCaThi.Location = new System.Drawing.Point(0, 0);
            this.groupThongTinCaThi.Name = "groupThongTinCaThi";
            this.groupThongTinCaThi.Size = new System.Drawing.Size(367, 295);
            this.groupThongTinCaThi.TabIndex = 1;
            this.groupThongTinCaThi.TabStop = false;
            this.groupThongTinCaThi.Text = "Chi tiết thông tin độc giả";
            // 
            // dateBatDau
            // 
            this.dateBatDau.CustomFormat = "dd/MM/yyyy";
            this.dateBatDau.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBatDau.Location = new System.Drawing.Point(105, 171);
            this.dateBatDau.Name = "dateBatDau";
            this.dateBatDau.Size = new System.Drawing.Size(108, 23);
            this.dateBatDau.TabIndex = 4;
            // 
            // txtShiftName
            // 
            this.txtShiftName.Location = new System.Drawing.Point(105, 35);
            this.txtShiftName.Name = "txtShiftName";
            this.txtShiftName.Size = new System.Drawing.Size(147, 24);
            this.txtShiftName.TabIndex = 2;
            // 
            // cbxLoaiCaThi
            // 
            this.cbxLoaiCaThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLoaiCaThi.FormattingEnabled = true;
            this.cbxLoaiCaThi.Items.AddRange(new object[] {
            "Ca thi chính thức",
            "Ca thi dự phòng"});
            this.cbxLoaiCaThi.Location = new System.Drawing.Point(105, 127);
            this.cbxLoaiCaThi.Name = "cbxLoaiCaThi";
            this.cbxLoaiCaThi.Size = new System.Drawing.Size(173, 25);
            this.cbxLoaiCaThi.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ngày sinh :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Giới tính :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Họ tên :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Mã độc giả :";
            // 
            // panelTimKiem
            // 
            this.panelTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTimKiem.Controls.Add(this.button2);
            this.panelTimKiem.Controls.Add(this.textBox1);
            this.panelTimKiem.Controls.Add(this.label1);
            this.panelTimKiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTimKiem.Location = new System.Drawing.Point(0, 0);
            this.panelTimKiem.Name = "panelTimKiem";
            this.panelTimKiem.Size = new System.Drawing.Size(1110, 65);
            this.panelTimKiem.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(436, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 24);
            this.button2.TabIndex = 2;
            this.button2.Text = "Tìm kiếm";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(304, 24);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Địa chỉ :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(232, 24);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(105, 219);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(252, 58);
            this.textBox3.TabIndex = 8;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.FillWeight = 5F;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // MaDocGia
            // 
            this.MaDocGia.FillWeight = 15F;
            this.MaDocGia.HeaderText = "Mã độc giả";
            this.MaDocGia.Name = "MaDocGia";
            this.MaDocGia.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.FillWeight = 40F;
            this.HoTen.HeaderText = "Họ và tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // NgaySinh
            // 
            this.NgaySinh.FillWeight = 20F;
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.FillWeight = 20F;
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // FrmQuanLyDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 699);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmQuanLyDocGia";
            this.Text = "FrmQuanLyDocGia";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaThi)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupThongTinCaThi.ResumeLayout(false);
            this.groupThongTinCaThi.PerformLayout();
            this.panelTimKiem.ResumeLayout(false);
            this.panelTimKiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTimKiem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCaThi;
        private System.Windows.Forms.GroupBox groupThongTinCaThi;
        private System.Windows.Forms.DateTimePicker dateBatDau;
        private System.Windows.Forms.TextBox txtShiftName;
        private System.Windows.Forms.ComboBox cbxLoaiCaThi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnXoaCaThi;
        private System.Windows.Forms.Button btnThemCaThi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;

    }
}