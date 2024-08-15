using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialPoo1.Models
{
    public class Paciente
    {
        public int PacienteId { get; set; }
        public string NombrePaciente { get; set; }
        public string ApellidoPaciente { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string TelefonoPaciente { get; set; }
        public string NombreCompleto
        {
            get { return $"{NombrePaciente} {ApellidoPaciente}"; }
        }
        public string DetalleCompletoP
        {
            get { return $"ID: {PacienteId}, Nombre: {NombrePaciente} {ApellidoPaciente}"; }

        }
    }
    }

