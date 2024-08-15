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
    public class Pacientes_ctl
    {
        private ConexionBDD conexion = new ConexionBDD();
        private MySqlCommand comando = new MySqlCommand();

        // Método para agregar un nuevo paciente
        public bool AgregarPacientes(Paciente paciente)  
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "INSERT INTO Pacientes (nombre_paciente, apellido_paciente, fecha_nacimiento, telefono_paciente) VALUES (@Nombre, @Apellido, @FechaNacimiento, @Telefono)";
                comando.Parameters.AddWithValue("@Nombre", paciente.NombrePaciente);
                comando.Parameters.AddWithValue("@Apellido", paciente.ApellidoPaciente);
                comando.Parameters.AddWithValue("@FechaNacimiento", paciente.FechaNacimiento);
                comando.Parameters.AddWithValue("@Telefono", paciente.TelefonoPaciente);

                int rowsAffected = comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();

                return rowsAffected > 0;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al agregar paciente: " + ex.Message);
                return false;
            }
        }

        // Método para obtener todos los pacientes
        public List<Paciente> ObtenerPacientes()
        {
            List<Paciente> listaPacientes = new List<Paciente>();

            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SELECT * FROM Pacientes";
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Paciente paciente = new Paciente()
                    {
                        PacienteId = reader.GetInt32("paciente_id"),
                        NombrePaciente = reader.GetString("nombre_paciente"),
                        ApellidoPaciente = reader.GetString("apellido_paciente"),
                        FechaNacimiento = reader.GetDateTime("fecha_nacimiento"),
                        TelefonoPaciente = reader.GetString("telefono_paciente")
                    };

                    listaPacientes.Add(paciente);
                }

                reader.Close();
                conexion.CerrarConexion();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al obtener pacientes: " + ex.Message);
            }

            return listaPacientes;
        }

        // Método para actualizar un paciente existente
        public bool ActualizarPaciente(Paciente paciente)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "UPDATE Pacientes SET nombre_paciente = @Nombre, apellido_paciente = @Apellido, fecha_nacimiento = @FechaNacimiento, telefono_paciente = @Telefono WHERE paciente_id = @PacienteId";
                comando.Parameters.AddWithValue("@Nombre", paciente.NombrePaciente);
                comando.Parameters.AddWithValue("@Apellido", paciente.ApellidoPaciente);
                comando.Parameters.AddWithValue("@FechaNacimiento", paciente.FechaNacimiento);
                comando.Parameters.AddWithValue("@Telefono", paciente.TelefonoPaciente);
                comando.Parameters.AddWithValue("@PacienteId", paciente.PacienteId);

                int rowsAffected = comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();

                return rowsAffected > 0;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al actualizar paciente: " + ex.Message);
                return false;
            }
        }

        // Método para eliminar un paciente
        public bool EliminarPaciente(int pacienteId)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "DELETE FROM Pacientes WHERE paciente_id = @PacienteId";
                comando.Parameters.AddWithValue("@PacienteId", pacienteId);

                int rowsAffected = comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();

                return rowsAffected > 0;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al eliminar paciente: " + ex.Message);
                return false;
            }
        }
    }
}