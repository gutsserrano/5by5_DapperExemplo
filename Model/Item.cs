using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Item
    {
        public readonly static string INSERT = "INSERT INTO Item (Descricao) VALUES (@Descricao); SELECT CAST(scope_identity() AS int)";

        public int Id { get; set; }
        public string Descricao { get; set; }
    }
}
