using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    public partial class PopulaProdutos : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO produtos (Nome, Descricao, Preco, ImagemUri, Estoque, DataCadastro, CategoriaId) " +
                "VALUES('Coca-cola', 'Refrigerante de 350ml', 10.00, 'cocacola.jpg', 50, now(), 1)");
            mb.Sql("INSERT INTO produtos (Nome, Descricao, Preco, ImagemUri, Estoque, DataCadastro, CategoriaId) " +
                "VALUES('Coxinha', 'Queijo com catupiry', 5.50, 'coxinha.jpg', 100, now(), 2)");
            mb.Sql("INSERT INTO produtos (Nome, Descricao, Preco, ImagemUri, Estoque, DataCadastro, CategoriaId) " +
                "VALUES('sorvete', 'casquinha', 4.50, 'sorvete.jpg', 10, now(), 2)");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM produtos");
        }
    }
}
