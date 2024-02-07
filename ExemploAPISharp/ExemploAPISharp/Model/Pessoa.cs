namespace ExemploAPISharp.Model
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NomeroCelular { get; set; }
        public DateOnly DataNascimento { get; set; }
    }
}
