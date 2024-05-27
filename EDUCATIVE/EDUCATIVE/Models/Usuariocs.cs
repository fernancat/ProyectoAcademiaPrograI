using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDUCATIVE.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string nombre_usuario { get; set; }

        public string apellidos { get; set; }
        public string email { get; set; }

        public string contraseña { get; set; }

        public string rol { get; set; }

        public DateTime fecha_creacion { get; set; }


       
    }


    
}
