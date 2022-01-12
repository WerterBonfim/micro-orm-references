namespace Werter.RepoDbReference.Models
{
    public class Pessoa
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataHoraCadastro { get; set; }
    }
}
