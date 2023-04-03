using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDLPT_NHANVIEN
{
    public partial class FormMain : Form
    {
        string Quyen = "";
        string MaCN = "";
        string MaNV = "";
        
        public FormMain()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }
        public FormMain(string Quyen, string MaCN, string MaNV)
        {
            InitializeComponent();
            this.Quyen = Quyen;
            this.MaCN = MaCN;
            this.MaNV = MaNV;
            this.MaximizeBox = false;
        }
        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QLNHANVIEN_CN1 ft = new QLNHANVIEN_CN1();
            ft.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (Quyen == "Quản Lý")
            {
                lblNhanSu.Enabled = true;
                lblTienLuong.Enabled = true;
            }
            else if (Quyen == "Nhân Viên")
            {
                lblNhanSu.Enabled = false;
                lblTienLuong.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn muốn đóng màn hình này không?", "Thông báo", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (res == DialogResult.Yes)
                Close();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TimKiemCN1 tk = new TimKiemCN1();
            tk.ShowDialog();
        }

        private void lblTienLuong_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QUANLYLUONG_CN1 luong = new QUANLYLUONG_CN1();
            luong.ShowDialog();
        }
    }
}
