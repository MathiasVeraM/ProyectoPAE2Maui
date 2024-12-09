﻿using ProyectoPAE2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAE2.Interfaces
{
    public interface IUsuarioRepository
    {
        bool CrearUsuario(Usuario usuario);
        bool ActualizarUsuario(Usuario usuario);
        bool EliminarUsuario(Usuario usuario);
        Usuario DevuelveInfoUsuario(int id);

    }
}