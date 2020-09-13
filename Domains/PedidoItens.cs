using System;
using System.Collections.Generic;

namespace DataBaseFirst.Domains
{
    public partial class PedidoItens
    {
        public Guid Id { get; set; }
        public Guid IdPedido { get; set; }
        public Guid IdProduto { get; set; }
        public int Quantidade { get; set; }

        public virtual Pedidos IdPedidoNavigation { get; set; }
        public virtual Produtos IdProdutoNavigation { get; set; }
    }
}
