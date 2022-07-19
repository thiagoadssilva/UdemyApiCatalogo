using APICatalogo.Models;
using Microsoft.EntityFrameworkCore;

namespace APICatalogo.Context;
/*Essa clase é responsável por fazer todo o mapeamento para o banco de dados esse mapeamente
 é a criação das tabelas que estão sendo representadas pelos atributos dessa classe*/

/*Uma instância dessa classe representa sessão com o banco de dados*/
public class AppDbContext : DbContext
{
    /*Construtor responsável por fazer a configuração do contexto conforme a classe base*/
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    /*O Dbset representa um conjuto de entidades no contexto  que podem ser  consultadas  no 
     banco de dados (Criar, Alterar, Excluir, Consultar)*/
    public DbSet<Categoria>? Categorias { get; set; }
    public DbSet<Produto>? Produtos { get; set; }
}

