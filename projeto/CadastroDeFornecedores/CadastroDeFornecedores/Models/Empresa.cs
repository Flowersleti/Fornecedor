
using System;
using System.ComponentModel.DataAnnotations;

namespace CadastroDeFornecedores.Models
{
    public class Empresa
    {
        public virtual string Id { get; set; }
        public virtual string UF { get; set; }
        [Required(ErrorMessage = "'Nome Fantasia' é obrigatório!")]
        public virtual string NomeFantasia { get; set; }
        [Required(ErrorMessage = "'CNPJ' é obrigatório!")]
        public virtual string CNPJ { get; set; }

        public Empresa()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}