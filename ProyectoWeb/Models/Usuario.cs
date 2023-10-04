﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoWeb.Models;

public partial class Usuario
{
    [Key]
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Apellidos { get; set; }

    public string? Correo { get; set; }

    public string? Contrasena { get; set; }

    public int? Rol { get; set; }
}
