using Dapper;
using Model;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class PedidoRepository : IPedidoRepository
    {
        private string _conn { get; set; }

        public PedidoRepository()
        {
            _conn = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
        }

        public bool Inserir(Pedido pedido)
        {
            var result = false;

            using(var db = new SqlConnection(_conn))
            {
                db.Open();

                db.Execute("INSERT INTO Pedido (Descricao, Mesa, item) VALUES (@Descricao, @Mesa, @item)", 
                    new { Descricao = pedido.Descricao, Mesa = pedido.Mesa, Item = pedido.Item.Id});

                result = true;

                db.Close();
            }

            return result;
        }

        public List<Pedido> GetAll()
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();

                var list = db.Query<Pedido, Item, Pedido>(Pedido.GETALL, (pedido, item) =>
                {
                    pedido.Item = item;
                    return pedido;
                }, splitOn: "Id").ToList();
                return (List<Pedido>) list;
            }
        }
    }
}
