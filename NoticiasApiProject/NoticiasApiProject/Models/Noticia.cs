using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoticiasApiProject.Models
{
    public class Noticia
    {
        public int NoticiaID { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Contenido { get; set; }
        public DateTime Fecha { get; set; }
        public int AutorId { get; set; }
    }
}
