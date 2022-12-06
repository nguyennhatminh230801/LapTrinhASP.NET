namespace OnTapKT2ASP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sanpham")]
    public partial class Sanpham
    {
        [Key]
        [DisplayName("Mã sản phẩm")]
        public int Mavd { get; set; }

        [Required(ErrorMessage = "Tên sản phẩm không được để trống!!")]
        [DisplayName("Tên sản phẩm")]
        [StringLength(100)]
        public string Tenvd { get; set; }

        [StringLength(250)]

        [DisplayName("Ảnh bìa")]
        public string TenAnh { get; set; }

        [Required(ErrorMessage = "Mô tả không được để trống!!")]
        [StringLength(250)]
        [DisplayName("Mô tả")]
        public string Mota { get; set; }

        [DisplayName("Giá tiền")]
        public decimal Giatien { get; set; }

        [DisplayName("Số lượng")]
        public int? Soluong { get; set; }

        [DisplayName("Mã danh mục")]
        public int MaDanhmuc { get; set; }

        public virtual Danhmuc Danhmuc { get; set; }
    }
}
