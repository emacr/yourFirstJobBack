﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yourFirstJobBackend.Entidades.entities;

namespace yourFirstJobBackend.Entidades.Request
{
    public class ReqEliminarArchivosUsuario
    {
        public int idUsuario {  get; set; }
        public int idArchivosUsuarios { get; set; }
    }
}