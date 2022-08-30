using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace asp.netCore5WebAPI.Models
{
    public partial class MVC_UserDB2Context : DbContext
    {
        public MVC_UserDB2Context()
        {
        }

        public MVC_UserDB2Context(DbContextOptions<MVC_UserDB2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<DepartmentTable2> DepartmentTable2s { get; set; }
        public virtual DbSet<UserTable2> UserTable2s { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=MVC_UserDB2;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Chinese_Taiwan_Stroke_CI_AS");

            modelBuilder.Entity<DepartmentTable2>(entity =>
            {
                entity.HasKey(e => e.DepartmentId);

                entity.ToTable("DepartmentTable2");

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DepartmentYear)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UserTable2>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_UserTable");

                entity.ToTable("UserTable2");

                entity.Property(e => e.UserBirthDay).HasColumnType("datetime");

                entity.Property(e => e.UserMobilePhone).HasMaxLength(15);

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.UserSex)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'M')")
                    .IsFixedLength(true);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.UserTable2s)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_UserTable2_DepartmentTable2");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
