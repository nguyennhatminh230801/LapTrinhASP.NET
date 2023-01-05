using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CuoiKy_Video4_LoginLogout.Models
{
    public partial class QLDangNhapContext : DbContext
    {
        public QLDangNhapContext()
            : base("name=QLDangNhapContext")
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
