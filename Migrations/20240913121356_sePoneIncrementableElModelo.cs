using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiCrud.Migrations
{
    /// <inheritdoc />
    public partial class sePoneIncrementableElModelo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // SQL para alterar la columna en MySQL
            migrationBuilder.Sql(
                "ALTER TABLE `Productos` MODIFY COLUMN `IdProducto` INT NOT NULL AUTO_INCREMENT;");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // SQL para revertir la columna a su estado anterior (si es necesario)
            migrationBuilder.Sql(
                "ALTER TABLE `Productos` MODIFY COLUMN `IdProducto` INT NOT NULL;");
        }
    }
}
