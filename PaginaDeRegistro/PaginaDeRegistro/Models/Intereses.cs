using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaginaDeRegistro.Models
{
    public class Intereses
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public ICollection<Usuario> Usuarios { get; set; }
    }

}