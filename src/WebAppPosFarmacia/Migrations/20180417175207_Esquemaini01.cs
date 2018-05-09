using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebAppPosFarmacia.Migrations
{
    public partial class Esquemaini01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CiudadCliente",
                columns: table => new
                {
                    CodigoCiudad = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DescripcionCiudad = table.Column<string>(nullable: true),
                    NombreCiudad = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CiudadCliente", x => x.CodigoCiudad);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    IdCliente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ApellidoCliente = table.Column<string>(nullable: true),
                    CodigoCiudad = table.Column<int>(nullable: false),
                    EmailCliente = table.Column<string>(nullable: true),
                    GeneroCliente = table.Column<string>(nullable: true),
                    NombreCliente = table.Column<string>(nullable: true),
                    TelefonoCliente = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.IdCliente);
                    table.ForeignKey(
                        name: "FK_Clientes_CiudadCliente_CodigoCiudad",
                        column: x => x.CodigoCiudad,
                        principalTable: "CiudadCliente",
                        principalColumn: "CodigoCiudad",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_CodigoCiudad",
                table: "Clientes",
                column: "CodigoCiudad");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "CiudadCliente");
        }
    }
}
