using System;
using System.ComponentModel.DataAnnotations;

namespace CadastroDeFornecedores.Models
{
    public class Fornecedor
    {
        public virtual string Id { get; set; }
        public virtual Empresa Empresa { get; set; }
        [Required(ErrorMessage = "'Nome' é obrigatório!")]
        public virtual string Nome { get; set; }
        [Required(ErrorMessage = "'CPF/CNPJ' é obrigatório!")]
        public virtual string CPFCNPJ { get; set; }
        public virtual DateTime Cadastro { get; set; }
        public virtual DateTime DataNascimento { get; set; }
        public virtual string RG { get; set; }

        public Fornecedor()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}