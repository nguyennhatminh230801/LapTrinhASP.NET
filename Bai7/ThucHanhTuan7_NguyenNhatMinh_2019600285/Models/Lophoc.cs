namespace ThucHanhTuan7_NguyenNhatMinh_2019600285.Models
{
    public class Lophoc
    {
        public string malop { get; set; }
        public string tenlop { get; set; }
        public string giangvien { get; set; }
        public Lophoc()
        {

        }
        public Lophoc(string malop, string tenlop, string giangvien)
        {
            this.malop = malop;
            this.tenlop = tenlop;
            this.giangvien = giangvien;
        }
    }
}