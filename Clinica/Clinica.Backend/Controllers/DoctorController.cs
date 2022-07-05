using Clinica.DomainLayer.Interfaces;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Clinica.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorRepository _doctorRepository;

        public DoctorController(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Doctor> dr = _doctorRepository.GetDoctors(0);

            return Ok(dr);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            List<Doctor> dr = _doctorRepository.GetDoctors(id);

            return Ok(dr.Find(d => d.Id == id));
        }

        [HttpPost]
        public IActionResult Create([FromBody]Doctor dr)
        {
            _doctorRepository.CreateDoctor(dr.Nombre, dr.Apellidos, dr.FechaNac, dr.Especialidad);
        }
    }
}
