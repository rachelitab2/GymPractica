using System;
using System.Drawing;
using System.Windows.Forms;
using GymNegocio.Login;

namespace GymPresentacion
{
    public partial class btnDespliegue : Form
    {
        private readonly UsuariosActivos _usuarioActivo;
        private bool _isNavigating = false;
        private RegistroMembresias _registroMembresiasForm;
        private RegistroEntrenadores _registroEntrenadoresForm;
        private RegistroRutina _registroRutinaForm;
        private PagosMembresia _pagosMembresiaForm;
        private PesoSeguimien _seguimientoForm;
        private RegsitroUsuarios _registroUsuariosForm;
        private ToolTip _toolTip;

        public btnDespliegue(UsuariosActivos usuarioActivo)
        {
            InitializeComponent();
            _usuarioActivo = usuarioActivo;
            InicializarTooltips();
            AsignarEventos();
            ConfigurarControlDeAcceso();
        }

        private void InicializarTooltips()
        {
            _toolTip = new ToolTip();
            _toolTip.IsBalloon = true;
            _toolTip.ToolTipIcon = ToolTipIcon.Warning;
            _toolTip.ToolTipTitle = "Acceso Restringido";
            _toolTip.InitialDelay = 500;
            _toolTip.ReshowDelay = 100;
        }

        private void AsignarEventos()
        {
            // Eventos de PictureBox
            PicPanelMemebresia.Click += PicPanelMembresia;
            PicPanelEntrenador.Click += PicPanelEntrenadores;
            PicPanelRutina.Click += PicPanelRutina_Click;
            PicPanelPagoMembresia.Click += PicPanelPagoMembresia_Click;
            PicPanelSeguimiento.Click += PicPanelSeguimiento_Click;
            PicPanelUsuario.Click += PicPanelUsuario_Click;
            pictureBox1.Click += pictureBox1_Click;

            // Eventos del formulario
            this.FormClosing += btnDespliegue_FormClosing;
            this.Load += btnDespliegue_Load;

            // Eventos de labels
            label1.Click += label1_Click;
            label2.Click += label2_Click;
            label3.Click += label3_Click_1;
            label4.Click += label4_Click;
            label5.Click += label5_Click;
            label7.Click += label7_Click;

            // Eventos de hover
            AsignarEventosHover();
        }

        private void AsignarEventosHover()
        {
            AsignarHover(PicPanelUsuario, label1);
            AsignarHover(PicPanelMemebresia, label2);
            AsignarHover(PicPanelPagoMembresia, label3);
            AsignarHover(PicPanelEntrenador, label4);
            AsignarHover(PicPanelRutina, label5);
            AsignarHover(PicPanelSeguimiento, label6);
        }

        private void AsignarHover(PictureBox pic, Label lbl)
        {
            pic.MouseEnter += (s, e) => {
                if (TienePermiso(pic)) pic.Cursor = Cursors.Hand;
            };
            pic.MouseLeave += (s, e) => {
                if (TienePermiso(pic)) pic.Cursor = Cursors.Default;
            };
            lbl.MouseEnter += (s, e) => {
                if (TienePermiso(lbl)) lbl.Cursor = Cursors.Hand;
            };
            lbl.MouseLeave += (s, e) => {
                if (TienePermiso(lbl)) lbl.Cursor = Cursors.Default;
            };
        }

        private void ConfigurarControlDeAcceso()
        {
            string rol = _usuarioActivo.Rol;

            // SIMPLIFICADO: Solo Administrador y Entrenador
            if (rol == "Entrenador")
            {
                // ENTRENADOR: Solo puede usar Rutinas y Equipos
                ConfigurarRestriccion(PicPanelUsuario, label1, "Solo Administradores pueden gestionar usuarios");
                ConfigurarRestriccion(PicPanelMemebresia, label2, "Solo Administradores pueden gestionar membresías");
                ConfigurarRestriccion(PicPanelPagoMembresia, label3, "Solo Administradores pueden gestionar pagos");
                ConfigurarRestriccion(PicPanelEntrenador, label4, "Solo Administradores pueden gestionar entrenadores");
                ConfigurarRestriccion(PicPanelSeguimiento, label6, "Solo Administradores pueden gestionar seguimiento");

                // Disponibles: Rutinas y Equipos
            }
            else if (rol == "Administrador")
            {
                // ADMINISTRADOR: Acceso total
                // Todos los controles están disponibles
            }
            else
            {
                // Si llega un rol no reconocido, tratar como Entrenador
                ConfigurarRestriccion(PicPanelUsuario, label1, "Rol no reconocido - Acceso limitado");
                ConfigurarRestriccion(PicPanelMemebresia, label2, "Rol no reconocido - Acceso limitado");
                ConfigurarRestriccion(PicPanelPagoMembresia, label3, "Rol no reconocido - Acceso limitado");
                ConfigurarRestriccion(PicPanelEntrenador, label4, "Rol no reconocido - Acceso limitado");
                ConfigurarRestriccion(PicPanelSeguimiento, label6, "Rol no reconocido - Acceso limitado");
            }
        }

        private void ConfigurarRestriccion(PictureBox pic, Label lbl, string mensaje)
        {
            pic.Tag = "RESTRINGIDO";
            lbl.Tag = "RESTRINGIDO";
            _toolTip.SetToolTip(pic, mensaje);
            _toolTip.SetToolTip(lbl, mensaje);
            pic.Cursor = Cursors.No;
            lbl.Cursor = Cursors.No;
        }

        private bool TienePermiso(Control control)
        {
            return control.Tag?.ToString() != "RESTRINGIDO";
        }

        private bool VerificarYMostrarRestriccion(Control control, string nombreModulo)
        {
            if (!TienePermiso(control))
            {
                MessageBox.Show(
                    $"⛔ Acceso Restringido\n\n" +
                    $"No tienes permiso para acceder al módulo '{nombreModulo}' con tu rol actual.\n\n" +
                    $"Tu rol: {_usuarioActivo.Rol}\n" +
                    $"Consulta con el administrador si necesitas acceso.",
                    "Acceso Denegado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return false;
            }
            return true;
        }

        // Eventos de PictureBox
        private void PicPanelMembresia(object sender, EventArgs e)
        {
            if (!VerificarYMostrarRestriccion(PicPanelMemebresia, "Membresías")) return;
            if (_registroMembresiasForm == null || _registroMembresiasForm.IsDisposed)
                _registroMembresiasForm = new RegistroMembresias(this);
            _registroMembresiasForm.Show();
            this.Hide();
        }

        private void PicPanelEntrenadores(object sender, EventArgs e)
        {
            if (!VerificarYMostrarRestriccion(PicPanelEntrenador, "Entrenadores")) return;
            if (_registroEntrenadoresForm == null || _registroEntrenadoresForm.IsDisposed)
                _registroEntrenadoresForm = new RegistroEntrenadores(this);
            _registroEntrenadoresForm.Show();
            this.Hide();
        }

        private void PicPanelRutina_Click(object sender, EventArgs e)
        {
            if (!VerificarYMostrarRestriccion(PicPanelRutina, "Rutinas")) return;
            if (_registroRutinaForm == null || _registroRutinaForm.IsDisposed)
                _registroRutinaForm = new RegistroRutina(this);
            _registroRutinaForm.Show();
            this.Hide();
        }

        private void PicPanelPagoMembresia_Click(object sender, EventArgs e)
        {
            if (!VerificarYMostrarRestriccion(PicPanelPagoMembresia, "Pagos de Membresía")) return;
            PagosMembresia pagoMembresia = PagosMembresia.ObtenerInstancia(_usuarioActivo);
            pagoMembresia.Show();
            this.Hide();
        }

        private void PicPanelSeguimiento_Click(object sender, EventArgs e)
        {
            if (!VerificarYMostrarRestriccion(PicPanelSeguimiento, "Seguimiento de Peso")) return;
            if (_seguimientoForm == null || _seguimientoForm.IsDisposed)
                _seguimientoForm = new PesoSeguimien(_usuarioActivo, this);
            _seguimientoForm.Show();
            this.Hide();
        }

        private void PicPanelUsuario_Click(object sender, EventArgs e)
        {
            if (!VerificarYMostrarRestriccion(PicPanelUsuario, "Usuarios")) return;
            if (_registroUsuariosForm == null || _registroUsuariosForm.IsDisposed)
                _registroUsuariosForm = new RegsitroUsuarios(_usuarioActivo);
            _registroUsuariosForm.Show();
            this.Hide();
        }

        // Eventos de Labels
        private void label1_Click(object sender, EventArgs e)
        {
            if (!VerificarYMostrarRestriccion(label1, "Usuarios")) return;
            if (_registroUsuariosForm == null || _registroUsuariosForm.IsDisposed)
                _registroUsuariosForm = new RegsitroUsuarios(_usuarioActivo);
            _registroUsuariosForm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (!VerificarYMostrarRestriccion(label2, "Membresías")) return;
            if (_registroMembresiasForm == null || _registroMembresiasForm.IsDisposed)
                _registroMembresiasForm = new RegistroMembresias(this);
            _registroMembresiasForm.Show();
            this.Hide();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            if (!VerificarYMostrarRestriccion(label3, "Pagos de Membresía")) return;
            PagosMembresia pagoMembresia = PagosMembresia.ObtenerInstancia(_usuarioActivo);
            pagoMembresia.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (!VerificarYMostrarRestriccion(label4, "Entrenadores")) return;
            if (_registroEntrenadoresForm == null || _registroEntrenadoresForm.IsDisposed)
                _registroEntrenadoresForm = new RegistroEntrenadores(this);
            _registroEntrenadoresForm.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (!VerificarYMostrarRestriccion(label5, "Rutinas")) return;
            if (_registroRutinaForm == null || _registroRutinaForm.IsDisposed)
                _registroRutinaForm = new RegistroRutina(this);
            _registroRutinaForm.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            _isNavigating = true;
            RegistroEquipo equipo = new RegistroEquipo(_usuarioActivo);
            equipo.Show();
            this.Close();
        }

        // Eventos auxiliares
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void btnDespliegue_Load(object sender, EventArgs e) { }
        private void btnDespliegue_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isNavigating) Application.Exit();
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
            RegistroEquipo equipo = new RegistroEquipo(_usuarioActivo);
            equipo.Show();
            this.Close();
        }

        private void Despliegue_Click(object sender, EventArgs e) { }
    }
}
