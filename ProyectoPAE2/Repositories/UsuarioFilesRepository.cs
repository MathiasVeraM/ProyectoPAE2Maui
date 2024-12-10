using Newtonsoft.Json;
using ProyectoPAE2.Interfaces;
using ProyectoPAE2.Models;
using System.Security.Cryptography.X509Certificates;

namespace ProyectoPAE2.Repositories
{
    public class UsuarioFilesRepository : IUsuarioRepository
    {
        public string _fileName = Path.Combine(FileSystem.AppDataDirectory, "usuarios.txt");
        public bool ActualizarUsuario(Usuario usuario)
        {

            throw new NotImplementedException();
        }

        public bool CrearUsuario(Usuario usuario)
        {
            try
            {
                string json_data = JsonConvert.SerializeObject(usuario);
                File.WriteAllText(_fileName, json_data);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Usuario DevuelveInfoUsuario(int id)
        {
            Usuario usuario = new Usuario();
            try
            {
                if (File.Exists(_fileName))
                {
                    string json_data = File.ReadAllText(_fileName);
                    usuario = JsonConvert.DeserializeObject<Usuario>(json_data);

                }
            }
            catch (Exception)
            {
                throw;
            }

            return usuario;
        }

        public bool EliminarUsuario(int id)
        {
            throw new NotImplementedException();
        }
    }
}
