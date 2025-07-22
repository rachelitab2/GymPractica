using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymPresentacion
{
    public partial class btnDespliegue : Form
    {
        public btnDespliegue()
        {
            InitializeComponent();
            AsignarEventos();
        }
        private void AsignarEventos()
        {
            PicPanelMemebresia.Click += AbrirFormMembresia;
            PicPanelEntrenador.Click += AbrirFormEntrenadores;
            PicPanelRutina.Click += AbrirFormRutinas;
            this.FormClosing += Form4_Load_FormClosing;
        }

        private void AbrirFormMembresia(object sender, EventArgs e)
        {
            Form1 formMembresias = new Form1(this);
            formMembresias.Show();
            this.Hide();
        }

        private void AbrirFormEntrenadores(object sender, EventArgs e)
        {
            Form2Entrenadores form2Entrenadores = new Form2Entrenadores(this);
            form2Entrenadores.Show();
            this.Hide();
        }

        private void AbrirFormRutinas(object sender, EventArgs e)
        {
            Form3Rutina form3Rutina = new Form3Rutina(this);
            form3Rutina.Show();
            this.Hide();
        }
        private void Form4_Load_FormClosing(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PicPanelRutina_Click(object sender, EventArgs e)
        {

        }

        private void Despliegue_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }
            else
            {
                MenuVertical.Width = 250;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
