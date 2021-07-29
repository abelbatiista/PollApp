using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Database.Models
{
    public partial class C6_PP_T9Context : DbContext
    {
        public C6_PP_T9Context()
        {
        }

        public C6_PP_T9Context(DbContextOptions<C6_PP_T9Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Poll> Polls { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<SysUser> SysUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#pragma warning disable CS1030 // #warning directive
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=C6_PP_T9;Trusted_Connection=True;");
#pragma warning restore CS1030 // #warning directive
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Answer>(entity =>
            {
                entity.HasKey(e => new { e.AnswerId, e.QuestionId })
                    .HasName("PK__Answer__045E56FE9A3D946E");

                entity.ToTable("Answer");

                entity.Property(e => e.AnswerId).ValueGeneratedOnAdd();

                entity.Property(e => e.Title).HasColumnType("text");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Answers)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Answer__PersonId__300424B4");

                entity.HasOne(d => d.Poll)
                    .WithMany(p => p.Answers)
                    .HasForeignKey(d => d.PollId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Answer__PollId__2E1BDC42");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.Answers)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Answer__Question__2F10007B");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("Person");

                entity.HasOne(d => d.Poll)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.PollId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Person__PollId__2B3F6F97");
            });

            modelBuilder.Entity<Poll>(entity =>
            {
                entity.ToTable("Poll");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Polls)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Poll__UserId__25869641");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.ToTable("Question");

                entity.Property(e => e.Title).HasColumnType("text");

                entity.HasOne(d => d.Poll)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.PollId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Question__PollId__286302EC");
            });

            modelBuilder.Entity<SysUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__sysUser__1788CC4C0E13B3D1");

                entity.ToTable("sysUser");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
