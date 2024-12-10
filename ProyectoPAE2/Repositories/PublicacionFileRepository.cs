using Newtonsoft.Json;
using ProyectoPAE2.Interfaces;
using ProyectoPAE2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAE2.Repositories
{
    public class PublicacionFileRepository : IPublicacionRepository
    {
        public string _fileName = Path.Combine(FileSystem.AppDataDirectory, "publicaciones.txt");
        public bool ActualizarPublicacion(Publicacion publicacion)
        {
            throw new NotImplementedException();
        }

        public bool CrearPublicacion(Publicacion publicacion)
        {
            try
            {
                string json_data = JsonConvert.SerializeObject(publicacion);
                File.WriteAllText(_fileName, json_data);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Publicacion DevuelveInfoPublicacion(int id)
        {
            Publicacion publicacion = new Publicacion();
            try
            {
                if (File.Exists(_fileName))
                {
                    string json_data = File.ReadAllText(_fileName);
                    publicacion = JsonConvert.DeserializeObject<Publicacion>(json_data);

                }
            }
            catch (Exception)
            {
                throw;
            }

            return publicacion;
        }

        public bool EliminarPublicacion(int id)
        {
            throw new NotImplementedException();
        }
    }
}
