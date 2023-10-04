using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoWeb.Models
{
    public partial class Roles
    {
        [Key]
        public int Id_rol { get; set; }
        public string? Nombre_rol { get; set; }

        public string? Descripcion_rol { get; set; }

    }
}

