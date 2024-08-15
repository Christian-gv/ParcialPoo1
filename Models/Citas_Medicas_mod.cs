using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialPoo1.Models
{
    public class Cita
    {
        public int CitaId { get; set; }
        public int PacienteId { get; set; }
        public int DoctorId { get; set; }
        public DateTime FechaCita { get; set; }
        public string Motivo { get; set; }

        public Paciente Paciente { get; set; } 
        public Doctores Doctor { get; set; } 

        
        public string DetalleCita
        {
            get
            {
                return $"Fecha: {FechaCita}, Paciente: {Paciente?.NombreCompleto}, Doctor: {Doctor?.NombreCompletoD}, Motivo: {Motivo}";
            }
        }
    }
}
