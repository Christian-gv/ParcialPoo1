using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParcialPoo1.Config;
using ParcialPoo1.Controllers;
using ParcialPoo1.Models;

namespace ParcialPoo1
{
    public partial class Pacientes_fr : Form
    {
        public Pacientes_fr()
        {
            InitializeComponent();
        }
        private void Pacientes_fr_Load(object sender, EventArgs e)
        {
            CargarPacientes();
        }


             private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_nombre_PA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_apellido_PA_TextChanged(object sender, EventArgs e)
        {

        }

        private void FN_PA_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_telefono_PA_TextChanged(object sender, EventArgs e)
        {

        }

        private void agr_PA_bt_Click(object sender, EventArgs e)
        {
            var controlador = new ParcialPoo1.Controllers.Pacientes_ctl();
            var nuevoPaciente = new ParcialPoo1.Models.Paciente
            {
                NombrePaciente = txt_nombre_PA.Text,
                ApellidoPaciente = txt_apellido_PA.Text,
                FechaNacimiento = FN_PA.Value,
                TelefonoPaciente = txt_telefono_PA.Text
            };
            if (controlador.AgregarPacientes(nuevoPaciente))
            {
                MessageBox.Show("Paciente agregado exitosamente.");
                LimpiarCampos();
                CargarPacientes();
            }
            else
            {
                MessageBox.Show("Error al agregar el paciente.");
            }
        }
        private void LimpiarCampos()
        {
            txt_nombre_PA.Text = string.Empty;
            txt_apellido_PA.Text = string.Empty;
            txt_telefono_PA.Text = string.Empty;
            FN_PA.Value = DateTime.Now;
        }
        private void el_PA_bt_Click(object sender, EventArgs e)
        {
            if (lt_PA.SelectedItem != null)
            {
                var controlador = new ParcialPoo1.Controllers.Pacientes_ctl();
                var pacienteSeleccionado = (ParcialPoo1.Models.Paciente)lt_PA.SelectedItem;
                if (controlador.EliminarPaciente(pacienteSeleccionado.PacienteId))
                {
                    MessageBox.Show("Paciente eliminado exitosamente.");
                    CargarPacientes(); // Recargar la lista de pacientes
                }
                else
                {
                    MessageBox.Show("Error al eliminar el paciente.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un paciente para eliminar.");
            }
        }

            private void md_PA_bt_Click(object sender, EventArgs e)
        {

        }
        private void CargarPacientes()
        {
            var controlador = new ParcialPoo1.Controllers.Pacientes_ctl();
            var listaPacientes = controlador.ObtenerPacientes();
            lt_PA.Items.Clear();
            foreach (var paciente in listaPacientes)
            {
                lt_PA.Items.Add(paciente);
            }
            lt_PA.DisplayMember = "NombreCompleto"; 
        }


        private void lt_PA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lt_PA.SelectedItem != null)
            {
                var controlador = new ParcialPoo1.Controllers.Pacientes_ctl();
                var pacienteSeleccionado = (ParcialPoo1.Models.Paciente)lt_PA.SelectedItem;
                pacienteSeleccionado.NombrePaciente = txt_nombre_PA.Text;
                pacienteSeleccionado.ApellidoPaciente = txt_apellido_PA.Text;
                pacienteSeleccionado.FechaNacimiento = FN_PA.Value;
                pacienteSeleccionado.TelefonoPaciente = txt_telefono_PA.Text;

                if (controlador.ActualizarPaciente(pacienteSeleccionado))
                {
                    MessageBox.Show("Paciente actualizado exitosamente.");
                    CargarPacientes();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el paciente.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un paciente para modificar.");
            }

        }

        }
}
