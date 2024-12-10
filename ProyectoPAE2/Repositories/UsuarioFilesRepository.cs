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

        public Usuario BuscarUsuarioPorCorreoYClave(string correo, string clave)
        {
            var usuarios = DevuelveListaUsuarios();
            return usuarios.FirstOrDefault(u => u.Correo == correo && u.Clave == clave);
        }

        public bool CrearUsuario(Usuario usuario)
        {
            try
            {
                List<Usuario> usuarios = DevuelveListaUsuarios().ToList();
                usuarios.Add(usuario);

                string jsonData = JsonConvert.SerializeObject(usuarios, Formatting.Indented);
                File.WriteAllText(_fileName, jsonData);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Usuario DevuelveInfoUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> DevuelveListaUsuarios()
        {
            if (!File.Exists(_fileName))
                return new List<Usuario>();

            try
            {
                string jsonData = File.ReadAllText(_fileName);
                return JsonConvert.DeserializeObject<List<Usuario>>(jsonData) ?? new List<Usuario>();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool EliminarUsuario(int id)
        {
            throw new NotImplementedException();
        }
    }
}
