using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParcialPoo1.Views;

namespace ParcialPoo1.Views
{
    public partial class Menú_Principal : Form
    {
        public Menú_Principal()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\descarga.jpg");

            this.BackgroundImage = img;

            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Menú_Principal_Load(object sender, EventArgs e)
        {

        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pacientes_fr  pacientes_Fr=  new Pacientes_fr();
            pacientes_Fr.ShowDialog();
        }

        private void doctoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doctores_fr doctores_Fr= new Doctores_fr();
            doctores_Fr.ShowDialog();
        }

        private void agenndarCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agendar_fr agendar_Fr= new Agendar_fr();
            agendar_Fr.ShowDialog();
        }
    }
}
