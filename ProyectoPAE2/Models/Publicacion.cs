using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAE2.Models
{
    public class Publicacion
    {
        public int Id { get; set; }
        public string NombreMascota { get; set; }
        public string Raza { get; set; }
        public string Sexo { get; set; }
        public int Edad { get; set; }
        public float Peso { get; set; }
        public string Tamaño { get; set; }
        public bool Esterilizacion { get; set; }
        public string Enfermedades { get; set; }
        public string Comportamiento { get; set; }
    }
}
