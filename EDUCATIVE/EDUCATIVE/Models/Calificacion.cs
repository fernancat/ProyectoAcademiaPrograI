using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDUCATIVE.Models
{
    public class Calificacion
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdCurso { get; set; }
        public int CalificacionValor { get; set; }
        public string Comentarios { get; set; }
    }
}
