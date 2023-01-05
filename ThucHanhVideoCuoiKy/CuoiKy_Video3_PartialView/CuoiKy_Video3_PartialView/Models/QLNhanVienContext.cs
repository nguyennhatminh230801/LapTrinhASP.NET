using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CuoiKy_Video3_PartialView.Models
{
    public partial class QLNhanVienContext : DbContext
    {
        public QLNhanVienContext()
            : base("name=QLNhanVienContext")
        {
        }

        public virtual DbSet<Accout> Accouts { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accout>()
                .Property(e => e.username)
                .IsUnicode(false);
        }
    }
}
