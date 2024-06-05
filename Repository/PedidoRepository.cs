using Dapper;
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
            //_conn = "Data Source=127.0.0.1; Initial Catalog=DBRestaurante; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=Yes";
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
    }
}
