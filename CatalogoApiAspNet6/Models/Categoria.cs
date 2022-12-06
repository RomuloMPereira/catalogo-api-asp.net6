using System.Collections.ObjectModel;

namespace CatalogoApiAspNet6.Models;

public class Categoria
{
    public Categoria()
    {
        Produtos = new Collection<Produto>();
    }

    public int CategoriaId { get; set; }
    public string? Nome { get; set; }
    public string? Descricao { get; set; }

    public ICollection<Produto>? Produtos { get; set; }
}
