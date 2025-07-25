using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymDatos;
using GymNegocio.Login;
using Microsoft.Data.SqlClient;

namespace GymPresentacion
{
    public partial class Form6Usuarios : Form
    {
        private readonly AccesoUsuario accesoUsuario;
        private readonly UsuariosActivos _usuarioActivo;
        private bool _isNavigating = false;
        public Form6Usuarios(UsuariosActivos usuarioActivo)
        {
            InitializeComponent();
            accesoUsuario = new AccesoUsuario();
            _usuarioActivo = usuarioActivo;

            cmbRolUsuario.Items.AddRange(new string[] { "Administrador", "Secretario", "Entrenador" });
            cmbRolUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRolUsuario.SelectedIndex = 0;

            ConfigurarDataGridView();
            AsignarEventosBotones();
            CargarUsuarios();

            this.FormClosing += Form6Usuarios_FormClosing;
            PicUsuarios.Click += PicUsuarios_Click;
        }

        private void ConfigurarDataGridView()
        {
            dgvUsuarios.AutoGenerateColumns = false;
            dgvUsuarios.Columns.Clear();

            dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "ID",
                Width = 50,
            });

            dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Usuario",
                HeaderText = "Usuario",
                Width = 150,

            });

            dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Rol",
                HeaderText = "Rol",
                Width = 100,
            });

        }

        private void AsignarEventosBotones()
        {
            btnAgregarUsuario.Click -= BtnAgregar_Click;
            btnAgregarUsuario.Click += BtnAgregar_Click;

            btnEditarUsuario.Click -= BtnEditar_Click;
            btnEditarUsuario.Click += BtnEditar_Click;

            btnEliminarUsuario.Click -= BtnEliminar_Click;
            btnEliminarUsuario.Click += BtnEliminar_Click;

            btnConsultarUsuario.Click -= BtnConsultar_Click;
            btnConsultarUsuario.Click += BtnConsultar_Click;

            dgvUsuarios.SelectionChanged -= DgvUsuario_SelectionChanged;
            dgvUsuarios.SelectionChanged += DgvUsuario_SelectionChanged;
        }

        private void CargarUsuarios()
        {
            try
            {
                List<UsuariosActivos> usuarios = accesoUsuario.ListarUsuarios();
                dgvUsuarios.DataSource = null;
                dgvUsuarios.DataSource = usuarios;
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Cargar Usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreUsuario.Text) || string.IsNullOrWhiteSpace(txtContasena.Text))
            {
                MessageBox.Show("Por Favor, Complete todos los campos.", " Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                UsuariosActivos nuevoUsuario = new UsuariosActivos
                {
                    Usuario = txtNombreUsuario.Text.Trim(),
                    Contrasena = txtContasena.Text.Trim(),
                    Rol = cmbRolUsuario.SelectedItem.ToString()
                };

                accesoUsuario.InsertarUsuario(nuevoUsuario);
                MessageBox.Show("Usuario Agregado Exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Agregar Usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un Usuario para Editar.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtNombreUsuario.Text) || string.IsNullOrWhiteSpace(txtContasena.Text))
            {
                MessageBox.Show("Por Favor, complete todos los Campos.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dgvUsuarios.SelectedRows[0].Cells["Id"].Value;

            try
            {
                UsuariosActivos usuarioActualizado = new UsuariosActivos
                {
                    Id = id,
                    Usuario = txtNombreUsuario.Text.Trim(),
                    Contrasena = txtContasena.Text.Trim(),
                    Rol = cmbRolUsuario.SelectedItem.ToString()
                };

                accesoUsuario.ActualizarUsuario(usuarioActualizado);
                MessageBox.Show("Usuario Actualizado Exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarUsuarios();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Actualizar Usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selccione un Usuario para Eliminar.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = (int)dgvUsuarios.SelectedRows[0].Cells["Id"].Value;

            DialogResult confirm = MessageBox.Show("¿ Estas seguro de Eliminar el Usuario seleccionado?", "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            try
            {
                accesoUsuario.EliminarUsuario(id);
                MessageBox.Show("Usuario Eliminado Exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarUsuarios();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al Eliminar Usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvUsuario_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                txtNombreUsuario.Text = dgvUsuarios.SelectedRows[0].Cells["Usuario"].Value.ToString();
                //No mostramos la Contrasena por seguridad, se puede implementar cambio de contrasena aparte
                cmbRolUsuario.SelectedItem = dgvUsuarios.SelectedRows[0].Cells["Rol"].Value.ToString();
            }
            else
            {
                LimpiarCampos();
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {

        }
        // Agrega este método en la clase Form6Usuarios



        private void LimpiarCampos()
        {
            txtNombreUsuario.Clear();
            txtContasena.Clear();
            cmbRolUsuario.SelectedIndex = 0;
        }

        private void PicUsuarios_Click(object sender, EventArgs e)
        {
            
            _isNavigating = true;
            btnDespliegue principal = new btnDespliegue(_usuarioActivo);
            principal.StartPosition = FormStartPosition.CenterScreen;
            principal.Show();
            this.Close();
        }

        private void Form6Usuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isNavigating)
            {
               Application.Exit();
            }
        }
    }
}
