using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoWeb.Migrations
{
    /// <inheritdoc />
    public partial class Modelos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cedula_clientes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre_cliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos_cliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correo_cliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contrasena_cliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono_cliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion_cliente = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colaborador",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cedula_colaborador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre_colaborador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos_colaborador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correo_colaborador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contrasena_colaborador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono_colaborador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion_colaborador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salario_colaborador = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colaborador", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id_rol = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_rol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion_rol = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id_rol);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Colaborador");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
