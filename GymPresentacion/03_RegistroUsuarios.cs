using GymDatos;
using GymNegocio.Login;
using Microsoft.Data.SqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace GymPresentacion
{
    public partial class RegsitroUsuarios : Form
    {
        private readonly AccesoUsuario accesoUsuario;
        private readonly UsuariosActivos _usuarioActivo;
        private bool _isNavigating = false;




        public RegsitroUsuarios(UsuariosActivos usuarioActivo)
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
            PicUsuariosInicio.Click += PicUsuarios_Click;
            this.Load += RegsitroUsuario_Load;
        }

        private void RegsitroUsuario_Load(object sender, EventArgs e)
        {

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

                dgvUsuarios.AutoGenerateColumns = false; // 👈 esto es clave
                dgvUsuarios.Columns.Clear(); // Limpiamos columnas anteriores

                // Añadimos columnas manualmente con nombres correctos
                dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Id", // nombre interno
                    HeaderText = "ID", // lo que se ve en la tabla
                    DataPropertyName = "Id", // el nombre de la propiedad en la clase
                    Visible = false // si no quieres mostrar el ID
                });

                dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Usuario",
                    HeaderText = "Usuario",
                    DataPropertyName = "Usuario"
                });

                dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Rol",
                    HeaderText = "Rol",
                    DataPropertyName = "Rol"
                });
                dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Contrasena", // 🔴 Este nombre es el que se usa luego en .Cells["Contrasena"]
                    HeaderText = "Contraseña",
                    DataPropertyName = "Contrasena",
                    Visible = false // para que no se muestre en la tabla pero sí se use internamente
                });


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
            // Validaciones antes de insertar
            string usuario = txtNombreUsuario.Text.Trim();
            string contrasena = txtContasena.Text.Trim();
            string rol = cmbRolUsuario.SelectedItem?.ToString();

            // Validar campos vacíos
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena) || string.IsNullOrEmpty(rol))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar longitud máxima (ajusta según tu base de datos)
            if (usuario.Length > 20)
            {
                MessageBox.Show("El nombre de usuario no puede tener más de 20 caracteres.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (contrasena.Length > 20)
            {
                MessageBox.Show("La contraseña no puede tener más de 20 caracteres.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                UsuariosActivos nuevoUsuario = new UsuariosActivos
                {
                    Usuario = usuario,
                    Contrasena = contrasena,
                    Rol = rol
                };

                accesoUsuario.InsertarUsuario(nuevoUsuario);  // Tu método de la capa de negocio
                MessageBox.Show("Usuario agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarUsuarios(); // Refresca el DataGridView
                LimpiarCampos();  // Limpia los TextBox
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("truncated"))
                {
                    MessageBox.Show("Uno de los campos excede el tamaño permitido en la base de datos.\nPor favor, reduce el texto.", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Error de base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                var fila = dgvUsuarios.SelectedRows[0];
                txtNombreUsuario.Text = fila.Cells["Usuario"].Value.ToString();
                cmbRolUsuario.SelectedItem = fila.Cells["Rol"].Value.ToString();

                // ⬇️ Agrega esta línea para que la contraseña se muestre
                txtContasena.Text = fila.Cells["Contrasena"]?.Value?.ToString() ?? "";
            }
            else
            {
                LimpiarCampos();
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {

        }



        private void LimpiarCampos()
        {
            txtNombreUsuario.Clear();
            txtContasena.Clear();
            cmbRolUsuario.SelectedIndex = 0;
        }

        private void PicUsuarios_Click(object sender, EventArgs e)
        { // Asegura que no se ejecuta más de una vez accidentalmente
            if (_isNavigating) return;
            _isNavigating = true;

            btnDespliegue principal = new btnDespliegue(_usuarioActivo);
            principal.StartPosition = FormStartPosition.CenterScreen;
            principal.Show();

            this.Close(); // Cierra RegsitroUsuarios
        }
        private void btnVolverAlMenu_Click(object sender, EventArgs e)
        {
            btnDespliegue principal = new btnDespliegue(_usuarioActivo);
            principal.StartPosition = FormStartPosition.CenterScreen;
            principal.Show();
            this.Close(); // Cierra el formulario actual
        }

        private void Form6Usuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isNavigating)
            {
                Application.Exit();
            }
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {



        }


        private void chkMostrarContrasena1_CheckedChanged(object sender, EventArgs e)
        {
            txtContasena.UseSystemPasswordChar = !chkMostrarContrasena1.Checked;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreUsuario.Clear();
            txtContasena.Clear();
            cmbRolUsuario.SelectedIndex = 0; // o -1 si quieres que quede sin seleccionar

            // Si tienes un CheckBox de mostrar contraseña, lo reseteas también:
            chkMostrarContrasena1.Checked = false;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            txtContasena.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void btnLimpiar1_Click(object sender, EventArgs e)
        {
            // Limpiar campos de texto
            txtNombreUsuario.Clear();
            txtContasena.Clear();

            // Reiniciar selección del ComboBox
            cmbRolUsuario.SelectedIndex = 0; // o -1 si quieres que quede sin seleccionar

            // Desmarcar el checkbox de mostrar contraseña
            chkMostrarContrasena1.Checked = false;

            // Volver a ocultar la contraseña si estaba visible
            txtContasena.UseSystemPasswordChar = true;

            // (Opcional) Establecer foco en el primer campo
            txtNombreUsuario.Focus();
        }
    }
}
