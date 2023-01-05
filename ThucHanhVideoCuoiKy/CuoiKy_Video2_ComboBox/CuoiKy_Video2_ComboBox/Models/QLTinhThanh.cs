using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CuoiKy_Video2_ComboBox.Models
{
    public partial class QLTinhThanh : DbContext
    {
        public QLTinhThanh()
            : base("name=QLTinhThanh")
        {
        }

        public virtual DbSet<Huyen> Huyens { get; set; }
        public virtual DbSet<Tinh> Tinhs { get; set; }
        public virtual DbSet<Xa> Xas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
