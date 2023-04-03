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
    class DangNhapModelcs
    {
        SqlConnection conn;
        SqlCommand cmd = new SqlCommand();

        KetNoiCSDL kn = new KetNoiCSDL();
        //đóng mở kết nối csdl
        public int ExecuteNonQuery(string sql)
        {
            int dung = 0;
            try
            {
                conn = kn.conDB();
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
