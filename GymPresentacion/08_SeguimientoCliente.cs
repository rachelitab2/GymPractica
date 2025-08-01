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
using GymNegocio.ClasesMembresia;
using GymNegocio.Login;


namespace GymPresentacion
{
    public partial class SeguimientoCliente : Form
    {
        private UsuariosActivos _usuarioActivo;
        private readonly Form _dashboard;  // <-- referencia al dashboard
        private bool _isNavigating = false; // Para controlar cierre

        public SeguimientoCliente(UsuariosActivos usuarioActivo, Form dashboard)
        {
             InitializeComponent();
            _usuarioActivo = usuarioActivo;
            _dashboard = dashboard;

            this.FormClosing += SeguimientoCliente_FormClosing; // para controlar el cierre
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
                Cliente nuevoCliente = new Cliente
                {
                    Nombre = ClienteSeguimiento.Text,
                    Peso = decimal.Parse(PesoSeguimien.Text),
                    Altura = decimal.Parse(AlturSeguemien.Text),
                    Grasa = decimal.Parse(GrasaSeguimien.Text),
                    FechaRegistro = FechaSeguimin.Value.Date
                };

                ClientesGym clientesGym = new ClientesGym();
                bool exito = clientesGym.Insertar(nuevoCliente);

                if (exito)
                {
                    MessageBox.Show("Cliente agregado correctamente");
                    DatosdelClienteP.DataSource = clientesGym.Listar(); // Refrescar DataGridView
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
    }
}
