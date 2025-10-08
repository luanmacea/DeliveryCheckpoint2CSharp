using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryCheckpoint2CSharp.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string SenhaHash { get; set; }
        public string Tipo { get; set; } // admin, funcionario, etc.
    }
}
