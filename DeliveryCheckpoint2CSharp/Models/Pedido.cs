using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryCheckpoint2CSharp.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public DateTime Data { get; set; }
        public string Status { get; set; } // Aberto, Em preparo, Saiu para entrega, Entregue

        public List<ProdutoPedido> Produtos { get; set; } = new();
    }

    public class ProdutoPedido
    {
        public int Id { get; set; }
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }

        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }

        public int Quantidade { get; set; }
    }
}
