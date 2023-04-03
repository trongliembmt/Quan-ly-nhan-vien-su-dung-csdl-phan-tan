using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CSDLPT_NHANVIEN.Model;

namespace CSDLPT_NHANVIEN.Controller
{
    class LuongController
    {
        LuongModel luong = new LuongModel();
        public DataTable HienThiDuLieuLuong2()
        {
            return luong.HienThiDuLieuLuong2();
        }
        public DataTable HienThiDuLieuLuong1()
        {
            return luong.HienThiDuLieuLuong1();
        }
    }
}
