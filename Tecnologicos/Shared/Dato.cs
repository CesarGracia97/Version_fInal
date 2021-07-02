using System;
using System.Collections.Generic;

#nullable disable

namespace Tecnologico.Shared.Models
{
    public partial class Dato
    {
        public int Id { get; set; }
        public string NombreCliente { get; set; }
        public string Producto { get; set; }
        public double Precio { get; set; }
        public bool Stock { get; set; }
    }
}
