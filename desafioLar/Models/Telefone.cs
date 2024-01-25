using System.Text.Json.Serialization;

namespace desafioLar.Models
{
    public class Telefone
    {
        public int TelefoneId { get; set; }
        public string Tipo { get; set; }
        public string Numero { get; set; }

        public int PessoaId { get; set; }

        [JsonIgnore]
        public Pessoa? Pessoa { get; set; }
    }
}
