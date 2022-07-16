using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCatalogo.Migrations
{
    public partial class PopulaCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            INSERT INTO apicatalogodb.categorias
(Nome, ImagemUri)
VALUES('', '');

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
