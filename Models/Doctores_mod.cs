using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialPoo1.Models
{
    public class Doctores
    {
        public int DoctorId { get; set; }
        public string NombreDoc { get; set; }
        public string ApellidoDoc { get; set; }
        public string EspecialidadDoc { get; set; }
        public string TelefonoDoc { get; set; }
        public string NombreCompletoD
        {
            get { return $"{NombreDoc} {ApellidoDoc}"; }
        }
        public string DetalleCompletoD
        {
            get { return $"ID: {DoctorId}, Nombre: {NombreDoc} {ApellidoDoc}, Especialidad: {EspecialidadDoc}"; }
        }
    }

    }
