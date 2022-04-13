﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.EntitiesDTO
{
    public class LibrosDTO
    {
        public int idLibro { get; set; }
        public int idCategoria { get; set; }
        public string nombre { get; set; }
        public string autor { get; set; }
        public System.DateTime fechaPublicacion { get; set; }
    }
}
