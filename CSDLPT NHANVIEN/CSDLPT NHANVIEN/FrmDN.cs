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
namespace CSDLPT_NHANVIEN
{
    public partial class FrmDN : Form
    {
        public FrmDN()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }
        KetNoiCSDL kn = new KetNoiCSDL();
        SqlConnection con;
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            string userName = txtDN.Text;
            string passWord = txtMK.Text;
            if (cboCN.Text == "")
            {
                MessageBox.Show("Vui lòng chọn chi nhánh!!!");
            }
            else if (cboCN.Text == "TPHCM")
            {
                con = kn.conDB_CN1();
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from DANGNHAP where TENDN='" + txtDN.Text + "'and MK='" + txtMK.Text + "' and ChucVu ='"+cboCV.Text+"'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    this.Hide();
                    MessageBox.Show("Thành Công");
                    FormMain CN01 = new FormMain(cboCV.Text, cboCN.Text, dt.Rows[0][1].ToString());
                    CN01.Show();

                }
                else
                {
                    MessageBox.Show("Thất Bại!!!");
                }
                con.Close();
            }
            else
            {
                con = kn.conDB_CN2();
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from DANGNHAP where TENDN='" + txtDN.Text + "'and MK='" + txtMK.Text + "' and CHUCVU=N'" + cboCV.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    this.Hide();
                    MessageBox.Show("Thành Công");
                    Form_CN02_Main CN02 = new Form_CN02_Main(cboCV.Text, cboCN.Text, dt.Rows[0][1].ToString());
                    CN02.Show();

                }
                else
                {
                    MessageBox.Show("Thất Bại!!!");
                }
                con.Close();
            }
        }

        private void FrmDN_Load(object sender, EventArgs e)
        {
            
        }
    }
}
