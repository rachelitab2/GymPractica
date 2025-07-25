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
using GymNegocio.Login;

namespace GymPresentacion
{
    public partial class btnDespliegue : Form
    {
        private readonly UsuariosActivos _usuarioActivo;
        private bool _isNavigating = false;
        public btnDespliegue(UsuariosActivos usuarioActivo)
        {
            InitializeComponent();
            _usuarioActivo = usuarioActivo;
            AsignarEventos();
            AplicarControldeAcceso();

            MessageBox.Show($"¡Bienvenido, {_usuarioActivo.Usuario}! Rol: {_usuarioActivo.Rol}", "Acceso Permitido", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void AsignarEventos()
        {
            PicPanelMemebresia.Click += AbrirFormMembresia;
            PicPanelEntrenador.Click += AbrirFormEntrenadores;
            PicPanelRutina.Click += AbrirFormRutinas;

        }

        private void AplicarControldeAcceso()
        {
            string rol = _usuarioActivo.Rol;

            if (rol == "Secretaria")
            {
                PicPanelRutina.Visible = false;
            }
            else if (rol == "Entrenador")
            {
                PicPanelMemebresia.Visible = false;
                PicPanelEntrenador.Visible = false;
            }
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

        private void PicCerrarSesion_Click(object sender, EventArgs e)
        {
            Form5LogIn login = new Form5LogIn();
            login.Show();
            this.Hide();
        }

        private void PicPanelUsuario_Click(object sender, EventArgs e)
        {
            _isNavigating = true;
            Form6Usuarios form6Usuarios = new Form6Usuarios(_usuarioActivo);
            form6Usuarios.StartPosition = FormStartPosition.CenterScreen;
            form6Usuarios.Show();
            this.Close();
        }
    }
}
