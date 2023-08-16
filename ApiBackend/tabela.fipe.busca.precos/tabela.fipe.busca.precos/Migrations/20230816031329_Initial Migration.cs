using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tabela.fipe.busca.precos.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Placas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Valor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnoModelo = table.Column<int>(type: "int", nullable: false),
                    Combustivel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodigoFipe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MesReferencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoVeiculo = table.Column<int>(type: "int", nullable: false),
                    SiglaCombustivel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataConsulta = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Placas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Placas");
        }
    }
}
