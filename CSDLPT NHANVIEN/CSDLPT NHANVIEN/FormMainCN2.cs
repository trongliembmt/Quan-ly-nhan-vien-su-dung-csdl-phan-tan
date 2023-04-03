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
    public partial class Form_CN02_Main : Form
    {
        string Quyen = "";
        string MaCN = "";
        string MaNV = "";
        public Form_CN02_Main()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        public Form_CN02_Main(string Quyen, string MaCN, string MaNV)
        {
            InitializeComponent();
            this.Quyen = Quyen;
            this.MaCN = MaCN;
            this.MaNV = MaNV;
            this.MaximizeBox = false;
        }

        private void Form_CN02_Main_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QUANLYLUONG_CN2 luong = new QUANLYLUONG_CN2();
            luong.ShowDialog();
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QLNHANVIEN_CN2 ft = new QLNHANVIEN_CN2();
           ft.ShowDialog();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TimKiemCN2 tk = new TimKiemCN2();
            tk.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn muốn đóng màn hình này không?", "Thông báo", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (res == DialogResult.Yes)
                Close();
        }
    }
}
