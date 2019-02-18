
using System;

namespace CadastroDeFornecedores.Models
{
    public class Empresa
    {
        public virtual string Id { get; set; }
        public virtual string UF { get; set; }
        public virtual string NomeFantasia { get; set; }
        public virtual string CNPJ { get; set; }

        public Empresa()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}