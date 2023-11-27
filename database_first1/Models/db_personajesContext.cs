using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace database_first1.Models
{
    public partial class db_personajesContext : DbContext
    {
        public db_personajesContext()
        {
        }

        public db_personajesContext(DbContextOptions<db_personajesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Libro> Libros { get; set; } = null!;
        public virtual DbSet<Personaje> Personajes { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            { 
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Libro>(entity =>
            {
                entity.HasKey(e => e.LibId)
                    .HasName("PK__Libros__33473CC638A7AE8F");

                entity.Property(e => e.LibId).HasColumnName("lib_Id");

                entity.Property(e => e.LibAutor)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("lib_Autor");

                entity.Property(e => e.LibGenero)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("lib_Genero");

                entity.Property(e => e.LibNombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("lib_Nombre");

                entity.Property(e => e.LibStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("lib_Status");

                entity.Property(e => e.LibTipoProyecto)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("lib_TipoProyecto");
            });

            modelBuilder.Entity<Personaje>(entity =>
            {
                entity.HasKey(e => e.PerId)
                    .HasName("PK__Personaj__32A0223F7005953A");

                entity.Property(e => e.PerId).HasColumnName("per_Id");

                entity.Property(e => e.PerApellido)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("per_Apellido");

                entity.Property(e => e.PerDescripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("per_Descripcion");

                entity.Property(e => e.PerFechaNacimiento)
                    .HasColumnType("date")
                    .HasColumnName("per_FechaNacimiento");

                entity.Property(e => e.PerLibId).HasColumnName("per_libId");

                entity.Property(e => e.PerLugarNacimiento)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("per_LugarNacimiento");

                entity.Property(e => e.PerNombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("per_Nombre");

                entity.Property(e => e.PerRolId).HasColumnName("per_rolId");

                entity.Property(e => e.PerStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("per_Status");

                entity.HasOne(d => d.PerLib)
                    .WithMany(p => p.PersonajePerLibs)
                    .HasForeignKey(d => d.PerLibId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Personaje__per_l__48CFD27E");

                entity.HasOne(d => d.PerRol)
                    .WithMany(p => p.PersonajePerRols)
                    .HasForeignKey(d => d.PerRolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Personaje__per_r__49C3F6B7");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.RolId)
                    .HasName("PK__Roles__CF31E07B84968F5F");

                entity.Property(e => e.RolId).HasColumnName("rol_Id");

                entity.Property(e => e.RolDescripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("rol_Descripcion");

                entity.Property(e => e.RolStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("rol_Status");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
