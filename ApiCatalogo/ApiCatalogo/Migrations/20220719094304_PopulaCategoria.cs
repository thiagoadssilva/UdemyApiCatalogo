using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    public partial class PopulaCategoria : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO categorias (Nome, ImagemUri) VALUES('Babidas', 'bebidas.jpg')");
            mb.Sql("INSERT INTO categorias (Nome, ImagemUri) VALUES('Lanches', 'lanches.jpg')");
            mb.Sql("INSERT INTO categorias (Nome, ImagemUri) VALUES('Sobremesas', 'sobremesas.jpg')");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM categorias");
        }
    }
}
