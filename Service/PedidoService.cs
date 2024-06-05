using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class PedidoService
    {
        private IPedidoRepository _pedidoRepository;
        private IItemRepoository _itemRepository;

        public PedidoService()
        {
            _pedidoRepository = new PedidoRepository();
            _itemRepository = new ItemRepository();
        }

        public bool Inserir(Pedido pedido)
        {
            int idItem = _itemRepository.Inserir(pedido.Item);
            pedido.Item.Id = idItem;
            return _pedidoRepository.Inserir(pedido);
        }

        public List<Pedido> GetAll()
        {
            return _pedidoRepository.GetAll();
        }
    }
}
