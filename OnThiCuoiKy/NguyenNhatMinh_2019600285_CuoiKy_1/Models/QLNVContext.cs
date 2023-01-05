using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace NguyenNhatMinh_2019600285_CuoiKy_1.Models
{
    public partial class QLNVContext : DbContext
    {
        public QLNVContext()
            : base("name=QLNVContext")
        {
        }

        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblUser>()
                .Property(e => e.username)
                .IsUnicode(false);
        }
    }
}
