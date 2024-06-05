using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Pedido
    {
        //public static readonly string GETALL = "SELECT p.Id, p.Descricao, p.Mesa ,i.Descricao FROM Pedido p INNER JOIN Item i ON p.item = i.Id";
        public static readonly string GETALL = "SELECT p.Id, p.Descricao, p.Mesa, i.Id,i.Descricao FROM Pedido p INNER JOIN Item i ON p.item = i.Id";

        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Mesa { get; set; }
        public Item Item { get; set; }

        public override string? ToString()
        {
            return $"Id Pedido: {Id}\nDescicao: {Descricao}\nMesa {Mesa}\nId Item: {Item.Id}\nDesc Item: {Item.Descricao}";
        }
    }
}
