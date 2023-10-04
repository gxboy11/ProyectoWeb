using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoWeb.Models
{
    public partial class Clientes
    {
        [Key]
        public int Id { get; set; }
        public string? Cedula_clientes { get; set; }

        public string? Nombre_cliente { get; set; }

        public string? Apellidos_cliente { get; set; }

        public string? Correo_cliente { get; set; }

        public string? Contrasena_cliente { get; set; }

        public string? Telefono_cliente { get; set; }
        public string? Direccion_cliente { get; set; }
    }
}


