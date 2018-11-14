using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaginaDeRegistro.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Genero { get; set; }
        public string Recuerdame { get; set; }   
        public ICollection<Intereses> Intereses { get; set; }
    }
}