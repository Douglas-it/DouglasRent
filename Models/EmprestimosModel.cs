using System;
using System.ComponentModel.DataAnnotations;

namespace DouglasRent.Models
{
    public class EmprestimosModel
    {
        //Fields from the loans table in the database
        public int id { get; set; }

        [Required (ErrorMessage ="Digite o nome do Recebedor ")]
        public string Recebedor { get; set; }

        [Required(ErrorMessage = "Digite o nome do Fornecedor  ")]
        public string Fornecedor  { get; set; }

        [Required(ErrorMessage = "Digite o nome do Livro Emprestado ")]
        public string LivroEmprestado { get; set; }

        public DateTime DataUltimaUtilizacao { get; set; } = DateTime.Now;

    }
}
