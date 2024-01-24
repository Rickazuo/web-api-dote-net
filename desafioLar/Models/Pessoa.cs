namespace desafioLar.Models
{
    public class Pessoa
    {
        public int PessoaId { get; set; } 
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public bool EstaAtivo { get; set; }

        public ICollection<Telefone> Telefones { get; set; }
    }
}
