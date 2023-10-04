using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoWeb.Models
{
    public partial class Colaborador
    {
        [Key]
        public int Id { get; set; }
        public string? Cedula_colaborador { get; set; }

        public string? Nombre_colaborador { get; set; }

        public string? Apellidos_colaborador { get; set; } 

        public string? Correo_colaborador { get; set; }

        public string? Contrasena_colaborador { get; set; }

        public string? Telefono_colaborador { get; set; }
        public string? Direccion_colaborador { get; set; }
        public float Salario_colaborador { get; set; }
    }
}
