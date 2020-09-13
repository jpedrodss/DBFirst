using System;
using System.Collections.Generic;

namespace DataBaseFirst.Domains
{
    public partial class Produtos
    {
        public Produtos()
        {
            PedidoItens = new HashSet<PedidoItens>();
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        public virtual ICollection<PedidoItens> PedidoItens { get; set; }
    }
}
