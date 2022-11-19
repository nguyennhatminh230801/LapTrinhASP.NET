using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace De2.Models
{
    public class SanPham
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public int SoLuong { get; set; }
        public double GiaTien { get; set; }
        public double ThanhTien { 
            get { return SoLuong * GiaTien; } 
        }

        public SanPham()
        {

        }

        public SanPham(string maSP, string tenSP, int soLuong, double giaTien)
        {
            MaSP = maSP;
            TenSP = tenSP;
            SoLuong = soLuong;
            GiaTien = giaTien;
        }
    }
}