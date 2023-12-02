namespace EmployeeManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            groupBox1 = new GroupBox();
            cbbPhongBan = new ComboBox();
            txtMucLuong = new TextBox();
            txtSoDT = new TextBox();
            txtTenNV = new TextBox();
            txtMaNV = new TextBox();
            pictureBox = new PictureBox();
            btnAnh = new Button();
            rbtnNu = new RadioButton();
            rbtnNam = new RadioButton();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            dgv = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(250, 23);
            label2.Name = "label2";
            label2.Size = new Size(295, 26);
            label2.TabIndex = 1;
            label2.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbbPhongBan);
            groupBox1.Controls.Add(txtMucLuong);
            groupBox1.Controls.Add(txtSoDT);
            groupBox1.Controls.Add(txtTenNV);
            groupBox1.Controls.Add(txtMaNV);
            groupBox1.Controls.Add(pictureBox);
            groupBox1.Controls.Add(btnAnh);
            groupBox1.Controls.Add(rbtnNu);
            groupBox1.Controls.Add(rbtnNam);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(74, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(641, 220);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập thông tin";
            // 
            // cbbPhongBan
            // 
            cbbPhongBan.FormattingEnabled = true;
            cbbPhongBan.Items.AddRange(new object[] { "Thu Ngân", "Nhân Sự", "Tài Chính" });
            cbbPhongBan.Location = new Point(415, 147);
            cbbPhongBan.Name = "cbbPhongBan";
            cbbPhongBan.Size = new Size(183, 23);
            cbbPhongBan.TabIndex = 14;
            cbbPhongBan.Text = "Thu Ngân";
            // 
            // txtMucLuong
            // 
            txtMucLuong.Location = new Point(415, 176);
            txtMucLuong.Name = "txtMucLuong";
            txtMucLuong.Size = new Size(183, 23);
            txtMucLuong.TabIndex = 13;
            txtMucLuong.TextChanged += txtMucLuong_TextChanged;
            // 
            // txtSoDT
            // 
            txtSoDT.Location = new Point(72, 98);
            txtSoDT.Name = "txtSoDT";
            txtSoDT.Size = new Size(212, 23);
            txtSoDT.TabIndex = 12;
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(72, 59);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(212, 23);
            txtTenNV.TabIndex = 11;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(71, 22);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(213, 23);
            txtMaNV.TabIndex = 10;
            txtMaNV.TextChanged += txtMaNV_TextChanged;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(425, 13);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(125, 129);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 9;
            pictureBox.TabStop = false;
            // 
            // btnAnh
            // 
            btnAnh.Location = new Point(342, 30);
            btnAnh.Name = "btnAnh";
            btnAnh.Size = new Size(68, 29);
            btnAnh.TabIndex = 8;
            btnAnh.Text = "Ảnh";
            btnAnh.UseVisualStyleBackColor = true;
            btnAnh.Click += btnAnh_Click;
            // 
            // rbtnNu
            // 
            rbtnNu.AutoSize = true;
            rbtnNu.Location = new Point(212, 143);
            rbtnNu.Name = "rbtnNu";
            rbtnNu.Size = new Size(41, 19);
            rbtnNu.TabIndex = 7;
            rbtnNu.TabStop = true;
            rbtnNu.Text = "Nữ";
            rbtnNu.UseVisualStyleBackColor = true;
            // 
            // rbtnNam
            // 
            rbtnNam.AutoSize = true;
            rbtnNam.Location = new Point(113, 145);
            rbtnNam.Name = "rbtnNam";
            rbtnNam.Size = new Size(51, 19);
            rbtnNam.TabIndex = 6;
            rbtnNam.TabStop = true;
            rbtnNam.Text = "Nam";
            rbtnNam.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(342, 184);
            label8.Name = "label8";
            label8.Size = new Size(71, 15);
            label8.TabIndex = 5;
            label8.Text = "Mức lương: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(342, 147);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 4;
            label7.Text = "Phòng ban:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 147);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 3;
            label6.Text = "Giới tính:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 106);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 2;
            label5.Text = "Số ĐT:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 67);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 1;
            label4.Text = "Tên NV:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 30);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 0;
            label3.Text = "Mã NV:";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(125, 494);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 32);
            btnThem.TabIndex = 4;
            btnThem.Text = "T&hêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(276, 494);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 32);
            btnSua.TabIndex = 5;
            btnSua.Text = "&Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(435, 495);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 31);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "&Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(585, 495);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 31);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "&Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(38, 296);
            dgv.Name = "dgv";
            dgv.RowTemplate.Height = 25;
            dgv.Size = new Size(708, 184);
            dgv.TabIndex = 8;
            dgv.CellClick += dgv_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 538);
            Controls.Add(dgv);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Quản lý nhân viên";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private GroupBox groupBox1;
        private ComboBox cbbPhongBan;
        private TextBox txtMucLuong;
        private TextBox txtSoDT;
        private TextBox txtTenNV;
        private TextBox txtMaNV;
        private PictureBox pictureBox;
        private Button btnAnh;
        private RadioButton rbtnNu;
        private RadioButton rbtnNam;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
        private DataGridView dgv;
    }
}