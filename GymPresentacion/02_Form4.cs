using System;
using System.Windows.Forms;
using GymNegocio.Login;

namespace GymPresentacion
{
    public partial class btnDespliegue : Form
    {
        private readonly UsuariosActivos _usuarioActivo;
        private bool _isNavigating = false;
        private UsuariosActivos _usuariosActivos;

        public btnDespliegue(UsuariosActivos usuarioActivo)
        {
            InitializeComponent();
            _usuarioActivo = usuarioActivo;
            AsignarEventos();
            AplicarControldeAcceso();
        }

        private void AsignarEventos()
        {
            PicPanelMemebresia.Click += PicPanelMembresia;
            PicPanelEntrenador.Click += PicPanelEntrenadores;
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

        private void PicPanelMembresia(object sender, EventArgs e)
        {
            RegistroMembresias registroMembresias = new RegistroMembresias(this);
            registroMembresias.Show();
            this.Hide();
        }

        private void PicPanelEntrenadores(object sender, EventArgs e)
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
            PagosMembresia pagoMembresia = new PagosMembresia(_usuariosActivos);
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
            if (Application.OpenForms["RegsitroUsuarios"] == null)
            {
                RegsitroUsuarios registroUsuarios = new RegsitroUsuarios(_usuarioActivo);
                registroUsuarios.Show();
                this.Hide();
            }
        }

        private void PicCerrarSesion_Click(object sender, EventArgs e)
        {
            _isNavigating = true;
            LogIn login = new LogIn();
            login.Show();
            this.Close();

        }
        private void PicPanelEquipo_Click(object sender, EventArgs e)
        {
            _isNavigating = true;
            RegistroEquipo equipo = new RegistroEquipo();
            equipo.Show();
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

    