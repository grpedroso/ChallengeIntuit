using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChallengeIntuit.Migrations
{
    /// <inheritdoc />
    public partial class DatosTabela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Clientes", new string[] {"Id", "Nombre", "Apellidos", "FechaNacimiento", "Cuit", "Domicilio", "TelefonoCelular", "Email"
            }, new object[] { 1, "Gabriel", "Rinco Pedroso", "2003-03-21", "1234567", "Calle 40", "2216205852", "gabreilpedrosor@gmail.com" });

            migrationBuilder.InsertData("Clientes", new string[] {"Id", "Nombre", "Apellidos", "FechaNacimiento", "Cuit", "Domicilio", "TelefonoCelular", "Email"
            }, new object[] { 2, "Juan", "Gomez", "2002-02-06", "2335647", "Calle 12", "2216212352", "juangomez@gmail.com" });

            migrationBuilder.InsertData("Clientes", new string[] {"Id", "Nombre", "Apellidos", "FechaNacimiento", "Cuit", "Domicilio", "TelefonoCelular", "Email"
            }, new object[] { 3, "Camila", "Perez", "1995-12-25", "1232144", "Calle 89", "22123478569", "camilaperez@gmail.com" });

            migrationBuilder.InsertData("Clientes", new string[] {"Id", "Nombre", "Apellidos", "FechaNacimiento", "Cuit", "Domicilio", "TelefonoCelular", "Email"
            }, new object[] { 4, "Facundo", "Milan", "2009-04-01", "13216456", "Calle Florida", "11955562103", "facundomilan@hotmail.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Clientes");
        }
    }
}
