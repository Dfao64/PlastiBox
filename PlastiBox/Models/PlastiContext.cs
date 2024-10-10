using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PlastiBox.Models;

public partial class PlastiContext : DbContext
{
    public PlastiContext()
    {
    }

    public PlastiContext(DbContextOptions<PlastiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Auditorium> Auditoria { get; set; }

    public virtual DbSet<Canastilla> Canastillas { get; set; }

    public virtual DbSet<Carrito> Carritos { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<RegistroUsuario> RegistroUsuarios { get; set; }

    public virtual DbSet<Reporte> Reportes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
            //        => optionsBuilder.UseSqlServer("server=.\\sqlexpress; database=Plasti; User Id=DESKTOP-RLEI79E\\ASUS; Password=12345; integrated security=true; TrustServerCertificate=True;");
        }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Auditorium>(entity =>
        {
            entity.HasKey(e => e.IdAuditoria);

            entity.ToTable("auditoria");

            entity.Property(e => e.IdAuditoria)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_auditoria");
            entity.Property(e => e.ApellidoAnterior)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apellido_anterior");
            entity.Property(e => e.ApellidoNuevo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apellido_nuevo");
            entity.Property(e => e.ContrasenaAnterior)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contrasena_anterior");
            entity.Property(e => e.ContrasenaNueva)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contrasena_nueva");
            entity.Property(e => e.CorrecoNuevo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("correco_nuevo");
            entity.Property(e => e.CorreoAnterior)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("correo_anterior");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.NombreAnterior)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_anterior");
            entity.Property(e => e.NombreNuevo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_nuevo");
            entity.Property(e => e.TelefonoAnterior).HasColumnName("telefono_anterior");
            entity.Property(e => e.TelefonoNuevo).HasColumnName("telefono_nuevo");
        });

        modelBuilder.Entity<Canastilla>(entity =>
        {
            entity.HasKey(e => e.IdCanastilla);

            entity.ToTable("canastilla");

            entity.Property(e => e.IdCanastilla)
                .ValueGeneratedNever()
                .HasColumnName("id_canastilla");
            entity.Property(e => e.Color)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("color");
            entity.Property(e => e.Costo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("costo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.TipoPlastico)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipo_plastico");
        });

        modelBuilder.Entity<Carrito>(entity =>
        {
            entity.HasKey(e => e.IdCarrito);

            entity.ToTable("carrito");

            entity.Property(e => e.IdCarrito)
                .ValueGeneratedNever()
                .HasColumnName("id_carrito");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.IdCanastilla).HasColumnName("id_canastilla");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.PrecioTotal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("precio_total");
            entity.Property(e => e.Subtotal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("subtotal");
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => e.IdPedido);

            entity.ToTable("pedidos");

            entity.Property(e => e.IdPedido)
                .ValueGeneratedNever()
                .HasColumnName("id_pedido");
            entity.Property(e => e.FechaPedido).HasColumnName("fecha_pedido");
            entity.Property(e => e.IdCarrito).HasColumnName("id_carrito");
            entity.Property(e => e.IdEstado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_estado");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
        });

        modelBuilder.Entity<RegistroUsuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario);

            entity.ToTable("registro_usuario");

            entity.Property(e => e.IdUsuario)
                .ValueGeneratedNever()
                .HasColumnName("id_usuario");
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.Contrasena)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contrasena");
            entity.Property(e => e.Correo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("correo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono).HasColumnName("telefono");
        });

        modelBuilder.Entity<Reporte>(entity =>
        {
            entity.HasKey(e => e.IdReporte);

            entity.ToTable("reportes");

            entity.Property(e => e.IdReporte)
                .ValueGeneratedNever()
                .HasColumnName("id_reporte");
            entity.Property(e => e.IdPedido).HasColumnName("id_pedido");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
