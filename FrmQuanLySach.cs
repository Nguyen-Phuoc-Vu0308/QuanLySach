using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySach
{
    public partial class FrmQuanLySach : Form
    {
        public FrmQuanLySach()
        {
            InitializeComponent();
        }

        //==Logic bắt lỗi==//

        // 1. Năm xuất bản: Chỉ cho phép nhập Số và phím Backspace
        private void txtNamXuatBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        // 2. Tên sách, Tác giả, Nhà xuất bản: Chỉ cho phép chữ cái (hỗ trợ tiếng Việt), khoảng trắng và Backspace (Chặn số và ký tự đặc biệt)
        private void txtDuLieuHopLe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; 
            }
        }

        // Hàm kiểm tra dữ liệu trước khi Thêm/Sửa
        private bool KiemTraHopLe()
        {
            // Kiểm tra rỗng 
            if (string.IsNullOrWhiteSpace(txtMaSach.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sách", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSach.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTenSach.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sách", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenSach.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTacGia.Text))
            {
                MessageBox.Show("Vui lòng nhập tên tác gỉa", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTacGia.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNhaXuatBan.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhà xuất bản", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhaXuatBan.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNamXuatBan.Text))
            {
                MessageBox.Show("Vui lòng nhập năm xuất bản", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamXuatBan.Focus();
                return false;
            }

            // Kiểm tra năm xuất bản là số và dữ liệu thực tế 
            if (!int.TryParse(txtNamXuatBan.Text, out int namXB) || namXB < 1500 || namXB > DateTime.Now.Year)
            {
                MessageBox.Show("Năm xuất bản không hợp lệ", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamXuatBan.Focus();
                return false;
            }

            return true; 
        }

        //Nút thêm 
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra lỗi trước khi tiếp tục 
            if (KiemTraHopLe() == false) return;
            MessageBox.Show("Thêm sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm();
        }

        //Nút sửa (mặc định phải có mã sách)
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSach.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sách cần sửa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (KiemTraHopLe() == false) return;

            MessageBox.Show("Đã cập nhật thông tin sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Nút xóa (phải có mã sách)
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSach.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sách cần xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa sách?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
        }
        
        //Nút tìm kiếm 
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // Kiểm tra người dùng có nhập dữ liệu chưa (cần có tên or mã sách)
            if (string.IsNullOrWhiteSpace(txtTenSach.Text) && string.IsNullOrWhiteSpace(txtMaSach.Text))
            {
                MessageBox.Show("Vui lòng nhập các thông tin (Tên sách hoặc Mã sách) để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Đã tìm được sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Hàm clear form sau khi xóa 
        private void ClearForm()
        {
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtTacGia.Clear();
            txtNhaXuatBan.Clear();
            txtNamXuatBan.Clear();
            txtMaSach.Focus();
        }
    }
}
