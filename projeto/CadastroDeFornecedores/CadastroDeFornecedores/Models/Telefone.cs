using System;

namespace CadastroDeFornecedores.Models
{
    public class Telefone
    {
        public virtual string Id { get; set; }
        public virtual string Numero { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }

        public Telefone()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}