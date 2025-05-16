namespace PHAN1
{
    partial class Nhom_08
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
            txtMaSo = new TextBox();
            txtHoTen = new TextBox();
            txtNgaySinh = new TextBox();
            txtEmail = new TextBox();
            lblMaSo = new Label();
            lblHoTen = new Label();
            lblNgaySinh = new Label();
            lblEmail = new Label();
            btnThem = new Button();
            btnLuu = new Button();
            btnThoat = new Button();
            listView1 = new ListView();
            maso = new ColumnHeader();
            Hoten = new ColumnHeader();
            ngaysinh = new ColumnHeader();
            email = new ColumnHeader();
            SuspendLayout();
            // 
            // txtMaSo
            // 
            txtMaSo.Location = new Point(91, 4);
            txtMaSo.Name = "txtMaSo";
            txtMaSo.Size = new Size(501, 23);
            txtMaSo.TabIndex = 0;
            txtMaSo.TextChanged += ms_txtbox_TextChanged;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(91, 43);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(501, 23);
            txtHoTen.TabIndex = 1;
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.Location = new Point(91, 84);
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.Size = new Size(501, 23);
            txtNgaySinh.TabIndex = 2;
            txtNgaySinh.TextChanged += ngaysinh_txtbox_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(91, 122);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(501, 23);
            txtEmail.TabIndex = 3;
            txtEmail.TextChanged += email_txtbox_TextChanged;
            // 
            // lblMaSo
            // 
            lblMaSo.AutoSize = true;
            lblMaSo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMaSo.Location = new Point(1, 4);
            lblMaSo.Name = "lblMaSo";
            lblMaSo.Size = new Size(55, 21);
            lblMaSo.TabIndex = 4;
            lblMaSo.Text = "Mã số";
            lblMaSo.Click += label1_Click;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblHoTen.Location = new Point(1, 43);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(61, 21);
            lblHoTen.TabIndex = 5;
            lblHoTen.Text = "Họ tên";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNgaySinh.Location = new Point(1, 84);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(87, 21);
            lblNgaySinh.TabIndex = 6;
            lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEmail.Location = new Point(1, 122);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(53, 21);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.ActiveCaption;
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnThem.Location = new Point(172, 170);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(82, 37);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = SystemColors.ActiveCaption;
            btnLuu.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLuu.Location = new Point(251, 170);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(82, 37);
            btnLuu.TabIndex = 9;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.ActiveCaption;
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnThoat.Location = new Point(331, 170);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(82, 37);
            btnThoat.TabIndex = 10;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { maso, Hoten, ngaysinh, email });
            listView1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView1.GridLines = true;
            listView1.Location = new Point(1, 213);
            listView1.Name = "listView1";
            listView1.Size = new Size(601, 178);
            listView1.TabIndex = 11;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // maso
            // 
            maso.Text = "Mã số";
            maso.Width = 100;
            // 
            // Hoten
            // 
            Hoten.Text = "Họ và tên";
            Hoten.TextAlign = HorizontalAlignment.Center;
            Hoten.Width = 150;
            // 
            // ngaysinh
            // 
            ngaysinh.Text = "Ngày sinh";
            ngaysinh.TextAlign = HorizontalAlignment.Center;
            ngaysinh.Width = 180;
            // 
            // email
            // 
            email.Text = "Email";
            email.TextAlign = HorizontalAlignment.Center;
            email.Width = 180;
            // 
            // Nhom_08
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 391);
            Controls.Add(listView1);
            Controls.Add(btnThoat);
            Controls.Add(btnLuu);
            Controls.Add(btnThem);
            Controls.Add(lblEmail);
            Controls.Add(lblNgaySinh);
            Controls.Add(lblHoTen);
            Controls.Add(lblMaSo);
            Controls.Add(txtEmail);
            Controls.Add(txtNgaySinh);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaSo);
            Name = "Nhom_08";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhóm 08";
            Load += Nhom_08_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaSo;
        private TextBox txtHoTen;
        private TextBox txtNgaySinh;
        private TextBox txtEmail;
        private Label lblMaSo;
        private Label lblHoTen;
        private Label lblNgaySinh;
        private Label lblEmail;
        private Button btnThem;
        private Button btnLuu;
        private Button btnThoat;
        private ListView listView1;
        private ColumnHeader maso;
        private ColumnHeader Hoten;
        private ColumnHeader ngaysinh;
        private ColumnHeader email;
    }
}
