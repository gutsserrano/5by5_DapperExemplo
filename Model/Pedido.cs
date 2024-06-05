using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Mesa { get; set; }
        public Item Item { get; set; }
    }
}
