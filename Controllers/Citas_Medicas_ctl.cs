using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using ParcialPoo1.Config;
using ParcialPoo1.Models;
using System.Data.SqlClient;

namespace ParcialPoo1.Controllers
{
    internal class Citas_Medicas_ctl
    {
        private ConexionBDD conexion = new ConexionBDD();
        private MySqlCommand comando = new MySqlCommand();
        public bool AgregarCita(Cita cita)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "INSERT INTO Citas_Medicas (paciente_id, doctor_id, fecha_cita, motivo) VALUES (@PacienteId, @DoctorId, @FechaCita, @Motivo)";
                comando.Parameters.AddWithValue("@PacienteId", cita.PacienteId);
                comando.Parameters.AddWithValue("@DoctorId", cita.DoctorId);
                comando.Parameters.AddWithValue("@FechaCita", cita.FechaCita);
                comando.Parameters.AddWithValue("@Motivo", cita.Motivo);

                int rowsAffected = comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();

                return rowsAffected > 0;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al agregar la cita: " + ex.Message);
                return false;
            }
        }

        // Método para obtener todas las citas
        public List<Cita> ObtenerCitas()
        {
            List<Cita> listaCitas = new List<Cita>();

            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SELECT * FROM Citas_Medicas";
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Cita cita = new Cita()
                    {
                        CitaId = reader.GetInt32("cita_id"),
                        PacienteId = reader.GetInt32("paciente_id"),
                        DoctorId = reader.GetInt32("doctor_id"),
                        FechaCita = reader.GetDateTime("fecha_cita"),
                        Motivo = reader.GetString("motivo")
                    };

                    // Aquí podrías cargar los detalles del paciente y doctor si es necesario
                    // cita.Paciente = new Paciente_ctl().ObtenerPacientePorId(cita.PacienteId);
                    // cita.Doctor = new Doctores_ctl().ObtenerDoctorPorId(cita.DoctorId);

                    listaCitas.Add(cita);
                }

                reader.Close();
                conexion.CerrarConexion();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al obtener las citas: " + ex.Message);
            }

            return listaCitas;
        }

        // Método para actualizar una cita existente
        public bool ActualizarCita(Cita cita)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "UPDATE Citas_Medicas SET paciente_id = @PacienteId, doctor_id = @DoctorId, fecha_cita = @FechaCita, motivo = @Motivo WHERE cita_id = @CitaId";
                comando.Parameters.AddWithValue("@PacienteId", cita.PacienteId);
                comando.Parameters.AddWithValue("@DoctorId", cita.DoctorId);
                comando.Parameters.AddWithValue("@FechaCita", cita.FechaCita);
                comando.Parameters.AddWithValue("@Motivo", cita.Motivo);
                comando.Parameters.AddWithValue("@CitaId", cita.CitaId);

                int rowsAffected = comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();

                return rowsAffected > 0;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al actualizar la cita: " + ex.Message);
                return false;
            }
        }

        // Método para eliminar una cita
        public bool EliminarCita(int citaId)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "DELETE FROM Citas_Medicas WHERE cita_id = @CitaId";
                comando.Parameters.AddWithValue("@CitaId", citaId);

                int rowsAffected = comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();

                return rowsAffected > 0;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al eliminar la cita: " + ex.Message);
                return false;
            }
        }

        // Método para obtener una cita por su ID
        public Cita ObtenerCitaPorId(int citaId)
        {
            Cita cita = null;

            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SELECT * FROM Citas_Medicas WHERE cita_id = @CitaId";
                comando.Parameters.AddWithValue("@CitaId", citaId);

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    cita = new Cita()
                    {
                        CitaId = reader.GetInt32("cita_id"),
                        PacienteId = reader.GetInt32("paciente_id"),
                        DoctorId = reader.GetInt32("doctor_id"),
                        FechaCita = reader.GetDateTime("fecha_cita"),
                        Motivo = reader.GetString("motivo")
                    };
                }

                reader.Close();
                conexion.CerrarConexion();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al obtener la cita: " + ex.Message);
            }

            return cita;
        }
    }
}
