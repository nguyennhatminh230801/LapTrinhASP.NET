using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ThucHanhTuan7_NguyenNhatMinh_2019600285.Models
{
    public class SinhVien
    {
        [DisplayName("Mã sv")]
        public string masv { get; set; }
        [DisplayName("Họ tên")]
        public string hoten { get; set; }
        [DisplayName("Tuổi")]
        public int tuoi { get; set; }
        [DisplayName("Địa chỉ")]
        public string diachi { get; set; }
        [DisplayName("Mã lớp")]
        public string malop { get; set; }
        public SinhVien()
        {
        }
        public SinhVien(string masv, string hoten, int tuoi, string diachi, string malop)
        {
            this.masv = masv;
            this.hoten = hoten;
            this.tuoi = tuoi;
            this.diachi = diachi;
            this.malop = malop;
        }
        public override bool Equals(Object obj)
        {
            return this.masv == ((SinhVien)obj).masv;
        }

        public override int GetHashCode()
        {
            int hashCode = -332087342;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(masv);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(hoten);
            hashCode = hashCode * -1521134295 + tuoi.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(diachi);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(malop);
            return hashCode;
        }

    }
}