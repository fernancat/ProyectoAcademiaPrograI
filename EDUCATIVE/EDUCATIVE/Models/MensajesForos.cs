using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDUCATIVE.Models
{
    public class MensajeForo
    {
        public int id { get; set; }
        public int foro_id { get; set; }

        public string mensaje { get; set; }
    }
}
