using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymDatos;
using GymNegocio.ClasesEntrenador;
using GymNegocio.Login;
using Microsoft.Data.SqlClient;
namespace GymPresentacion
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            cmbRol.Items.AddRange(new string[] { "Administrador", "Secretario", "Entrenador" });
            cmbRol.SelectedIndex = 0;
            LimpiarCampos(); // Limpiar al inicializar
            txtUsuario.Text = Properties.Settings.Default.UsuarioGuardado;
            PicVerContrasena.Click += PicVerContrasena_Click1;
            this.BackColor = Color.Black;
        }

        private void Form5LogIn_Load(object sender, EventArgs e)
        {
            panelLogin.Left = (this.ClientSize.Width - panelLogin.Width) / 2;
            panelLogin.Top = (this.ClientSize.Height - panelLogin.Height) / 2;
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();
            string rol = cmbRol.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena) || string.IsNullOrEmpty(rol))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AccesoUsuario acceso = new AccesoUsuario();

            try
            {
                string rolValidado = acceso.ValidarUsuario(usuario, contrasena, rol);
                if (rolValidado != null)
                {
                    switch (rol)
                    {
                        case "Administrador":
                            Properties.Settings.Default.UsuarioGuardado_Administrador = usuario;
                            break;
                        case "Secretario":
                            Properties.Settings.Default.UsuarioGuardado_Secretario = usuario;
                            break;
                        case "Entrenador":
                            Properties.Settings.Default.UsuarioGuardado_Entrenador = usuario;
                            break;
                    }
                    Properties.Settings.Default.Save();

                    UsuariosActivos usuariosActivos = new UsuariosActivos
                    {
                        Usuario = usuario,
                        Contrasena = contrasena,
                        Rol = rolValidado
                    };

                    SesionUsuario.Usuario = usuario;
                    SesionUsuario.Rol = rolValidado;

                    MessageBox.Show($"¡Bienvenido, {usuariosActivos.Usuario}! Rol: {usuariosActivos.Rol}", "Acceso Permitido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnDespliegue principal = new btnDespliegue(usuariosActivos);
                    principal.Show();
                    this.Hide();
                }
                else
                {
                    OnLoginFallido();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Hide();
        }

        private void Form5LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            string rol = cmbRol.SelectedItem?.ToString();
            switch (rol)
            {
                case "Administrador":
                    txtUsuario.Text = Properties.Settings.Default.UsuarioGuardado_Administrador;
                    break;
                case "Secretario":
                    txtUsuario.Text = Properties.Settings.Default.UsuarioGuardado_Secretario;
                    break;
                case "Entrenador":
                    txtUsuario.Text = Properties.Settings.Default.UsuarioGuardado_Entrenador;
                    break;
                default:
                    txtUsuario.Text = "";
                    break;
            }
        }

        private void PicVerContrasena_Click1(object sender, EventArgs e)
        {
            txtContrasena.UseSystemPasswordChar = !txtContrasena.UseSystemPasswordChar;
        }

        //TODO Método para limpiar todos los campos del formulario
        public void LimpiarCampos()
        {
            if (txtUsuario != null)
            {
                txtUsuario.Clear();
                txtUsuario.Text = "";
            }
            if (txtContrasena != null)
            {
                txtContrasena.Clear();
                txtContrasena.Text = "";
            }
            if (cmbRol != null)
            {
                cmbRol.SelectedIndex = 0;
            }
            if (txtUsuario != null)
            {
                txtUsuario.Focus();
            }
        }

        //TODO Método para limpiar después de un login fallido
        private void OnLoginFallido()
        {
            LimpiarDespuesDeLogin();
            MessageBox.Show("Credenciales incorrectas", "Error de Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtUsuario.Focus();
        }

        // Opcional: Método para limpiar después de un login exitoso o fallido
        private void LimpiarDespuesDeLogin()
        {
            if (txtContrasena != null)
            {
                txtContrasena.Clear();
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void lblLogin_Click(object sender, EventArgs e) { }
        private void lblTipoAcceso_Click(object sender, EventArgs e) { }
        private void txtUsuario_TextChanged(object sender, EventArgs e) { }
        private void checkBox1_CheckedChanged(object sender, EventArgs e) { }
    }
}
