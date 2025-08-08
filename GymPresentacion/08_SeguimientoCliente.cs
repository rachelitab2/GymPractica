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
using static GymNegocio.ClasesMembresia.MemGymnasio;
using GymNegocio.ClaseSegumiento;
using GymNegocio.ClasesMembresia;
using GymNegocio.Login;


namespace GymPresentacion
{

    public partial class PesoSeguimien : Form
    {
        private UsuariosActivos _usuarioActivo;
        private readonly Form _dashboard;  // <-- referencia al dashboard
        private bool _isNavigating = false; // Para controlar cierre

        public PesoSeguimien(UsuariosActivos usuarioActivo, Form dashboard)
        {
            InitializeComponent();
            _usuarioActivo = usuarioActivo;
            _dashboard = dashboard;

            this.FormClosing += SeguimientoCliente_FormClosing; // para controlar el cierre
        }

        private void SoloNumerosDecimales(object sender, KeyPressEventArgs e)
        {
            // Permitir control de retroceso
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            TextBox txt = sender as TextBox;

            // Permitir solo dígitos y un solo punto decimal
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Bloquear
            }

            // Evitar que haya más de un punto decimal
            if (e.KeyChar == '.' && txt.Text.Contains("."))
            {
                e.Handled = true; // Bloquear
            }
        }
        private void FormatearDosDecimales(object sender, EventArgs e)
        {
            var txt = sender as TextBox;
            if (decimal.TryParse(txt.Text, System.Globalization.NumberStyles.Any,
                                 System.Globalization.CultureInfo.InvariantCulture, out var val))
            {
                // Muestra con 2 decimales
                txt.Text = val.ToString("0.##", System.Globalization.CultureInfo.InvariantCulture);
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void FormClientes_Load(object sender, EventArgs e)
        {

        }


        private void SeguimientoCliente_Load(object sender, EventArgs e)
        {
            ClientesGym clientesGym = new ClientesGym();
            DatosdelClienteP.DataSource = clientesGym.Listar(); // dgvClientes es tu DataGridView
        }

        private void BotonSeguimin_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(ClienteSeguimiento.Text))
                {
                    MessageBox.Show("El nombre no puede estar vacío.");
                    return;
                }
                if (ClienteSeguimiento.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("El nombre no puede contener números.");
                    return;
                }

                // ✅ Validar que peso, altura y grasa sean numéricos
                if (!decimal.TryParse(PesoSeguimieto.Text,
                        System.Globalization.NumberStyles.Any,
                        System.Globalization.CultureInfo.InvariantCulture, out var peso))
                {
                    MessageBox.Show("Peso inválido.");
                    return;
                }

                if (!decimal.TryParse(AlturSeguemiento.Text,
                        System.Globalization.NumberStyles.Any,
                        System.Globalization.CultureInfo.InvariantCulture, out var altura))
                {
                    MessageBox.Show("Altura inválida.");
                    return;
                }

                if (!decimal.TryParse(GrasaSeguimiento.Text,
                        System.Globalization.NumberStyles.Any,
                        System.Globalization.CultureInfo.InvariantCulture, out var grasa))
                {
                    MessageBox.Show("Grasa corporal inválida.");
                    return;
                }

                // ✅ Crear cliente usando las variables ya validadas
                Cliente nuevoCliente = new Cliente
                {
                    Nombre = ClienteSeguimiento.Text,
                    Peso = peso,
                    Altura = altura,
                    Grasa = grasa,
                    FechaRegistro = FechaSeguimin.Value.Date
                };

                ClientesGym clientesGym = new ClientesGym();
                bool exito = clientesGym.Insertar(nuevoCliente);

                if (exito)
                {
                    MessageBox.Show("Cliente agregado correctamente");
                    DatosdelClienteP.DataSource = clientesGym.Listar();

                    // Limpiar campos
                    ClienteSeguimiento.Clear();
                    PesoSeguimieto.Text = "";
                    AlturSeguemiento.Text = "";
                    GrasaSeguimiento.Text = "";
                    FechaSeguimin.Value = DateTime.Today;
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el cliente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DatosdelClienteP.SelectedCells.Count > 0)
            {
                int rowIndex = DatosdelClienteP.SelectedCells[0].RowIndex;
                var valor = DatosdelClienteP.Rows[rowIndex].Cells["Id"].Value;

                if (valor != null)
                {
                    int idCliente = Convert.ToInt32(valor);

                    DialogResult result = MessageBox.Show(
                        "¿Estás seguro de eliminar este cliente?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.Yes)
                    {
                        ClientesGym clientesGym = new ClientesGym();
                        bool exito = clientesGym.Eliminar(idCliente);

                        if (exito)
                        {
                            MessageBox.Show("Cliente eliminado correctamente.");
                            DatosdelClienteP.DataSource = clientesGym.Listar(); // refrescar
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar el cliente.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo obtener el ID del cliente.");
                }
            }
            else
            {
                MessageBox.Show("Selecciona un cliente para eliminar.");
            }
        }

        // Evento para mostrar dashboard si se cierra el formulario
        private void SeguimientoCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isNavigating)
            {
                _dashboard.Show();
            }
        }

        private void AtrasInicio_Click(object sender, EventArgs e)
        {
            _isNavigating = true;  // Avisamos que vamos a navegar (volver atrás)
            _dashboard.Show();     // Mostramos el formulario principal
            this.Close();          // Cerramos este formulario actual
        }

        private void lblClienteSeguimiento_Click(object sender, EventArgs e)
        {

        }

        private void lblPeso_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {


        }

        private void FechaSeguimin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dd_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClienteSeguimiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void PesoSeguimiento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
