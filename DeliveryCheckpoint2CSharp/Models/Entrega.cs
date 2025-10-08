using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryCheckpoint2CSharp.Models
{
    public class Entrega
    {
        public int Id { get; set; }
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }

        public string Motoboy { get; set; }
        public DateTime DataEntrega { get; set; }
        public string Status { get; set; } // Em trânsito, Entregue, etc.
    }
}
