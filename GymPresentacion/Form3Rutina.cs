using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymNegocio.ClasesRutinas;
using GymNegocio.ClasesEntrenador;

namespace GymPresentacion
{
    public partial class PicMem3 : Form
    {
        private readonly Servicio_Rutinas _servicioRutinas;
        private readonly Servicio_Entrenadores _servicioEntrenadores;
        private Rutina _rutinaSeleccionada;
        public PicMem3()
        {
            InitializeComponent();
            _servicioRutinas = new Servicio_Rutinas();
            _servicioEntrenadores = new Servicio_Entrenadores();
            ConfigurarDataGridView();
            ConfigurarComboBoxes();
            ConfigurarNumericUpDown();
            AsignarEventos();
            CargarRutina();
        }

        private void ConfigurarDataGridView()
        {
            dgvRutinas.AutoGenerateColumns = true;
            dgvRutinas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRutinas.MultiSelect = false;
        }

        private void ConfigurarComboBoxes()
        {
            cmbGeneroRutina.Items.Clear();
            cmbGeneroRutina.Items.Add("Masculino");
            cmbGeneroRutina.Items.Add("Femenino");
            cmbGeneroRutina.Items.Add("Mixto");
            cmbGeneroRutina.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGeneroRutina.SelectedIndex = -1;

            cmbAreaRutina.Items.Clear();
            cmbAreaRutina.Items.Add("Pecho");
            cmbAreaRutina.Items.Add("Espalda");
            cmbAreaRutina.Items.Add("Piernas");
            cmbAreaRutina.Items.Add("Brazos");
            cmbAreaRutina.Items.Add("Abdomen");
            cmbAreaRutina.Items.Add("Cardio");
            cmbAreaRutina.Items.Add("Full Body");
            cmbAreaRutina.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAreaRutina.SelectedIndex = -1;

            try
            {
                cmbEntrenador.DataSource = _servicioEntrenadores.ObtenerTodos();
                cmbEntrenador.DisplayMember = "Nombre"; // Lo que el usuario ve
                cmbEntrenador.ValueMember = "Id";       // El valor que usamos internamente
                cmbEntrenador.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al Cargar Entrenadores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ConfigurarNumericUpDown()
        {
            nudDuracion.Minimum = 1;
            nudDuracion.Maximum = 300;
            nudDuracion.Value = 60;

        }

        private void AsignarEventos()
        {
            btnAgregarRutina.Click += BtnAgregarRutina_Click;
            btnEditarRutina.Click += BtnEditarRutina_Click;
            btnEliminarRutina.Click += BtnEliminarRutina_Click;
            btnConsultarRutina.Click += BtnConsultarRutina_Click;
            dgvRutinas.SelectionChanged += DgvRutinas_SelectionChanged;
        }

        private void CargarRutina()
        {
            try
            {
                dgvRutinas.DataSource = null;
                dgvRutinas.DataSource = _servicioRutinas.ObtenerTodasLasRutinas();

                // Ocultamos las columnas que no queremos ver en la tabla
                if (dgvRutinas.Columns["Id"] != null) dgvRutinas.Columns["Id"].Visible = false;
                if (dgvRutinas.Columns["IdEntrenador"] != null) dgvRutinas.Columns["IdEntrenador"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al Caragr las Rutinas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvRutinas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRutinas.SelectedRows.Count > 0)
            {
                _rutinaSeleccionada = (Rutina)dgvRutinas.SelectedRows[0].DataBoundItem;

                if (_rutinaSeleccionada != null)
                {
                    txtNombreRutina.Text = _rutinaSeleccionada.NombreRutina;
                    cmbGeneroRutina.SelectedItem = _rutinaSeleccionada.Genero;
                    cmbAreaRutina.SelectedItem = _rutinaSeleccionada.AreaCuerpo;
                    nudDuracion.Value = _rutinaSeleccionada.DuracionMinutos;
                    cmbEntrenador.SelectedValue = _rutinaSeleccionada.IdEntrenador; // CAMPO AÑADIDO
                }
            }
        }

        private void BtnAgregarRutina_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombreRutina.Text) ||  cmbGeneroRutina.SelectedItem == null )
                {
                    MessageBox.Show("El Nombre de la Rutina y el Entrenador es Obligatorio.", "Campos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Rutina nueva = new Rutina
                {
                    NombreRutina = txtNombreRutina.Text.Trim(),
                    Genero = cmbGeneroRutina.SelectedItem.ToString(),
                    AreaCuerpo = cmbAreaRutina.SelectedItem.ToString(),
                    DuracionMinutos = (int)nudDuracion.Value,
                    IdEntrenador = (int)cmbEntrenador.SelectedValue 
                };

                _servicioRutinas.RegistrarRutina(nueva);
                MessageBox.Show("Rutina Agregada exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
                CargarRutinas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al Agregar Rutina: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEditarRutina_Click(object sender, EventArgs e)
        {
            
                if (_rutinaSeleccionada == null)
                {
                    MessageBox.Show("Por Favor, Seleccione una Rutina para editar.", "Seleccion Requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            try
            {
                _rutinaSeleccionada.NombreRutina = txtNombreRutina.Text.Trim();
                _rutinaSeleccionada.Genero = cmbGeneroRutina.SelectedItem.ToString();
                _rutinaSeleccionada.AreaCuerpo = cmbAreaRutina.SelectedItem.ToString();
                _rutinaSeleccionada.DuracionMinutos = (int)nudDuracion.Value;
                _rutinaSeleccionada.IdEntrenador = (int)cmbEntrenador.SelectedValue;

                _servicioRutinas.ActualizarRutina(_rutinaSeleccionada);
                MessageBox.Show("Rutina Actuslizar  exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
                CargarRutinas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al Actualizar Rutina: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminarRutina_Click(object sender, EventArgs e)
        {
            if (_rutinaSeleccionada == null)
            {
                MessageBox.Show(" Por favor, Seleccione una Rutina para Eliminar.", " Seleccion Requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var confirmacion = MessageBox.Show($"¿Estas seguro que deseas Eliminar la Rutina '{_rutinaSeleccionada.NombreRutina}'?", "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    _servicioRutinas.EliminarRutina(_rutinaSeleccionada.Id);
                    MessageBox.Show("Rutina Eliminada exitosamente.", " Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarCampos();
                    CargarRutinas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al Eliminar Rutina: {ex.Message}", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void BtnConsultarRutina_Click(object sender, EventArgs e)
        {
            CargarRutinas();
            MessageBox.Show("Lista de Rutinas Actualizada.", " Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void CargarRutinas()
        {
            try
            {
                List<Rutina> rutinas = _servicioRutinas.ObtenerTodasLasRutinas();
                dgvRutinas.DataSource = null;
                dgvRutinas.DataSource = rutinas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al Cargar Rutina: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

         private void LimpiarCampos()
        {
            txtNombreRutina.Clear();
            cmbGeneroRutina.SelectedIndex = -1;
            cmbAreaRutina.SelectedIndex = -1;
            cmbEntrenador.SelectedIndex = -1; 
            nudDuracion.Value = 60;
            _rutinaSeleccionada = null;
            dgvRutinas.ClearSelection();
        }


        private void cmbGeneroRutina_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblGeneroRutina_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreRutina_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminarRutina_Click(object sender, EventArgs e)
        {

        }

        private void lblDuracion_Click(object sender, EventArgs e)
        {

        }

        private void nudDuracion_ValueChanged(object sender, EventArgs e)
        {

        }

        private void PicMemRutina_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }

        private void PicMem2_Load(object sender, EventArgs e)
        {
            

        }
    }
}
