namespace TesteCrudProfessoresAlunos.Models
{
    public class AlunoViewModel
    {
        public string Id { get; set; }

        public string Nome { get; set; }

        public string Mensalidade { get; set; }

        public DateTime Vencimento { get; set; }

        public string IdProfessor { get; set; }
    }
}
