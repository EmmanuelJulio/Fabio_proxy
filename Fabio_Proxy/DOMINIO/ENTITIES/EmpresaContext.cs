using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DOMINIO.ENTITIES
{
    public partial class EmpresaContext : DbContext
    {
        public EmpresaContext()
        {
        }

        public EmpresaContext(DbContextOptions<EmpresaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Diccionario> Diccionario { get; set; }
        public virtual DbSet<ModuloUsuario> ModuloUsuario { get; set; }
        public virtual DbSet<Modulos> Modulos { get; set; }
        public virtual DbSet<Submenu> Submenu { get; set; }
        public virtual DbSet<Submodulos> Submodulos { get; set; }
        public virtual DbSet<TerminosDiccionarios> TerminosDiccionarios { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=PCGRANDE\\DESARROLLO;Database=Empresa;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Diccionario>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DicAbr)
                    .IsRequired()
                    .HasColumnName("dic_abr")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.FechaIncercion).HasColumnType("date");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ModuloUsuario>(entity =>
            {
                entity.ToTable("MODULO/USUARIO");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FechaIncercion).HasColumnType("date");

                entity.Property(e => e.IdModulo).HasColumnName("ID_MODULO");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.HasOne(d => d.IdModuloNavigation)
                    .WithMany(p => p.ModuloUsuario)
                    .HasForeignKey(d => d.IdModulo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MODULO/USUARIO_MODULOS");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.ModuloUsuario)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MODULO/USUARIO_USUARIOS");
            });

            modelBuilder.Entity<Modulos>(entity =>
            {
                entity.ToTable("MODULOS");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CodMod)
                    .IsRequired()
                    .HasColumnName("COD_MOD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaIncercion).HasColumnType("date");

                entity.Property(e => e.NombreMod)
                    .IsRequired()
                    .HasColumnName("NOMBRE_MOD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SectorMod).HasColumnName("SECTOR_MOD");
            });

            modelBuilder.Entity<Submenu>(entity =>
            {
                entity.ToTable("SUBMENU");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FechaIncercion).HasColumnType("date");

                entity.Property(e => e.IdSubmodulo).HasColumnName("ID_SUBMODULO");

                entity.Property(e => e.SubMenuNombre)
                    .IsRequired()
                    .HasColumnName("subMenu_nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubMenuSys)
                    .IsRequired()
                    .HasColumnName("subMenu_Sys")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdSubmoduloNavigation)
                    .WithMany(p => p.Submenu)
                    .HasForeignKey(d => d.IdSubmodulo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SUBMENU_SUBMODULOS");
            });

            modelBuilder.Entity<Submodulos>(entity =>
            {
                entity.ToTable("SUBMODULOS");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FechaIncercion).HasColumnType("date");

                entity.Property(e => e.IdModulo).HasColumnName("ID_MODULO");

                entity.Property(e => e.NombreSubmod)
                    .IsRequired()
                    .HasColumnName("NOMBRE_SUBMOD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SysNom)
                    .IsRequired()
                    .HasColumnName("SYS_NOM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdModuloNavigation)
                    .WithMany(p => p.Submodulos)
                    .HasForeignKey(d => d.IdModulo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SUBMODULOS_MODULOS");
            });

            modelBuilder.Entity<TerminosDiccionarios>(entity =>
            {
                entity.ToTable("TERMINOS/DICCIONARIOS");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FechaIncercion).HasColumnType("date");

                entity.Property(e => e.IdDiccionario).HasColumnName("id_diccionario");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TermAbr)
                    .IsRequired()
                    .HasColumnName("term_abr")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdDiccionarioNavigation)
                    .WithMany(p => p.TerminosDiccionarios)
                    .HasForeignKey(d => d.IdDiccionario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TERMINOS/DICCIONARIOS_Diccionario");
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.ToTable("USUARIOS");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Acceso)
                    .IsRequired()
                    .HasColumnName("acceso")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasColumnName("apellido")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contraseña)
                    .IsRequired()
                    .HasColumnName("contraseña")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FechaIncercion).HasColumnType("date");

                entity.Property(e => e.Legajo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreUsuario)
                    .IsRequired()
                    .HasColumnName("nombre_usuario")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sector)
                    .IsRequired()
                    .HasColumnName("sector")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
