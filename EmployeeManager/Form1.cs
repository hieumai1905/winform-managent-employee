using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace EmployeeManager
{
    public partial class Form1 : Form
    {
        ProcessDatabase db = new ProcessDatabase();
        string imagePath;
        string connectString = @"Data Source=HIEU-MAI\SQLEXPRESS;Initial Catalog=manager_employee;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
            check();
        }

        // Đọc dữ liệu từ bảng employees
        public void DocBang()
        {
            dgv.DataSource = db.DocBang("select * from employees");
            dgv.Columns[0].HeaderText = "Mã NV";
            dgv.Columns[1].HeaderText = "Tên NV";
            dgv.Columns[2].HeaderText = "Số ĐT";
            dgv.Columns[3].HeaderText = "Giới tính";
            dgv.Columns[4].HeaderText = "Phòng ban";
            dgv.Columns[5].HeaderText = "Mức lương";
            dgv.Columns[6].HeaderText = "Ảnh";
        }

        // Kiểm tra giới tính
        public void check()
        {
            if (rbtnNam.Checked == true)
                rbtnNu.Checked = false;
            if (rbtnNu.Checked == true)
                rbtnNam.Checked = false;
        }
        
        // Đóng chương trình
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        // Nhấp để chọn ảnh
        private void btnAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (.png; *.jpg; *.jpeg; *.gif; *.bmp)|.png; *.jpg; *.jpeg; *.gif; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName;
                Image image = Image.FromFile(imagePath);
                pictureBox.Image = image;
            }
        }

        // validate dữ liệu
        public bool validate()
        {
            if (txtTenNV.Text.Trim().Equals(""))
            {
                MessageBox.Show("Hãy nhập tên nhân viên");
                txtTenNV.Focus();
                return false;
            }
            else if (!Regex.IsMatch(txtTenNV.Text.Trim(), @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Tên nhân viên chỉ được chứa chữ cái và khoảng trắng");
                txtTenNV.Focus();
                return false;
            }

            if (txtSoDT.Text.Trim().Equals(""))
            {
                MessageBox.Show("Hãy nhập số điện thoại");
                txtSoDT.Focus();
                return false;
            }
            else if (!Regex.IsMatch(txtSoDT.Text.Trim(), @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại phải có 10 chữ số");
                txtSoDT.Focus();
                return false;
            }
            if (txtMucLuong.Text.Trim().Equals(""))
            {
                MessageBox.Show("Hãy nhập mức lương");
                txtMucLuong.Focus();
                return false;
            }
            else if (!Regex.IsMatch(txtMucLuong.Text.Trim(), @"^[0-9]+$"))
            {
                MessageBox.Show("Mức lương chỉ được chứa số");
                txtMucLuong.Focus();
                return false;
            }
            return true;
        }

        // load nhân viên lên bảng
        private void Form1_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            DocBang();
        }

        // hàm thêm nhân viên mới
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                string sql, GioiTinh;
                if (rbtnNam.Checked == true)
                    GioiTinh = "Nam";
                else GioiTinh = "Nữ";
                sql = "SELECT MaNV FROM employees WHERE maNv=N'" + txtMaNV.Text + "'";
                SqlConnection connection = new SqlConnection(connectString);
                connection.Open();
                SqlDataAdapter MyData = new SqlDataAdapter(sql, connection);
                DataTable table = new DataTable();
                MyData.Fill(table);
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Mã nhân viên này đã tồn tại");
                    txtMaNV.Focus();
                    return;
                }
                sql = "INSERT INTO employees VALUES ('" + txtMaNV.Text + "',N'" + txtTenNV.Text + "','" +
                txtSoDT.Text + "',N'" + GioiTinh + "',N'" + cbbPhongBan.Text + "'," + int.Parse(txtMucLuong.Text) +
                ",'" + imagePath + "')";
                db.CapNhat(sql);
                DocBang();
            }
        }

        // hàm sửa nhân viên
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                string sql, GioiTinh;
                if (rbtnNam.Checked == true)
                    GioiTinh = "Nam";
                else GioiTinh = "Nữ";
                sql = "UPDATE employees SET ten=N'" + txtTenNV.Text + "',sdt=N'" + txtSoDT.Text +
                    "',gioiTinh=N'" + GioiTinh +
                    "',phongban=N'" + cbbPhongBan.Text + "',mucLuong=" + int.Parse(txtMucLuong.Text) +
                    ",anh='" + imagePath + "' WHERE maNv='" + txtMaNV.Text + "'";
                db.CapNhat(sql);
                DocBang();
            }
        }

        // hàm xóa nhân viên
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE employees WHERE maNv='" + txtMaNV.Text + "'";
                db.CapNhat(sql);
                DocBang();
                pictureBox.Image = null;
            }
        }

        // check thay đổi mã nhân viên
        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
        }

        // Sự kiện khi nhấn vào mỗi ô trong bảng
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = dgv.CurrentRow.Cells[0].Value.ToString();
            txtTenNV.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            txtSoDT.Text = dgv.CurrentRow.Cells[2].Value.ToString();
            if (dgv.CurrentRow.Cells[3].Value.ToString() == "Nam")
                rbtnNam.Checked = true;
            else
                rbtnNu.Checked = true;
            cbbPhongBan.Text = dgv.CurrentRow.Cells[4].Value.ToString();
            txtMucLuong.Text = dgv.CurrentRow.Cells[5].Value.ToString();
            if (dgv.CurrentRow.Cells[6].Value.ToString() != "")
            {
                string imageName = dgv.CurrentRow.Cells[6].Value.ToString();
                string imagePath = Path.Combine(Application.StartupPath, "images", imageName);
                if (File.Exists(imagePath))
                {
                    Image image = Image.FromFile(imagePath);
                    pictureBox.Image = image;
                }
                else
                {
                    pictureBox.Image = null;
                    MessageBox.Show("Không tìm thấy tệp tin ảnh: " + imageName);
                }
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = false;
            }
            else
            {
                pictureBox.Image = null;
            }
        }

        // xử lý khi nhập lương, không cho phép nhập ký tự đầu tiên là 0
        private void txtMucLuong_TextChanged(object sender, EventArgs e)
        {
            string inputText = txtMucLuong.Text.Trim();

            if (!string.IsNullOrEmpty(inputText) && inputText.Length >= 1)
            {
                if (inputText[0] == '0')
                {
                    txtMucLuong.Text = inputText.Substring(1);
                    txtMucLuong.SelectionStart = txtMucLuong.Text.Length;
                }
            }
        }
    }
}