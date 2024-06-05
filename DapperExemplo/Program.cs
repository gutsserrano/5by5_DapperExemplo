using Model;
using Controller;

namespace DapperExemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Pedido pedido = new Pedido
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
                Console.WriteLine("Erro ao inserir pedido!");*/

            var controller = new PedidoController();

            var pedidos = controller.GetAll();

            foreach (var pedido in pedidos)
            {
                Console.WriteLine(pedido);
            }
        }
    }
}
