using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WebAppPosFarmacia.models;

namespace WebAppPosFarmacia.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAppPosFarmacia.models.CiudadCliente", b =>
                {
                    b.Property<int>("CodigoCiudad")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DescripcionCiudad");

                    b.Property<string>("NombreCiudad");

                    b.HasKey("CodigoCiudad");

                    b.ToTable("CiudadCliente");
                });

            modelBuilder.Entity("WebAppPosFarmacia.models.Clientes", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApellidoCliente");

                    b.Property<int>("CodigoCiudad");

                    b.Property<string>("EmailCliente");

                    b.Property<string>("GeneroCliente");

                    b.Property<string>("NombreCliente");

                    b.Property<int>("TelefonoCliente");

                    b.HasKey("IdCliente");

                    b.HasIndex("CodigoCiudad");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("WebAppPosFarmacia.models.Clientes", b =>
                {
                    b.HasOne("WebAppPosFarmacia.models.CiudadCliente", "CiudadCliente")
                        .WithMany("Clientes")
                        .HasForeignKey("CodigoCiudad")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
