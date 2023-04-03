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
    public partial class QLNHANVIEN_CN1: Form
    {
        NhanVienController NVController = new NhanVienController();
        KetNoiCSDL kn = new KetNoiCSDL();
        SqlConnection con;
        public QLNHANVIEN_CN1()
        {
            InitializeComponent();
        }

        private void QLNHANVIEN_CN1_Load(object sender, EventArgs e)
        {
            loadNV();
        }
        public void loadNV()
        {
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                DataTable dtNV = new DataTable();
                dtNV = NVController.HienThiDuLieu2();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numrow;
                numrow = e.RowIndex;
                cboMaNV.Text = dataGridView1.Rows[numrow].Cells[0].Value.ToString();
                cboMaPB.Text = dataGridView1.Rows[numrow].Cells[1].Value.ToString();
                cboCN.Text = dataGridView1.Rows[numrow].Cells[2].Value.ToString();
                cboCV.Text = dataGridView1.Rows[numrow].Cells[3].Value.ToString();
                cboHD.Text = dataGridView1.Rows[numrow].Cells[4].Value.ToString();
                txtHoTen.Text = dataGridView1.Rows[numrow].Cells[5].Value.ToString();
                txtGioiTinh.Text = dataGridView1.Rows[numrow].Cells[6].Value.ToString();
                txtQueQuan.Text = dataGridView1.Rows[numrow].Cells[7].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[numrow].Cells[8].Value.ToString();
                txtSDT.Text = dataGridView1.Rows[numrow].Cells[9].Value.ToString();
            }
            catch (Exception ex)
            {
                
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboMaNV.Text == "")
            {
                MessageBox.Show("Chưa nhập 'Mã Nhân Viên'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                con = kn.conDB_CN1();
                con.Open();
                string sqlThem = "INSERT INTO NhanVien VALUES ('" + cboMaNV.Text + "','" + cboMaPB.Text + "','" + cboCN.Text + "','" + cboCV.Text + "','" + cboHD.Text + "',N'" + txtHoTen.Text + "',N'" + txtGioiTinh.Text + "','" + txtQueQuan.Text +"',N'" + dateTimePicker1.Text.Trim()+ "','" + txtSDT.Text + "',NEWID())";

                try
                {
                    SqlCommand cmd = new SqlCommand(sqlThem, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(sqlThem + " :" + ex);
                }
                con.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            con = kn.conDB_CN1();
            con.Open();
            string sqlThem = "DELETE From NHANVIEN Where Manv = '"+cboMaNV.Text+"'";

            try
            {
                SqlCommand cmd = new SqlCommand(sqlThem, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
            }
            catch (Exception ex)
            {

                MessageBox.Show(sqlThem + " :" + ex);
            }
            con.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            con = kn.conDB_CN1();
            con.Open();
            string sqlThem = "Update NhanVien " +
                              "Set MaNV ='"+ cboMaNV.Text + "'," +
                                  "MaPB ='"+ cboMaPB.Text + "'," + 
                                  "MaCN ='"+ cboCN.Text + "'," + 
                                  "MaCV ='"+ cboCV.Text + "'," + 
                                  "MaHD ='"+ cboHD.Text + "'," + 
                                  "HoTen =N'"+ txtHoTen.Text + "'," + 
                                  "GioiTinh =N'"+ txtGioiTinh.Text + "'," + 
                                  "QueQuan =N'"+ txtQueQuan.Text + "'," + 
                                  "NgaySinh ='"+ dateTimePicker1.Text.Trim() + "'," + 
                                  "SDT ='"+ txtSDT.Text + "' "+
                              "Where MaNV = '"+ cboMaNV.Text +"'";

            try
            {
                SqlCommand cmd = new SqlCommand(sqlThem, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex)
            {

                MessageBox.Show(sqlThem + " :" + ex);
            }
            con.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn muốn đóng màn hình này không?", "Thông báo", MessageBoxButtons.YesNo,
             MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (res == DialogResult.Yes)
                Close();
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            cboMaNV.Text = "";
            cboMaPB.Text = "";
            cboCN.Text = "";
            cboCV.Text = "";
            cboHD.Text = "";
            txtHoTen.Text = "";
            txtGioiTinh.Text = "";
            txtQueQuan.Text = "";
            dateTimePicker1.Text = null ;
            txtSDT.Text = "";
            loadNV();
        }
    }
}
