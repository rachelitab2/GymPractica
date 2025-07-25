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
    public partial class Form5LogIn : Form
    {
        public Form5LogIn()
        {
            InitializeComponent();
            cmbRol.Items.AddRange(new string[] { "Administrador", "Secretaria", "Entrenador" });
            cmbRol.SelectedIndex = 0; 

        }

        private void Form5LogIn_Load(object sender, EventArgs e)
        {
     
        }
        private void btnAcceder_Click(object sender, EventArgs e)
        {

            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();
            string rol = cmbRol.SelectedItem.ToString();

            AccesoUsuario acceso = new AccesoUsuario();

            try
            {
                string rolValidado = acceso.ValidarUsuario(usuario, contrasena, rol);
                if (rolValidado != null)
                {
                    UsuariosActivos usuariosActivos = new UsuariosActivos
                    {
                        Usuario = usuario,
                        Rol = rolValidado
                    };

                    //Abrir formulario principal pasado usuarioActivo para control de acceso 
                    btnDespliegue principal = new btnDespliegue(usuariosActivos);
                    principal.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Credenciales Incorrectas o rol no Autorizado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Validar Usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

            
        private void Form5LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
