namespace Cadastros.Domain.Models {
    public class Pessoas {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string SiglaUF { get; set; }
        public Estados Estado { get; set; }
        public string DataNascimento { get; set; }
    }
}