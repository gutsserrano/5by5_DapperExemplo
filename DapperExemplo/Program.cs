using Model;
using Controller;

namespace DapperExemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido
            {
                Descricao = "pedido do adalberto",
                Mesa = 2,
                Item = new Item
                {
                    Descricao = "Coca cola"
                }
            };

            if (new PedidoController().Inserir(pedido))
                Console.WriteLine("Pedido inserido com sucesso!");
            else
                Console.WriteLine("Erro ao inserir pedido!");
        }
    }
}
