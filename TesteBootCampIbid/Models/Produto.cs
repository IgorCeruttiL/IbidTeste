namespace TesteBootCampIbid.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public int ProdutoCategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
    }
}
