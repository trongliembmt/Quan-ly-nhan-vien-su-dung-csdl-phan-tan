using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using CSDLPT_NHANVIEN.Model;
using CSDLPT_NHANVIEN.Controller;

namespace CSDLPT_NHANVIEN
{
    public partial class TimKiemCN1 : Form
    {
        NhanVienController NVController = new NhanVienController();
        public TimKiemCN1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                DataTable dtNV = new DataTable();
                if (rdoMaNV.Checked == true)
                    dtNV = NVController.HienThiDuLieuTK(txtTimKiem.Text);
                else
                    dtNV = NVController.HienThiDuLieuTimKiem1(txtTimKiem.Text);
                dataGridView1.DataSource = dtNV;
                dataGridView1.DataSource = dtNV;
                dataGridView1.Columns[0].DataPropertyName = "MaNV";
                dataGridView1.Columns[1].DataPropertyName = "MaPB";
                dataGridView1.Columns[2].DataPropertyName = "MaCN";
                dataGridView1.Columns[3].DataPropertyName = "MaCV";
                dataGridView1.Columns[4].DataPropertyName = "MaHD";
                dataGridView1.Columns[5].DataPropertyName = "HoTen";
                dataGridView1.Columns[6].DataPropertyName = "GioiTinh";
                dataGridView1.Columns[7].DataPropertyName = "QueQuan";
                dataGridView1.Columns[8].DataPropertyName = "NgaySinh";
                dataGridView1.Columns[9].DataPropertyName = "SDT";
                if (dataGridView1.Rows[0].Cells[0].Value == null)
                {
                    MessageBox.Show("Không tìm thấy Khách Hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    txtTimKiem.Enabled = true;
                    MessageBox.Show("Tìm kiếm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch
            {
                MessageBox.Show("Thông báo", "Dữ liệu tìm kiếm không tồn tại", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void loadNhanVien()
        {
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                DataTable dtNV = new DataTable();
                dtNV = NVController.HienThiDuLieu();
                dataGridView1.DataSource = dtNV;
                dataGridView1.DataSource = dtNV;
                dataGridView1.Columns[0].DataPropertyName = "MaNV";
                dataGridView1.Columns[1].DataPropertyName = "MaPB";
                dataGridView1.Columns[2].DataPropertyName = "MaCN";
                dataGridView1.Columns[3].DataPropertyName = "MaCV";
                dataGridView1.Columns[4].DataPropertyName = "MaHD";
                dataGridView1.Columns[5].DataPropertyName = "HoTen";
                dataGridView1.Columns[6].DataPropertyName = "GioiTinh";
                dataGridView1.Columns[7].DataPropertyName = "QueQuan";
                dataGridView1.Columns[8].DataPropertyName = "NgaySinh";
                dataGridView1.Columns[9].DataPropertyName = "SDT";
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }

        }

        private void TimKiemCN1_Load(object sender, EventArgs e)
        {
            loadNhanVien();          
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            loadNhanVien();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn muốn đóng màn hình này không?", "Thông báo", MessageBoxButtons.YesNo,
           MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (res == DialogResult.Yes)
                Close();
        }
    }
}
