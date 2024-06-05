using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ItemService
    {
        private ItemRepository _itemRepository;

        public ItemService()
        {
            _itemRepository = new();
        }

        public int Inserir(Item item)
        {
            return _itemRepository.Inserir(item);
        }
    }
}
