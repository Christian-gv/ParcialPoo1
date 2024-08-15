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
    internal class Doctores_ctl
    {
        private ConexionBDD conexion = new ConexionBDD();
        private MySqlCommand comando = new MySqlCommand();

        // Método para agregar un nuevo doctor
        public bool AgregarDoctor(Doctores doctor)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "INSERT INTO Doctores (nombre_doc, apellido_doc, especialidad_doc, telefono_doc) VALUES (@Nombre, @Apellido, @Especialidad, @Telefono)";
                comando.Parameters.AddWithValue("@Nombre", doctor.NombreDoc);
                comando.Parameters.AddWithValue("@Apellido", doctor.ApellidoDoc);
                comando.Parameters.AddWithValue("@Especialidad", doctor.EspecialidadDoc);
                comando.Parameters.AddWithValue("@Telefono", doctor.TelefonoDoc);

                int rowsAffected = comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();

                return rowsAffected > 0;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al agregar doctor: " + ex.Message);
                return false;
            }
        }

        // Método para obtener todos los doctores
        public List<Doctores> ObtenerDoctores()
        {
            List<Doctores> listaDoctores = new List<Doctores>();

            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SELECT * FROM Doctores";
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Doctores doctor = new Doctores()
                    {
                        DoctorId = reader.GetInt32("doctor_id"),
                        NombreDoc = reader.GetString("nombre_doc"),
                        ApellidoDoc = reader.GetString("apellido_doc"),
                        EspecialidadDoc = reader.GetString("especialidad_doc"),
                        TelefonoDoc = reader.GetString("telefono_doc")
                    };

                    listaDoctores.Add(doctor);
                }

                reader.Close();
                conexion.CerrarConexion();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al obtener doctores: " + ex.Message);
            }

            return listaDoctores;
        }

        // Método para actualizar un doctor existente
        public bool ActualizarDoctor(Doctores doctor)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "UPDATE Doctores SET nombre_doc = @Nombre, apellido_doc = @Apellido, especialidad_doc = @Especialidad, telefono_doc = @Telefono WHERE doctor_id = @DoctorId";
                comando.Parameters.AddWithValue("@Nombre", doctor.NombreDoc);
                comando.Parameters.AddWithValue("@Apellido", doctor.ApellidoDoc);
                comando.Parameters.AddWithValue("@Especialidad", doctor.EspecialidadDoc);
                comando.Parameters.AddWithValue("@Telefono", doctor.TelefonoDoc);
                comando.Parameters.AddWithValue("@DoctorId", doctor.DoctorId);

                int rowsAffected = comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();

                return rowsAffected > 0;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al actualizar doctor: " + ex.Message);
                return false;
            }
        }

        // Método para eliminar un doctor
        public bool EliminarDoctor(int doctorId)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "DELETE FROM Doctores WHERE doctor_id = @DoctorId";
                comando.Parameters.AddWithValue("@DoctorId", doctorId);

                int rowsAffected = comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();

                return rowsAffected > 0;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al eliminar doctor: " + ex.Message);
                return false;
            }
        }
    }
}
