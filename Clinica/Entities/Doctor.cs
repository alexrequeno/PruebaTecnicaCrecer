using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public  class Doctor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNac { get; set; }
        public string Especialidad { get; set; }
    }
}
