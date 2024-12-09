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
            catch(Exception e)
            {
                throw;
            }
        }

        public Usuario DevuelveInfoUsuario(int id)
        {
            try
            {

            }
            catch (Exception e)
            {
                throw;
            }
            throw new NotImplementedException();
        }

        public bool EliminarUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
