﻿using System;
using System.Collections.Generic;

namespace Model.Entities
{
    public partial class Clientes
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public int? FechaCreacion { get; set; }
        public bool? IsActive { get; set; }
    }
}
