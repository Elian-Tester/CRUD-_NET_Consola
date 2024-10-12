using System;
using System.Collections.Generic;
using CsharpCodeChallenge.DBModels;
using CsharpCodeChallenge.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CsharpCodeChallenge.DBConnections
{
    public partial class ContextDb : DbContext
    {
        public ContextDb()
        {
        }

        public ContextDb(DbContextOptions<ContextDb> options)
            : base(options)
        {
        }

        public virtual DbSet<Favorite_TV> Favorite_TVs { get; set; } = null!;
        public virtual DbSet<Programs_TV> Programs_TVs { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer(Appsettings._connectionDbSqlServer);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Favorite_TV>(entity =>
            {
                entity.HasOne(d => d.idProgram_TVNavigation)
                    .WithMany(p => p.Favorite_TVs)
                    .HasForeignKey(d => d.idProgram_TV)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Favorite___idPro__3F466844");

                entity.HasOne(d => d.idUserNavigation)
                    .WithMany(p => p.Favorite_TVs)
                    .HasForeignKey(d => d.idUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Favorite___idUse__3E52440B");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
