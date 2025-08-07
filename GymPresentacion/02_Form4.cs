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
            PicPanelMemebresia.Click += PicPanelMembresia;
            PicPanelEntrenador.Click += PicPanelEntrenadores;
            PicPanelRutina.Click += PicPanelRutina_Click;
            PicPanelPagoMembresia.Click += PicPanelPagoMembresia_Click;
            PicPanelSeguimiento.Click += PicPanelSeguimiento_Click;
            PicPanelUsuario.Click += PicPanelUsuario_Click;
          
            pictureBox1.Click += pictureBox1_Click;
            this.FormClosing += btnDespliegue_FormClosing;
            this.Load += btnDespliegue_Load;
        }

        private void AplicarControldeAcceso()
        {
            string rol = _usuarioActivo.Rol;

            if (rol == "Secretaria")
            {
                PicPanelRutina.Visible = false;
                PicPanelSeguimiento.Visible = false;

            }
            else if (rol == "Entrenador")
            {
                PicPanelMemebresia.Visible = false;
                PicPanelEntrenador.Visible = false;
                PicPanelPagoMembresia.Visible = false;
                PicPanelUsuario.Visible = false;
            }
        }

        private RegistroMembresias _registroMembresiasForm;
        private RegistroEntrenadores _registroEntrenadoresForm;
        private RegistroRutina _registroRutinaForm;
        private PagosMembresia _pagosMembresiaForm;
        private PesoSeguimien _seguimientoForm;
        private RegsitroUsuarios _registroUsuariosForm;


        private void PicPanelMembresia(object sender, EventArgs e)
        {
            if (_registroMembresiasForm == null || _registroMembresiasForm.IsDisposed)
            {
                _registroMembresiasForm = new RegistroMembresias(this);
            }
            _registroMembresiasForm.Show();
            this.Hide();
        }

        private void PicPanelEntrenadores(object sender, EventArgs e)
        {
            if (_registroEntrenadoresForm == null || _registroEntrenadoresForm.IsDisposed)
            {
                _registroEntrenadoresForm = new RegistroEntrenadores(this);
            }
            _registroEntrenadoresForm.Show();
            this.Hide();
        }

        private void PicPanelRutina_Click(object sender, EventArgs e)
        {
            if (_registroRutinaForm == null || _registroRutinaForm.IsDisposed)
            {
                _registroRutinaForm = new RegistroRutina(this);
            }
            _registroRutinaForm.Show();
            this.Hide();
        }

        private void PicPanelPagoMembresia_Click(object sender, EventArgs e)
        {

            // Usa solo el singleton
            PagosMembresia pagoMembresia = PagosMembresia.ObtenerInstancia(_usuarioActivo);
            pagoMembresia.Show();

            this.Hide(); // Oculta el formulario actual (menú principal u otro)
        }

        private void PicPanelSeguimiento_Click(object sender, EventArgs e)
        {
            if (_seguimientoForm == null || _seguimientoForm.IsDisposed)
            {
                _seguimientoForm = new PesoSeguimien(_usuarioActivo, this);
            }
            _seguimientoForm.Show();
            this.Hide();
        }

        private void PicPanelUsuario_Click(object sender, EventArgs e)
        {
            if (_registroUsuariosForm == null || _registroUsuariosForm.IsDisposed)
            {
                _registroUsuariosForm = new RegsitroUsuarios(_usuarioActivo);
            }
            _registroUsuariosForm.Show();
            this.Hide();
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
            // RegistroEquipo equipo = new RegistroEquipo();
            //ahora se llama con el parametro
            RegistroEquipo equipo = new RegistroEquipo(_usuarioActivo);
            equipo.Show();
            this.Close();
        }

        private void Despliegue_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void btnDespliegue_Load(object sender, EventArgs e)
        {

        }

        private void btnDespliegue_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isNavigating)
            {
                Application.Exit();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (_registroUsuariosForm == null || _registroUsuariosForm.IsDisposed)
            {
                _registroUsuariosForm = new RegsitroUsuarios(_usuarioActivo);
            }
            _registroUsuariosForm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (_registroMembresiasForm == null || _registroMembresiasForm.IsDisposed)
            {
                _registroMembresiasForm = new RegistroMembresias(this);
            }
            _registroMembresiasForm.Show();
            this.Hide();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            //TODO Usa solo el singleton
            PagosMembresia pagoMembresia = PagosMembresia.ObtenerInstancia(_usuarioActivo);
            pagoMembresia.Show();

            this.Hide(); //TODO Oculta el formulario actual (menú principal u otro)
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (_registroEntrenadoresForm == null || _registroEntrenadoresForm.IsDisposed)
            {
                _registroEntrenadoresForm = new RegistroEntrenadores(this);
            }
            _registroEntrenadoresForm.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (_registroRutinaForm == null || _registroRutinaForm.IsDisposed)
            {
                _registroRutinaForm = new RegistroRutina(this);
            }
            _registroRutinaForm.Show();
            this.Hide();
        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (_seguimientoForm == null || _seguimientoForm.IsDisposed)
            {
                _seguimientoForm = new PesoSeguimien(_usuarioActivo, this);
            }
            _seguimientoForm.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            _isNavigating = true;
            // RegistroEquipo equipo = new RegistroEquipo();
            //ahora se llama con el parametro
            RegistroEquipo equipo = new RegistroEquipo(_usuarioActivo);
            equipo.Show();
            this.Close();
        }
    }
}

    