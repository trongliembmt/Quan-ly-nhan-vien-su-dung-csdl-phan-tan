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
    class LuongModel
    {
        SqlConnection conn;
        SqlCommand cmd = new SqlCommand();
        KetNoiCSDL kn = new KetNoiCSDL();
        public DataTable HienThiDuLieuLuong2() //trả về 1 bảng
        {
            conn = kn.conDB_CN2();
            conn.Open();
            string sql = "SELECT * FROM LUONG";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable HienThiDuLieuLuong1() //trả về 1 bảng
        {
            conn = kn.conDB_CN1();
            conn.Open();
            string sql = "SELECT * FROM LUONG";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
