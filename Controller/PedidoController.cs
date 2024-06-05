using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class PedidoController
    {
        private PedidoService _pedidoService;

        public PedidoController()
        {
            _pedidoService = new PedidoService();
        }

        public bool Inserir(Pedido pedido)
        {
            return _pedidoService.Inserir(pedido);
        }
    }
}
