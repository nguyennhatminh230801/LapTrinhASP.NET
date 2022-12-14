using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Bai4Phieu1.Models
{
    public class TienDien
    {
        [DisplayName("Tên Chủ Hộ: ")]
        public string TenChuHo { get; set; }

        [DisplayName("Số Điện Tiêu Thụ: ")]
        public double SoDienTieuThu { get; set; }

        [DisplayName("Giá Tiền: ")]
        public double GiaTien { get; set; }

        public TienDien(string tenChuHo)
        {
            TenChuHo = tenChuHo;
        }

        public void Calculate(double inVal, double outVal, string loaiDien, string isHoUuTien)
        {
            double value1 = outVal - inVal;
            double answer = 0;

            answer += Math.Max(value1 - 100, 0) * 2000;
            value1 -= 100;
            answer += Math.Max(value1 - 50, 0) * 2500;
            value1 -= 50;
            answer += Math.Max(value1 - 50, 0) * 3000;
            value1 -= 50;
            answer += Math.Max(value1, 0) * 4000;

            double heSo = 0;

            if(loaiDien == "Sản Xuất")
            {
                heSo = 0.3;
            }
            else if (loaiDien == "Kinh Doanh")
            {
                heSo = 0.2;
            }
            else
            {
                heSo = 0;
            }

            if(isHoUuTien.ToLower().Equals("on"))
            {
                heSo -= 0.1;
            }
            
            answer += (heSo * answer);
            
            SoDienTieuThu = outVal - inVal;
            GiaTien = answer;
        }
    }
}