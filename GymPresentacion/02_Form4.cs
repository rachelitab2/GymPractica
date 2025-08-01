﻿using System;
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
            PicPanelDespliegue.Click += Despliegue_Click;
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

            if (_pagosMembresiaForm == null || _pagosMembresiaForm.IsDisposed)
            {
                _pagosMembresiaForm = new PagosMembresia(_usuarioActivo);
            }
            _pagosMembresiaForm.Show();

            PagosMembresia pagoMembresia = PagosMembresia.ObtenerInstancia(_usuarioActivo);
            pagoMembresia.Show();

            this.Hide();
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
            RegistroEquipo equipo = new RegistroEquipo();
            equipo.Show();
            this.Close();
        }

        private void Despliegue_Click(object sender, EventArgs e)
        {
            /*  if (MenuVertical.Width ==250)
              {
                  MenuVertical.Width = 70;
              }
              else
              {
                  MenuVertical.Width = 250;
              }*/

            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }
            else
            {
                MenuVertical.Width = 250;
            }

            // Forzar refresco por si Dock/Anchor está dando problema
            MenuVertical.Refresh();
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

    }
}

    