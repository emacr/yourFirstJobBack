﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yourFirstJobBackend.Entidades.entities;

namespace yourFirstJobBackend.Entidades.Response
{
    public class ResObtenerAplicaciones
    {
        public List<Aplicaciones> aplicaciones { get; set; }
    }
}