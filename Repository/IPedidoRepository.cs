﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IPedidoRepository
    {
        bool Inserir(Pedido pedido);

        List<Pedido> GetAll();
    }
}
