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

        }

        private void Form5LogIn_Load(object sender, EventArgs e)
        {

        }
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();
            string rol = cmbRol.SelectedItem?.ToString(); // Usa ? para evitar NullReferenceException

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
                    UsuariosActivos usuariosActivos = new UsuariosActivos
                    {
                        Usuario = usuario,
                        Contrasena = contrasena,
                        Rol = rolValidado
                    };

                    MessageBox.Show($"¡Bienvenido, {usuariosActivos.Usuario}! Rol: {usuariosActivos.Rol}", "Acceso Permitido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reemplaza esto con el menú correspondiente según el rol
                    btnDespliegue principal = new btnDespliegue(usuariosActivos);
                    principal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas o rol no autorizado.", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void Form5LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void lblTipoAcceso_Click(object sender, EventArgs e)
        {

        }
    }
}
