using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public  class Paciente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNac { get; set; }
        public int Sexo{ get; set; }
    }
}
