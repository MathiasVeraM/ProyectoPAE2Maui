using ProyectoPAE2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAE2.Interfaces
{
    public interface IPublicacionRepository
    {
        bool CrearPublicacion(Publicacion publicacion);
        bool ActualizarPublicacion(Publicacion publicacion);
        bool EliminarPublicacion(int id);
        Publicacion DevuelveInfoPublicacion(int id);
    }
}
