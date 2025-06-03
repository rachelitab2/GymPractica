using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymNegocio;

namespace GymPresentacion
{
    public partial class Form1 : Form
    {
        public Servicio_Membresia _servicioMembresia;
        public Form1()
        {
            InitializeComponent();
            _servicioMembresia = new Servicio_Membresia();
            CargarMembresia();
            ConfigurarDataGridView();
            AsignarEventosBotones();
        }

        private void CargarMembresia()
        {
            try
            {
                List<Membresia> membresias = _servicioMembresia.ObtenerTodasLasMembresias();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = membresias;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al Cargar las memebresias: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarDataGridView()
        {
            
        }

        private void AsignarEventosBotones()
        {
            btnAgregar.Click -= BtnAgregar_Click;
            btnAgregar.Click += BtnAgregar_Click;

            btnEditar.Click -= BtnEditar_Click;
            btnEditar.Click += BtnEditar_Click;

            btnEliminar.Click -= BtnEliminar_Click;
            btnEliminar.Click += BtnEliminar_Click;

            dataGridView1.SelectionChanged -= DataGridView1_SelectionChanged;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }
       
      public void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                //para validar datos de antrada 
                if (string.IsNullOrWhiteSpace(txtNombreCliente.Text) ||
                    string.IsNullOrWhiteSpace(txtTipoMembresia.Text) ||
                    !DateTime.TryParse(txtFechaInicio.Text, out DateTime fechaInicio)||
                    !decimal.TryParse(txtCostoTotal.Text, out decimal costoTotal))
                {
                    MessageBox.Show("Por Favor, rellenar todos los campos correctamente. La fecha debe ser valida. ", " Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Membresia nuevaMembresia;
                string tipoMembresiaInput = txtTipoMembresia.Text.Trim().ToLower();

                if(tipoMembresiaInput == "anual")
                {
                    nuevaMembresia = new Anual(fechaInicio, Convert.ToDecimal(txtCostoTotal), txtNombreCliente.Text.Trim()); 
                }
                else if (tipoMembresiaInput == "mensual")
                {
                 nuevaMembresia = new Mensual(fechaInicio, Convert.ToDecimal(txtCostoTotal), txtNombreCliente.Text.Trim());    
                }
                else
                {
                    MessageBox.Show("Tipo de membresía no válido. Debe ser 'Mensual' o 'Anual'.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                    _servicioMembresia.RegistrarMembresia(nuevaMembresia);
                MessageBox.Show("Membresia agregada con exito.", "Exito",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                LimpiarCampos();
                CargarMembresia();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar la membresia: {ex.Message} ", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por Favor, seleccionar una memebresia para editar.", " Seleccion Requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Membresia membresiaAEditar = dataGridView1.SelectedRows[0].DataBoundItem as Membresia;
                if (membresiaAEditar == null)
                {
                    MessageBox.Show("No se pudo obtener la membresia seleccionada.", "Error Interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                // Agrega validación para el costo
                if (string.IsNullOrWhiteSpace(txtNombreCliente.Text) ||
                    string.IsNullOrWhiteSpace(txtTipoMembresia.Text) ||
                    !DateTime.TryParse(txtFechaInicio.Text, out DateTime fechaInicioActualizada) ||
                    !decimal.TryParse(txtCostoTotal.Text, out decimal costoTotalActualizado))
                {
                    MessageBox.Show("Por favor, Completa Nombre, Tipo de Cliente y una fecha de Inicio Valida para actualizar.", " Datos Imcompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
                DateTime fechaFinActualizada;
                string tipoMembresiaLower = txtTipoMembresia.Text.Trim().ToLower(); // Convertir a minúsculas para comparar

                if (tipoMembresiaLower == "anual")
                {
                    fechaFinActualizada = fechaInicioActualizada.AddYears(1); // Suma 1 año si es anual
                }
                else if (tipoMembresiaLower == "mensual")
                {
                    fechaFinActualizada = fechaInicioActualizada.AddMonths(1); // Suma 1 mes si es mensual
                }
                else
                {
                    // Si el tipo de membresía no es reconocido, podrías mantener la fecha de fin actual
                    // o mostrar una advertencia. Para este ejemplo, la mantendremos o puedes elegir asignarle un valor por defecto.
                    MessageBox.Show("Tipo de membresía no válido. La Fecha Fin no se actualizará correctamente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    fechaFinActualizada = membresiaAEditar.FechaFin; // Mantener la fecha de fin existente
                }

                membresiaAEditar.Nombre = txtNombreCliente.Text.Trim();
                membresiaAEditar.FechaInicio = fechaInicioActualizada;
                membresiaAEditar.FechaFin = fechaFinActualizada; 
                membresiaAEditar.CostoTotal = costoTotalActualizado;

                _servicioMembresia.ActualizarMembresia(membresiaAEditar);
                MessageBox.Show("Membresia Actualizada exitosamente.", " Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarMembresia();

            }
            catch (Exception ex)
            {
                MessageBox.Show($" Error al Actualizar la membresia: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if(dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecciona una memebresia de la para Eliminar.", " Ninguna Seleccion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
                Membresia membresiaAEliminar = dataGridView1.SelectedRows[0].DataBoundItem as Membresia;
                if (membresiaAEliminar == null)
                {
                    MessageBox.Show(" No se pudo obtener la membresia seleccionada para eliminar.","Error Interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult resultado = MessageBox.Show
                    ($"Estas seguro de que quieres eliminar  la membresia de {membresiaAEliminar.Nombre} (ID: {membresiaAEliminar.Id})",
                    " Confirmar Eliminacion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if ( resultado == DialogResult.Yes )
                {
                    _servicioMembresia.EliminarMembresia(membresiaAEliminar.Id);
                    MessageBox.Show("Membresia Eliminada exitosamente.", " Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarMembresia();

                }
            }

            catch(Exception ex)
            {
                MessageBox.Show($"Error al Eliminar la membresia: {ex.Message}", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Membresia membresiaSeleccionada = dataGridView1.SelectedRows[0].DataBoundItem as Membresia;
                if (membresiaSeleccionada != null)
                {
                    txtNombreCliente.Text = membresiaSeleccionada.Nombre;
                    txtTipoMembresia.Text = membresiaSeleccionada.TipoMembresia;
                    txtFechaInicio.Text = membresiaSeleccionada.FechaInicio.ToShortDateString();
                    txtCostoTotal.Text = membresiaSeleccionada.CostoTotal.ToString("F2");

                }
            }
            else
            {
                LimpiarCampos();
            }

        }



        private void LimpiarCampos()
        {
            txtNombreCliente.Clear();
            txtTipoMembresia.Clear();
            txtFechaInicio.Clear();
            txtCostoTotal.Clear();


        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
