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


namespace ParcialPoo1.Views
{
    public partial class Doctores_fr : Form
    {
        public Doctores_fr()
        {
            InitializeComponent();
            CargarDoctores();
        }

        private void agr_DO_bt_Click(object sender, EventArgs e)
        {
            var controlador = new ParcialPoo1.Controllers.Doctores_ctl();
            var nuevoDoctor = new ParcialPoo1.Models.Doctores
            {
                NombreDoc = txt_nombre_DO.Text,
                ApellidoDoc = txt_apellido_DO.Text,
                EspecialidadDoc = txt_especialidad_DO.Text,
                TelefonoDoc = txt_telefono_DO.Text
            };

            if (controlador.AgregarDoctor(nuevoDoctor))
            {
                MessageBox.Show("Doctor agregado exitosamente.");
                LimpiarCampos();
                CargarDoctores();
            }
            else
            {
                MessageBox.Show("Error al agregar el doctor.");
            }
        }
            private void LimpiarCampos()
            {
                txt_nombre_DO.Text = string.Empty;
                txt_apellido_DO.Text = string.Empty;
                txt_especialidad_DO.Text = string.Empty;
                txt_telefono_DO.Text = string.Empty;
            }
        

        private void el_DO_bt_Click(object sender, EventArgs e)
        {
            if (lt_DO.SelectedItem != null)
            {
                var controlador = new ParcialPoo1.Controllers.Doctores_ctl();
                var doctorSeleccionado = (ParcialPoo1.Models.Doctores)lt_DO.SelectedItem;
                if (controlador.EliminarDoctor(doctorSeleccionado.DoctorId))
                {
                    MessageBox.Show("Doctor eliminado exitosamente.");
                    CargarDoctores();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el doctor.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un doctor para eliminar.");
            }
        }

        private void md_DO_bt_Click(object sender, EventArgs e)
        {
            if (lt_DO.SelectedItem != null)
            {
                var controlador = new ParcialPoo1.Controllers.Doctores_ctl();
                var doctorSeleccionado = (ParcialPoo1.Models.Doctores)lt_DO.SelectedItem;

                doctorSeleccionado.NombreDoc = txt_nombre_DO.Text;
                doctorSeleccionado.ApellidoDoc = txt_apellido_DO.Text;
                doctorSeleccionado.EspecialidadDoc = txt_especialidad_DO.Text;
                doctorSeleccionado.TelefonoDoc = txt_telefono_DO.Text;

                if (controlador.ActualizarDoctor(doctorSeleccionado))
                {
                    MessageBox.Show("Doctor actualizado exitosamente.");
                    CargarDoctores();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el doctor.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un doctor para modificar.");
            }
        }
        private void CargarDoctores()
        {
            var controlador = new ParcialPoo1.Controllers.Doctores_ctl();
            var listaDoctores = controlador.ObtenerDoctores();

            lt_DO.Items.Clear();

            foreach (var doctor in listaDoctores)
            {
                lt_DO.Items.Add(doctor);
            }

            lt_DO.DisplayMember = "NombreCompletoD";
        }
        private void lt_DO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lt_DO.SelectedItem != null)
            {
                var doctorSeleccionado = (ParcialPoo1.Models.Doctores)lt_DO.SelectedItem;

                txt_nombre_DO.Text = doctorSeleccionado.NombreDoc;
                txt_apellido_DO.Text = doctorSeleccionado.ApellidoDoc;
                txt_especialidad_DO.Text = doctorSeleccionado.EspecialidadDoc;
                txt_telefono_DO.Text = doctorSeleccionado.TelefonoDoc;
            }
        }

        private void Doctores_fr_Load(object sender, EventArgs e)
        {

        }
    }
}
