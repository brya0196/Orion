﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Orion.Data;

namespace Orion.Data.Migrations
{
    [DbContext(typeof(OrionDbContext))]
    [Migration("20181119002107_AddedCompradorToVenta")]
    partial class AddedCompradorToVenta
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Orion.Data.Models.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CantidadStock");

                    b.Property<int>("CodigoProducto");

                    b.Property<DateTime>("FechaVencimiento");

                    b.Property<string>("Nombre");

                    b.Property<int>("Precio");

                    b.HasKey("Id");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Orion.Data.Models.TiposUsuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("TiposUsuarios");
                });

            modelBuilder.Entity("Orion.Data.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellido");

                    b.Property<string>("Email");

                    b.Property<string>("Nombre");

                    b.Property<string>("Password");

                    b.Property<int?>("TipoUsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("TipoUsuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Orion.Data.Models.Venta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comprador");

                    b.Property<int>("ProductoId");

                    b.Property<int>("VendedorId");

                    b.HasKey("Id");

                    b.HasIndex("ProductoId");

                    b.HasIndex("VendedorId");

                    b.ToTable("Ventas");
                });

            modelBuilder.Entity("Orion.Data.Models.Usuario", b =>
                {
                    b.HasOne("Orion.Data.Models.TiposUsuario", "TipoUsuario")
                        .WithMany()
                        .HasForeignKey("TipoUsuarioId");
                });

            modelBuilder.Entity("Orion.Data.Models.Venta", b =>
                {
                    b.HasOne("Orion.Data.Models.Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Orion.Data.Models.Usuario", "Vendedor")
                        .WithMany()
                        .HasForeignKey("VendedorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
