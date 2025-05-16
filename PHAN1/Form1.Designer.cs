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
            ms_txtbox = new TextBox();
            ten_txtbox = new TextBox();
            ngaysinh_txtbox = new TextBox();
            email_txtbox = new TextBox();
            lblMaSo = new Label();
            lblHoTen = new Label();
            lblNgaySinh = new Label();
            lblEmail = new Label();
            btnThem = new Button();
            btnLuu = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // ms_txtbox
            // 
            ms_txtbox.Location = new Point(91, 4);
            ms_txtbox.Name = "ms_txtbox";
            ms_txtbox.Size = new Size(501, 23);
            ms_txtbox.TabIndex = 0;
            // 
            // ten_txtbox
            // 
            ten_txtbox.Location = new Point(91, 43);
            ten_txtbox.Name = "ten_txtbox";
            ten_txtbox.Size = new Size(501, 23);
            ten_txtbox.TabIndex = 1;
            // 
            // ngaysinh_txtbox
            // 
            ngaysinh_txtbox.Location = new Point(91, 84);
            ngaysinh_txtbox.Name = "ngaysinh_txtbox";
            ngaysinh_txtbox.Size = new Size(501, 23);
            ngaysinh_txtbox.TabIndex = 2;
            ngaysinh_txtbox.TextChanged += ngaysinh_txtbox_TextChanged;
            // 
            // email_txtbox
            // 
            email_txtbox.Location = new Point(91, 122);
            email_txtbox.Name = "email_txtbox";
            email_txtbox.Size = new Size(501, 23);
            email_txtbox.TabIndex = 3;
            email_txtbox.TextChanged += email_txtbox_TextChanged;
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
            // 
            // Nhom_08
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 391);
            Controls.Add(btnThoat);
            Controls.Add(btnLuu);
            Controls.Add(btnThem);
            Controls.Add(lblEmail);
            Controls.Add(lblNgaySinh);
            Controls.Add(lblHoTen);
            Controls.Add(lblMaSo);
            Controls.Add(email_txtbox);
            Controls.Add(ngaysinh_txtbox);
            Controls.Add(ten_txtbox);
            Controls.Add(ms_txtbox);
            Name = "Nhom_08";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhóm 08";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ms_txtbox;
        private TextBox ten_txtbox;
        private TextBox ngaysinh_txtbox;
        private TextBox email_txtbox;
        private Label lblMaSo;
        private Label lblHoTen;
        private Label lblNgaySinh;
        private Label lblEmail;
        private Button btnThem;
        private Button btnLuu;
        private Button btnThoat;
    }
}
