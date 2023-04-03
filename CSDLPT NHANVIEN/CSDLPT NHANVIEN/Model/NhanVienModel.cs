using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace CSDLPT_NHANVIEN.Model
{
    class NhanVienModel
    {
        SqlConnection conn;
        SqlCommand cmd = new SqlCommand();
        KetNoiCSDL kn = new KetNoiCSDL();
        public DataTable HienThiDuLieu() //trả về 1 bảng
        {
            conn = kn.conDB_CN1();
            conn.Open();
            string sql = "SELECT * FROM NHANVIEN";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public DataTable HienThiDuLieuTimKiem(string manv) //trả về 1 bảng
        {
            conn = kn.conDB_CN1();
            conn.Open();
            string sql = "SELECT * FROM NHANVIEN where MaNV='" + manv + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public DataTable HienThiDuLieuTimKiem1(string manv) //trả về 1 bảng
        {
            conn = kn.conDB_CN1();
            conn.Open();
            string sql = "SELECT * FROM NHANVIEN where HoTen LIKE '%" + manv + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
       
        public int ExecuteNonQuery(string sql)
        {
            int dung = 0;
            try
            {
                conn = kn.conDB_CN1();
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                dung = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            { }
            return dung;
        }
        public bool kiemTraTonTai(string maNPP)
        {
            conn = kn.conDB_CN1();
            conn.Open();
            bool tatkt = false;
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT * FROM NHANVIEN where MaNV='" + maNPP + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (maNPP == dr.GetString(0))
                    {
                        tatkt = true;
                        break;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            conn.Close();
            return tatkt;
        }
        public DataTable HienThiDuLieu2() //trả về 1 bảng
        {
            conn = kn.conDB_CN2();
            conn.Open();
            string sql = "SELECT * FROM NHANVIEN";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable HienThiDuLieuTimKiem2(string manv) //trả về 1 bảng
        {
            conn = kn.conDB_CN2();
            conn.Open();
            string sql = "SELECT * FROM NHANVIEN where MaNV='" + manv + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public DataTable HienThiDuLieuTimKiem2_2(string manv) //trả về 1 bảng
        {
            conn = kn.conDB_CN2();
            conn.Open();
            string sql = "SELECT * FROM NHANVIEN where  HoTen Like'%" + manv + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
       
        public int ExecuteNonQuery2(string sql)
        {
            int dung = 0;
            try
            {
                conn = kn.conDB_CN2();
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                dung = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            { }
            return dung;
        }
       
    }
}
