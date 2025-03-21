using System;

namespace DouglasRent.Models
{
    public class EmprestimosModel
    {
        //Fields from the loans table in the database
        public int id { get; set; }
        public string Recebedor { get; set; }

        public string Fornecedor  { get; set; }

        public string LivroEmprestado { get; set; }

        public DateTime DataUltimaUtilizacao { get; set; } = DateTime.Now;

    }
}
