using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;

namespace CSDLPT_NHANVIEN.Model
{
    class KetNoiCSDL
    {
        public SqlConnection conDB()
        {
            SqlConnection con = new SqlConnection(@"Data Source=MMTNGUYENTRONGL\SERVER;Initial Catalog=QLNHANVIEN4;Persist Security Info=True;User ID=sa;Password=123");
            return con;
        }
        public SqlConnection conDB_CN1()
        {
            SqlConnection con = new SqlConnection(@"Data Source=MMTNGUYENTRONGL\CLIENT1;Initial Catalog=QLNHANVIEN4;Persist Security Info=True;User ID=sa;Password=123");
            return con;
        }
        public SqlConnection conDB_CN2()
        {
            SqlConnection con = new SqlConnection(@"Data Source=MMTNGUYENTRONGL\CLIENT2;Initial Catalog=QLNHANVIEN4;Persist Security Info=True;User ID=sa;Password=123");
            return con;
        }
    }
}
