using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace Clinica.DataAccessLayer.DataAccessObjects
{

    public class DoctorDAO : Connector
    {
        public bool CreateDoctor(string nombre, string apellido, DateTime fechanac, int especialidad)
        {
            using var connection = GetConnection();
            connection.Open();
            using SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "CrearDoctor";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = nombre;
            cmd.Parameters.Add("@Apellido", SqlDbType.NVarChar).Value = apellido;
            cmd.Parameters.Add("@FechaNac", SqlDbType.Date).Value = fechanac;
            cmd.Parameters.Add("@Nombre", SqlDbType.Int).Value = especialidad;

            if (cmd.ExecuteNonQuery() > 0) return true;
            else return false;

        }

        public bool UpdateDoctor(string nombre, string apellido, DateTime fechanac, int especialidad, int id)
        {
            using var connection = GetConnection();
            connection.Open();
            using SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "ActualizarDoctor";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = nombre;
            cmd.Parameters.Add("@Apellido", SqlDbType.NVarChar).Value = apellido;
            cmd.Parameters.Add("@FechaNac", SqlDbType.Date).Value = fechanac;
            cmd.Parameters.Add("@Nombre", SqlDbType.Int).Value = especialidad;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

            if (cmd.ExecuteNonQuery() > 0) return true;
            else return false;

        }

        public bool DeleteDoctor(int id)
        {
            using var connection = GetConnection();
            connection.Open();
            using SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "EliminarDoctor";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

            if (cmd.ExecuteNonQuery() > 0) return true;
            else return false;

        }

        public List<Doctor> GetDoctors(int id)
        {
            using var connection = GetConnection();
            connection.Open();
            using SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "ObtenerDoctor";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;

            SqlDataReader reader = cmd.ExecuteReader();

            Doctor drs = null;
            List<Doctor> doctors = new List<Doctor>();

            while (reader.Read())
            {
                drs = new Doctor();
                drs.Nombre = reader["Nombre"].ToString();
                drs.Apellidos = reader["Apellidos"].ToString();
                drs.FechaNac = Convert.ToDateTime(reader["FechaNac"]);
                drs.Especialidad = reader["Especialidad"].ToString();
                doctors.Add(drs);
            }
            return doctors;

        }
    }
}
