namespace PHAN1
{
    public partial class Nhom_08 : Form
    {
        public Nhom_08()
        {
            InitializeComponent();
            LoadDataFromFile();
            btnLuu.Enabled = false;
        }
        List<NhanVien> danhsachNV = new List<NhanVien>();
        void HienThiListView()
        {
            listView1.Items.Clear();
            foreach (var nv in danhsachNV)
            {
                ListViewItem item = new ListViewItem(nv.Maso);
                item.SubItems.Add(nv.Hoten);
                item.SubItems.Add(nv.Ngaysinh.ToString("dd/MM/yyyy"));
                item.SubItems.Add(nv.Email);

                listView1.Items.Add(item);
            }
        }

        void LoadDataFromFile()
        {
            danhsachNV.Clear();

            if(!File.Exists("dulieu.txt"))
            {
                MessageBox.Show("File du lieu khong ton tai");
                return;
            }
            string[] linbes = File.ReadAllLines("dulieu.txt");
            foreach (var line in linbes)
            {
                var parts = line.Split(';');
                if (parts.Length == 4)
                {
                    danhsachNV.Add(new NhanVien
                    {
                        Maso = parts[0],
                        Hoten = parts[1],
                        Ngaysinh = DateTime.ParseExact(parts[2], "dd/MM/yyyy", null),
                        Email = parts[3],
                    });
                }
            }
            HienThiListView();
        }

        private void ngaysinh_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ms_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nhom_08_Load(object sender, EventArgs e)
        {
            LoadDataFromFile();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var item = listView1.SelectedItems[0];
                txtMaSo.Text = item.SubItems[0].Text;
                txtHoTen.Text = item.SubItems[1].Text;
                txtNgaySinh.Text = item.SubItems[2].Text;
                txtEmail.Text = item.SubItems[3].Text;
            }
        }
        bool isAdding = false;
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!isAdding)
            {
                isAdding = true;
                btnThem.Text = $"Hủy";
                btnLuu.Enabled = true;

                //txtMaSo.Enabled = true;
                //txtHoTen.Enabled = true;
                //txtNgaySinh.Enabled = true;
                //txtEmail.Enabled = true;
            }
            else
            {
                isAdding = false;
                btnThem.Text = $"Thêm";
                btnLuu.Enabled = false;

                //txtMaSo.Enabled = false;
                //txtHoTen.Enabled = false;
                //txtNgaySinh.Enabled = false;
                //txtEmail.Enabled = false;

                txtMaSo.Clear();
                txtHoTen.Clear();
                txtNgaySinh.Clear();
                txtEmail.Clear();
            }
        }
        

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                var nv = new NhanVien
                {
                    Maso = txtMaSo.Text,
                    Hoten = txtHoTen.Text,
                    Ngaysinh = DateTime.ParseExact(txtNgaySinh.Text, "dd/MM/yyyy", null),
                    Email = txtEmail.Text
                };
                danhsachNV.Add(nv);
                HienThiListView();

                btnThem.Text = "Them";
                btnLuu.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Du lieu khong hop le!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            LuuDuLieuXuongFile();
            Application.Exit();
        }

        void LuuDuLieuXuongFile()
        {
            using (StreamWriter writer = new StreamWriter("dulieu.txt"))
            {
                foreach (var nv in danhsachNV)
                {
                    string lines = $"{nv.Maso};{nv.Hoten};{nv.Ngaysinh:dd/MM/yyyy};{nv.Email}";
                    writer.WriteLine(lines);
                }
            }
        }
    }
}
