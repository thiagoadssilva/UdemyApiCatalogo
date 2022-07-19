using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICatalogo.Models;
[Table("Produtos")]
public class Produto
{
    /*Depois do tipo estamos colocando uma '?' para definir como 'Nullable', pois quando se trata
    do tipo string estamos acessando a propriedade por referencia.*/

    /*Quando a clase só contém propriedades ela é chamada de Anémica*/
    [Key]
    public int ProdutoId { get; set; }
    [Required]
    [StringLength(80)]
    public string? Nome { get; set; }
    [Required]
    [StringLength(300)]
    public string? Descricao { get; set; }
    
    [Column(TypeName = "decimal(10,2)")]
    public decimal Preco { get; set; }
    [Required]
    [StringLength(300)]
    public string? ImagemUri { get; set; }
    public float Estoque { get; set; }
    public DateTime DataCadastro { get; set; }

    /*Explicitando o relacionamento entre as tabelas de categorias e produtos*/
    public int? CategoriaId { get; set; }
    public Categoria? Categoria { get; set; }
}

