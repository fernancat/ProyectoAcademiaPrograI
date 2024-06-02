using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDUCATIVE.Models
{
    public  class Evaluaciones
    {
        public int id { get; set; }
        public int curso_id { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
    }
}
