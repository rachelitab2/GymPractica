using GymNegocio.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymPresentacion
{
    public partial class RegistroEquipo : Form
    {
        private bool _isNavigating = false;
        private UsuariosActivos _usuarioActivo;


        int contadorId = 1;

        //al no tener parametro el parametro este daba error a la hora de salir de form
        public RegistroEquipo()
        {
            InitializeComponent();
        }
        //cambio agregado
        //Constructor del formulario, recibe el usuario activo como parámetro y lo guarda
        //para usarlo dentro del formulario.
        public RegistroEquipo(UsuariosActivos usuarioActivo)
        {
            InitializeComponent();
            _usuarioActivo = usuarioActivo;
        }

        private void lblDescripcionEquipo_Click(object sender, EventArgs e)
        {

        }

        private void lblPrecioEquipo_Click(object sender, EventArgs e)
        {

        }

        private void lblAreaUsoEquipo_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void PicEquipoInicio_Click(object sender, EventArgs e)
        {


            _isNavigating = true;
            btnDespliegue principal = new btnDespliegue(_usuarioActivo);
            principal.StartPosition = FormStartPosition.CenterScreen;
            principal.Show();
            this.Close();

        }

        private void txtNombreEquipo_TextChanged(object sender, EventArgs e)
        {
            string texto = txtNombreEquipo.Text;

            if (!System.Text.RegularExpressions.Regex.IsMatch(texto, @"^[a-zA-Z\s]*$"))
            {
                MessageBox.Show("Solo se permiten letras y espacios.");
                txtNombreEquipo.Text = string.Concat(texto.Where(c => char.IsLetter(c) || char.IsWhiteSpace(c)));
                txtNombreEquipo.SelectionStart = txtNombreEquipo.Text.Length;
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            int max = 255;
            int actuales = txtDescripcion.Text.Length;
            this.Text = $"Descripción ({actuales}/{max})"; // Muestra el conteo en el título del formulario

            if (actuales > max)
            {
                MessageBox.Show("Máximo 255 caracteres permitidos.");
                txtDescripcion.Text = txtDescripcion.Text.Substring(0, max);
                txtDescripcion.SelectionStart = txtDescripcion.Text.Length;
            }

        }

        private void cmbAreaUso_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? areaSeleccionada = cmbAreaUso.SelectedItem as string;
            if (!string.IsNullOrEmpty(areaSeleccionada))
            {
                MessageBox.Show("Has seleccionado el área de uso: " + areaSeleccionada);
            }
        }

        private void dtpFechaEntrega_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = dtpFechaEntrega.Value;
            MessageBox.Show("Fecha de entrega seleccionada: " + fechaSeleccionada.ToShortDateString());
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y teclas de control (como Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignorar cualquier otra tecla
            }
        }

        private void btnAgregarEquipo_Click(object sender, EventArgs e)
        {
            // Validar que los campos obligatorios no estén vacíos
            if (string.IsNullOrWhiteSpace(txtNombreEquipo.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtPrecioEquipo.Text) ||
                cmbAreaUso.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor completa todos los campos antes de agregar el equipo.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que el precio sea un número válido decimal positivo
            if (!decimal.TryParse(txtPrecioEquipo.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Ingresa un precio válido mayor que cero.", "Precio inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Preparar los datos
            int id = contadorId++; // autoincrementa
            string nombre = txtNombreEquipo.Text.Trim();
            string descripcion = txtDescripcion.Text.Trim();
            string areaUso = cmbAreaUso.SelectedItem.ToString();
            string fechaEntrega = dtpFechaEntrega.Value.ToShortDateString();
            string precioStr = precio.ToString("F2");

            // Agregar fila al DataGridView en el orden de las columnas
            dgvEquipos.Rows.Add(id, nombre, descripcion, precioStr, areaUso, fechaEntrega);

            // Mensaje
            MessageBox.Show("Equipo agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar campos
            txtNombreEquipo.Clear();
            txtDescripcion.Clear();
            txtPrecioEquipo.Clear();
            cmbAreaUso.SelectedIndex = -1;
            dtpFechaEntrega.Value = DateTime.Today;
            txtNombreEquipo.Focus();
        }
        

        private void btnEliminarEquipo_Click(object sender, EventArgs e)
        {
            if (dgvEquipos.SelectedRows.Count > 0)
            {
                // Confirmar si desea eliminar la fila
                DialogResult resultado = MessageBox.Show("¿Seguro que deseas eliminar el equipo seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    // Eliminar la fila seleccionada (la primera si hay varias)
                    dgvEquipos.Rows.RemoveAt(dgvEquipos.SelectedRows[0].Index);

                    MessageBox.Show("Equipo eliminado correctamente.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor selecciona una fila para eliminar.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditarEquipo_Click(object sender, EventArgs e)
        {
            if (dgvEquipos.CurrentRow != null)
            {
                txtNombreEquipo.Text = dgvEquipos.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = dgvEquipos.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtPrecioEquipo.Text = dgvEquipos.CurrentRow.Cells["Precio"].Value.ToString();
                cmbAreaUso.Text = dgvEquipos.CurrentRow.Cells["AreaUso"].Value.ToString();
                dtpFechaEntrega.Text = dgvEquipos.CurrentRow.Cells["FechaEntrega"].Value.ToString();
            }
        }

        private void btnConsultarEquipo_Click(object sender, EventArgs e)
        {
            string filtro = txtNombreEquipo.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(filtro))
            {
                // Si filtro está vacío, mostrar todas las filas
                foreach (DataGridViewRow fila in dgvEquipos.Rows)
                {
                    fila.Visible = true;
                }
            }
            else
            {
                // Mostrar solo filas cuyo nombre contenga el filtro
                foreach (DataGridViewRow fila in dgvEquipos.Rows)
                {
                    if (fila.Cells["NombreEquipo"].Value != null &&
                        fila.Cells["NombreEquipo"].Value.ToString().ToLower().Contains(filtro))
                    {
                        fila.Visible = true;
                    }
                    else
                    {
                        fila.Visible = false;
                    }
                }
            }
        }

        private void dgvEquipos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evitar edición al hacer doble clic
            dgvEquipos.ReadOnly = true;
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombreEquipo.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtPrecioEquipo.Text) ||
                cmbAreaUso.SelectedIndex == -1)
            {
                MessageBox.Show("Completa todos los campos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtPrecioEquipo.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Ingresa un precio válido mayor que cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void LimpiarControles()
        {
            txtNombreEquipo.Clear();
            txtDescripcion.Clear();
            txtPrecioEquipo.Clear();
            cmbAreaUso.SelectedIndex = -1;
            dtpFechaEntrega.Value = DateTime.Today;
            txtNombreEquipo.Focus();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvEquipos.AutoGenerateColumns = false; // <--- Aquí lo forzamos por código

            // Si ya definiste columnas manualmente desde el diseñador, no necesitas crearlas aquí
            dgvEquipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
    

