namespace PHAN1
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
            ms_txtbox = new TextBox();
            ten_txtbox = new TextBox();
            ngaysinh_txtbox = new TextBox();
            email_txtbox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // ms_txtbox
            // 
            ms_txtbox.Location = new Point(163, 82);
            ms_txtbox.Name = "ms_txtbox";
            ms_txtbox.Size = new Size(322, 23);
            ms_txtbox.TabIndex = 0;
            // 
            // ten_txtbox
            // 
            ten_txtbox.Location = new Point(163, 121);
            ten_txtbox.Name = "ten_txtbox";
            ten_txtbox.Size = new Size(322, 23);
            ten_txtbox.TabIndex = 1;
            // 
            // ngaysinh_txtbox
            // 
            ngaysinh_txtbox.Location = new Point(163, 162);
            ngaysinh_txtbox.Name = "ngaysinh_txtbox";
            ngaysinh_txtbox.Size = new Size(322, 23);
            ngaysinh_txtbox.TabIndex = 2;
            ngaysinh_txtbox.TextChanged += ngaysinh_txtbox_TextChanged;
            // 
            // email_txtbox
            // 
            email_txtbox.Location = new Point(163, 200);
            email_txtbox.Name = "email_txtbox";
            email_txtbox.Size = new Size(322, 23);
            email_txtbox.TabIndex = 3;
            email_txtbox.TextChanged += email_txtbox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 85);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 4;
            label1.Text = "Mã số";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(email_txtbox);
            Controls.Add(ngaysinh_txtbox);
            Controls.Add(ten_txtbox);
            Controls.Add(ms_txtbox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ms_txtbox;
        private TextBox ten_txtbox;
        private TextBox ngaysinh_txtbox;
        private TextBox email_txtbox;
        private Label label1;
    }
}
