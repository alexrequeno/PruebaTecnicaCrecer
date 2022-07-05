using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clinica.DomainLayer.Interfaces
{
    public interface IDoctorRepository
    {
        public bool CreateDoctor(string nombre, string apellido, DateTime fechanac, int especialidad);
        public bool UpdateDoctor(string nombre, string apellido, DateTime fechanac, int especialidad, int id);
        public bool DeleteDoctor(int id);
        public List<Doctor> GetDoctors(int id = 0);

    }
}
