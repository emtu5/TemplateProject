﻿using net_project.Models.Enums;

namespace net_project.Models.DTOs
{
    public class PostProfesorDTO
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Email { get; set; }
        public RolProfesor Rol { get; set; }
    }
}
