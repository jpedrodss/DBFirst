using System;
using System.Collections.Generic;

namespace DataBaseFirst.Domains
{
    public partial class Pedidos
    {
        public Pedidos()
        {
            PedidoItens = new HashSet<PedidoItens>();
        }

        public Guid Id { get; set; }
        public string Status { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual ICollection<PedidoItens> PedidoItens { get; set; }
    }
}
