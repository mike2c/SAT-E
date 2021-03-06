﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class Rol
    {
        public RolId RolId { get; set; }
        public string RolName { get; set; }
        public List<User> Users { get; set; }
    }

    public enum RolId
    {
        SOPORTE_SISTEMAS = 1,
        COMUNICACION_REDES = 2
    }
}
