namespace GestaoJogos.Models
{
    public class Jogo
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string? Desenvolvedora { get; set; }
        public string? Genero { get; set; }
        public int AnoLancamento { get; set; }
        public int Preco { get; set; }
    }
}