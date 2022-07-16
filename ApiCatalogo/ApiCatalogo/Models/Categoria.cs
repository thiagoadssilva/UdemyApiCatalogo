using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCatalogo.Models;
[Table("Categorias")]
public class Categoria
{
    /*É uma boa pratica fazer a inicialização da coleção(relacionamente das tabelas categorias e
     * produtos, através do construtor da clase)*/
    public Categoria()
    {
        Produtos = new Collection<Produto>();
    }


    /*Depois do tipo estamos colocando uma '?' para definir como 'Nullable', pois quando se trata
    do tipo string estamos acessando a propriedade por referencia.*/

    /*Quando a clase só contém propriedades ela é chamada de Anémica*/
    [Key]
    public int CategoriaId { get; set; }
    [Required]
    [StringLength(80)]
    public string? Nome { get; set; }
    [Required]
    [StringLength(300)]
    public string? ImagemUri { get; set; }
    /*Definido uma coleção para tabela de produtos, onde vai ser o relacionamente entre essas
     duas tabelas*/
    public ICollection<Produto>? Produtos { get; set; }
}

