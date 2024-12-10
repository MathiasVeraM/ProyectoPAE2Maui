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
                List<Publicacion> publicaciones = new List<Publicacion>();

                if (File.Exists(_fileName))
                {
                    string json_data = File.ReadAllText(_fileName);
                    publicaciones = JsonConvert.DeserializeObject<List<Publicacion>>(json_data) ?? new List<Publicacion>();
                }

                publicaciones.Add(publicacion);

                string updated_json_data = JsonConvert.SerializeObject(publicaciones);
                File.WriteAllText(_fileName, updated_json_data);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Publicacion> DevuelveInfoPublicacion(int id)
        {
            Publicacion publicacion = new Publicacion();
            try
            {
                if (File.Exists(_fileName))
                {
                    string json_data = File.ReadAllText(_fileName);
                    return JsonConvert.DeserializeObject<List<Publicacion>>(json_data);
                }
                return new List<Publicacion>();
            }
            catch (Exception)
            {
                return new List<Publicacion>();
            }
        }

        public bool EliminarPublicacion(int id)
        {
            throw new NotImplementedException();
        }
    }
}
