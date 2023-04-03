using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CSDLPT_NHANVIEN.Model;
namespace CSDLPT_NHANVIEN.Controller
{
    class NhanVienController
    {
        NhanVienModel nvien = new NhanVienModel();

        public DataTable HienThiDuLieu()
        {
            return nvien.HienThiDuLieu();
        }
        public DataTable HienThiDuLieuTK(string manv)
        {
            return nvien.HienThiDuLieuTimKiem(manv);
        }
        public DataTable HienThiDuLieuTimKiem1(string manv)
        {
            return nvien.HienThiDuLieuTimKiem1(manv);
        }

        public bool KiemTraMaTonTai(string manhanvien)
        {
            return nvien.kiemTraTonTai(manhanvien);
        }
        public DataTable HienThiDuLieu2()//CN02
        {
            return nvien.HienThiDuLieu2();
        }
        public DataTable HienThiDuLieuTimmkiem2(string manv)
        {
            return nvien.HienThiDuLieuTimKiem2(manv);
        }

        public DataTable HienThiDuLieuTimmkiem2_2(string manv)
        {
            return nvien.HienThiDuLieuTimKiem2_2(manv);
        }
       
        
    }
}
