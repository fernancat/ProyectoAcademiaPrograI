using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDUCATIVE.Models
{
    public class Pruebas
    {
        public int id { get; set; }
        public int evaluacion_id { get; set; }
        public string pregunta { get; set; }
        public string respuesta_correcta { get; set; }
    }

}
