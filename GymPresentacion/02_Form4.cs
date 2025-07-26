using System;
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
        }

        private void AsignarEventos()
        {
            PicPanelMemebresia.Click += AbrirRegistroMembresia;
            PicPanelEntrenador.Click += AbrirRegistroEntrenadores;
            PicPanelRutina.Click += PicPanelRutina_Click;
            PicPanelPagoMembresia.Click += PicPanelPagoMembresia_Click;
            PicPanelSeguimiento.Click += PicPanelSeguimiento_Click;
            PicPanelUsuario.Click += PicPanelUsuario_Click;
            Despliegue.Click += Despliegue_Click;
            pictureBox1.Click += pictureBox1_Click;
            this.FormClosing += btnDespliegue_Load;
            this.Load += btnDespliegue_Load;
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

        private void AbrirRegistroMembresia(object sender, EventArgs e)
        {
            RegistroMembresias registroMembresias = new RegistroMembresias(this);
            registroMembresias.Show();
            this.Hide();
        }

        private void AbrirRegistroEntrenadores(object sender, EventArgs e)
        {
            RegistroEntrenadores registroEntrenadores = new RegistroEntrenadores(this);
            registroEntrenadores.Show();
            this.Hide();
        }

        private void PicPanelRutina_Click(object sender, EventArgs e)
        {
            RegistroRutina registroRutina = new RegistroRutina(this);
            registroRutina.Show();
            this.Hide();
        }

        private void PicPanelPagoMembresia_Click(object sender, EventArgs e)
        {
            PagosMembresia pagoMembresia = new PagosMembresia();
            pagoMembresia.Show();
            this.Hide();
        }

        private void PicPanelSeguimiento_Click(object sender, EventArgs e)
        {
            SeguimientoCliente Seguimiento = new SeguimientoCliente();
            Seguimiento.Show();
            this.Hide();
        }

        private void PicPanelUsuario_Click(object sender, EventArgs e)
        {
            RegsitroUsuarios registroUsuarios = new RegsitroUsuarios(_usuarioActivo);
            registroUsuarios.Show();
            this.Hide();
        }

        private void PicCerrarSesion_Click(object sender, EventArgs e)
        {
            _isNavigating = true;
            LogIn login = new LogIn();
            login.Show();
            this.Close();

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
        private void btnDespliegue_Load(object sender, EventArgs e)
        {

        }

        private void btnDespliegue_Load(object sender, FormClosingEventArgs e)
        {
            if (!_isNavigating)
            {
                Application.Exit();
            }
        }
    }
}

    