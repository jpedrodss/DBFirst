﻿using DataBaseFirst.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataBaseFirst.Repositories
{
    public class ProdutoRepository
    {
        private readonly PedidoContext _ctx;

        public ProdutoRepository()
        {
            _ctx = new PedidoContext();
            _ctx.Pedidos
        }
    }
}
