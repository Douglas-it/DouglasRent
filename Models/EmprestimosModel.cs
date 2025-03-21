namespace DouglasRent.Models
{
    public class EmprestimosModel
    {
        //Campos da tabela emprestimos no banco de dados
        public int id { get; set; }
        public string Recebedor { get; set; }

        public string Fornecedor  { get; set; }

        public string LivroEmprestado { get; set; }

        public Datetime DataEmprestimo { get; set; } = DateTime.Now;

    }
}
