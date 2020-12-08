using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace Homework8_AssignmentTracker.Models
{
    public partial class DBHomework8Context : DbContext
    {
        /*private IConfiguration config;
        public DBHomework8Context(IConfiguration _config)
        {
            config = _config;
        }*/
        public DBHomework8Context()
        {

        }

        public DBHomework8Context(DbContextOptions<DBHomework8Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Assignment> Assignments { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:homework8.database.windows.net,1433;Initial Catalog=DBHomework8;Persist Security Info=False;User ID=hw8admin;Password=KumariDip2121;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Assignment>(entity =>
            {
                entity.Property(e => e.AssignmentNotes)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AssignmentTags)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AssignmentTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.Property(e => e.TagName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
