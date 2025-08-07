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
using Microsoft.VisualBasic.ApplicationServices;

namespace GymPresentacion
{
    public partial class RegistroRutina : Form
    {

        private readonly Servicio_Rutinas _servicioRutinas;
        private Rutina _rutinaSeleccionada;
        private readonly Form _formPrincipal;
        private bool _isNavigating = false;
        private readonly Form _dashboard;
        public RegistroRutina(Form dashboard)
        {
            InitializeComponent();
            _dashboard = dashboard;
            _servicioRutinas = new Servicio_Rutinas();
            ConfigurarDataGridView();
            ConfigurarControles();
            AsignarEventos();
            this.FormClosing += Form3Rutina_FormClosing;
        }



        private void ConfigurarControles()
        {
            if (cmbGeneroRutina.Items.Count == 0)
            {
                cmbGeneroRutina.Items.AddRange(new string[] { "Masculino", "Femenino", "Mixto" });
                cmbGeneroRutina.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            if (cmbAreaRutina.Items.Count == 0)
            {
                cmbAreaRutina.Items.AddRange(new string[] { "Pecho", "Espalda", "Piernas", "Brazos", "Hombros", "Abdomen" });
                cmbAreaRutina.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            nudDuracion.Minimum = 5;
            nudDuracion.Maximum = 120;
            nudDuracion.Value = 30;

        }


        private void AsignarEventos()
        {

            btnAgregarRutina.Click += BtnAgregarRutina_Click;
            btnEditarRutina.Click += BtnEditarRutina_Click;
            btnEliminarRutina.Click += BtnEliminarRutina_Click;
            btnConsultarRutina.Click += BtnConsultarRutina_Click;
            dgvRutinas.SelectionChanged += DgvRutinas_SelectionChanged;

           

            PicRutinaInicio.Click += PicRutinaInicio_Click;
        }





        private void ConfigurarDataGridView()

        {
            dgvRutinas.AutoGenerateColumns = false;
            dgvRutinas.Columns.Clear();

            dgvRutinas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                Name = "Id",
                Visible = false

            });

            dgvRutinas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreRutina",
                HeaderText = "Nombre",
                Name = "NombreRutina",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvRutinas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Genero",
                HeaderText = "Genero",
                Name = "Genero",
                Width = 100
            });

            dgvRutinas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "AreaCuerpo",
                HeaderText = "Area del Cuerpo",
                Name = "AreaCuerpo",
                Width = 120
            });

            dgvRutinas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DuracionMinutos",
                HeaderText = "Duracion (min)",
                Name = "DuracionMinutos",
                Width = 80
            });



        }

        private void Form3Rutina_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isNavigating)
            {
                _dashboard.Show();

            }

        }


        private void DgvRutinas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRutinas.SelectedRows.Count > 0)
            {

                _rutinaSeleccionada = dgvRutinas.SelectedRows[0].DataBoundItem as Rutina;

                if (_rutinaSeleccionada != null)
                {
                    txtNombreRutina.Text = _rutinaSeleccionada.NombreRutina;
                    cmbGeneroRutina.SelectedItem = _rutinaSeleccionada.Genero;
                    cmbAreaRutina.SelectedItem = _rutinaSeleccionada.AreaCuerpo;
                    nudDuracion.Value = _rutinaSeleccionada.DuracionMinutos;

                }
                else
                {
                    LimpiarCampos();
                }
            }
        }

        private void BtnAgregarRutina_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombreRutina.Text) || cmbGeneroRutina.SelectedItem == null || cmbAreaRutina.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, complete todos los campos requeridos.", "Campos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (_servicioRutinas.ExisteRutina(txtNombreRutina.Text.Trim()))
                {
                    MessageBox.Show("Ya existe una rutina con este Nombre. Por Favor, elija otro.", " Error de Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Rutina nuevaRutina = new Rutina
                {
                    NombreRutina = txtNombreRutina.Text.Trim(),
                    Genero = cmbGeneroRutina.SelectedItem.ToString(),
                    AreaCuerpo = cmbAreaRutina.SelectedItem.ToString(),
                    DuracionMinutos = (int)nudDuracion.Value,

                };


                _servicioRutinas.RegistrarRutina(nuevaRutina);
                MessageBox.Show("Rutina Agregada exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnConsultarRutina_Click(sender, e);

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
                if (_servicioRutinas.ExisteRutina(txtNombreRutina.Text.Trim(), _rutinaSeleccionada.Id))
                {
                    MessageBox.Show("Ya existe otra Rutina con este Nombre, Por favor, Elija Otro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _rutinaSeleccionada.NombreRutina = txtNombreRutina.Text.Trim();
                _rutinaSeleccionada.Genero = cmbGeneroRutina.SelectedItem.ToString();
                _rutinaSeleccionada.AreaCuerpo = cmbAreaRutina.SelectedItem.ToString();
                _rutinaSeleccionada.DuracionMinutos = (int)nudDuracion.Value;


                _servicioRutinas.ActualizarRutina(_rutinaSeleccionada);
                MessageBox.Show("Rutina Actuslizar  exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnConsultarRutina_Click(sender, e);
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
                    BtnConsultarRutina_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al Eliminar Rutina: {ex.Message}", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void BtnConsultarRutina_Click(object sender, EventArgs e)
        {
            try
            {
                List<Rutina> rutina = _servicioRutinas.ObtenerTodasLasRutinas();
                dgvRutinas.DataSource = null;
                dgvRutinas.DataSource = rutina;

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al Cargar las Rutinas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void PicMemRutina_Click(object sender, EventArgs e)
        {
            _isNavigating = true;
            RegistroMembresias formMembresias = RegistroMembresias.ObtenerInstancia(_dashboard);
            formMembresias.WindowState = this.WindowState;
            formMembresias.Show();
            this.Close();
        }
        private void PicEntrenadorIr_Click(object sender, EventArgs e)
        {
            _isNavigating = true;
            RegistroEntrenadores formEntrenadores = new RegistroEntrenadores(_dashboard);
            formEntrenadores.WindowState = this.WindowState;
            formEntrenadores.Show();
            this.Close();
        }

        private void LimpiarCampos()
        {
            txtNombreRutina.Clear();
            cmbGeneroRutina.SelectedIndex = -1;
            cmbAreaRutina.SelectedIndex = -1;
            nudDuracion.Value = 60;
            _rutinaSeleccionada = null;

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

        private void PicMem2_Load(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PicRutinaInicio_Click(object sender, EventArgs e)
        {
            _isNavigating = true; // Avisamos que estamos navegando
            _dashboard.Show();    // Mostramos el panel principal
            this.Close();         // Cerramos la ventana actual
        }

        private void txtNombreRutina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <=64) || (e.KeyChar >= 91 && e.KeyChar <=96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
