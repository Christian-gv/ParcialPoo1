using ParcialPoo1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialPoo1.Views
{
    public partial class Agendar_fr : Form
    {
        public Agendar_fr()
        {
            InitializeComponent();
        }
        private void CargarPacientes()
        {
            var controladorPacientes = new ParcialPoo1.Controllers.Pacientes_ctl();
            var listaPacientes = controladorPacientes.ObtenerPacientes();

            Dt_PA_lt.Items.Clear();

            foreach (var paciente in listaPacientes)
            {
                Dt_PA_lt.Items.Add(paciente);
            }

            Dt_PA_lt.DisplayMember = "DetalleCompletoP";
        }
        private void CargarDoctores()
        {
            var controladorDoctores = new ParcialPoo1.Controllers.Doctores_ctl();
            var listaDoctores = controladorDoctores.ObtenerDoctores();

            Dt_DO_lt.Items.Clear();

            foreach (var doctor in listaDoctores)
            {
                Dt_DO_lt.Items.Add(doctor);
            }

            Dt_DO_lt.DisplayMember = "DetalleCompletoD";
        }
        private Paciente pacienteSeleccionado;
        private Doctores doctorSeleccionado;
        private void CargarCitas()
        {
            var controladorCitas = new ParcialPoo1.Controllers.Citas_Medicas_ctl();
            var listaCitas = controladorCitas.ObtenerCitas();

            Dt_ct_lt.Items.Clear();

            foreach (var cita in listaCitas)
            {
                Dt_ct_lt.Items.Add(cita);
            }

            Dt_ct_lt.DisplayMember = "DetalleCita";
        }
        private void Agendar_fr_Load(object sender, EventArgs e)
        {
            CargarPacientes();
            CargarDoctores();
            CargarCitas();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dt_PA_lt_SelectedIndexChanged(object sender, EventArgs e)
        {
            pacienteSeleccionado = (Paciente)Dt_PA_lt.SelectedItem;
        }
    

        private void Dt_DO_lt_SelectedIndexChanged(object sender, EventArgs e)
        {
        doctorSeleccionado = (Doctores)Dt_DO_lt.SelectedItem;
    }

        private void Dt_ct_lt_SelectedIndexChanged(object sender, EventArgs e)
        {
            var citaSeleccionada = (Cita)Dt_ct_lt.SelectedItem;

            if (citaSeleccionada != null)
            {
                textBox1.Text = citaSeleccionada.Paciente?.NombreCompleto;
                textBox2.Text = citaSeleccionada.Doctor?.NombreCompletoD;
                dateTimePicker1.Value = citaSeleccionada.FechaCita;
                textBox3.Text = citaSeleccionada.Motivo;
            }
        }

        private void Ag_ct_BT_Click(object sender, EventArgs e)
        {
            if (pacienteSeleccionado == null || doctorSeleccionado == null)
            {
                MessageBox.Show("Por favor, selecciona un paciente y un doctor antes de agendar una cita.");
                return;
            }

            var controladorCitas = new ParcialPoo1.Controllers.Citas_Medicas_ctl();
            var nuevaCita = new Cita
            {
                PacienteId = pacienteSeleccionado.PacienteId,
                DoctorId = doctorSeleccionado.DoctorId,
                FechaCita = dateTimePicker1.Value,
                Motivo = textBox3.Text
            };

            if (controladorCitas.AgregarCita(nuevaCita))
            {
                MessageBox.Show("Cita agregada exitosamente.");
                CargarCitas();
            }
            else
            {
                MessageBox.Show("Error al agregar la cita.");
            }
        }

        private void El_ct_BT_Click(object sender, EventArgs e)
        {
            var citaSeleccionada = (Cita)Dt_ct_lt.SelectedItem;

            if (citaSeleccionada != null)
            {
                var controladorCitas = new ParcialPoo1.Controllers.Citas_Medicas_ctl();

                if (controladorCitas.EliminarCita(citaSeleccionada.CitaId))
                {
                    MessageBox.Show("Cita eliminada exitosamente.");
                    CargarCitas();
                }
                else
                {
                    MessageBox.Show("Error al eliminar la cita.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una cita para eliminar.");
            }
        }

    }
}
