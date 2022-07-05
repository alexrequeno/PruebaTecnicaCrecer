using Clinica.DataAccessLayer.DataAccessObjects;
using Clinica.DomainLayer.Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clinica.DomainLayer.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        DoctorDAO doctorDAO = new DoctorDAO();
        public bool CreateDoctor(string nombre, string apellido, DateTime fechanac, int especialidad)
        {
            return doctorDAO.CreateDoctor(nombre, apellido, fechanac, especialidad);
        }

        public bool DeleteDoctor(int id)
        {
            return doctorDAO.DeleteDoctor(id);
        }

        public List<Doctor> GetDoctors(int id = 0)
        {
            return doctorDAO.GetDoctors(id);
        }

        public bool UpdateDoctor(string nombre, string apellido, DateTime fechanac, int especialidad, int id)
        {
            return doctorDAO.UpdateDoctor(nombre, apellido, fechanac, especialidad, id);
        }
    }
}
