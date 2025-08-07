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
using GymNegocio;// ver 
using GymNegocio.ClasesMembresia;
using GymNegocio.Login;

namespace GymPresentacion // nombre importante
{
    public partial class RegistroMembresias : Form
    {
        public Servicio_Membresia _servicioMembresia;//inastancia del servicio de membresia
        private readonly Form _dashboard; // Para guardar la referencia al panel principal
        private bool _isNavigating = false; // Para controlar el cierre del formulario
        private static RegistroMembresias instancia;
        private UsuariosActivos usuariosActivos;

        public RegistroMembresias(Form dashboard)
        {
            InitializeComponent();
            _dashboard = dashboard;
            _servicioMembresia = new Servicio_Membresia(); // instaciacion 
            ConfigurarDataGridView();// donde se muestra los datos
            ConfigurarComboBoxTipoMembresia(); // opciones para los tipos Mensual Y Anual
            ConfigurarMaskedTextBoxTelefono();//telefono y captura de error para el mismo 
            AsignarEventosBotones();//conctar los eventos de los botones con sus funciones 
            this.FormClosing += Form1_FormClosing;
            instancia = this;
        }

        public RegistroMembresias(UsuariosActivos usuariosActivos)
        {
            this.usuariosActivos = usuariosActivos;
        }

        public static RegistroMembresias ObtenerInstancia(Form dashboard)
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new RegistroMembresias(dashboard);
            }
            return instancia;
        }


        private void ConfigurarDataGridView() //configuracion para el DataGridView
        {
            dataGridView1.AutoGenerateColumns = false; // no permite general columnas de forma automatica 
            dataGridView1.Columns.Clear();

            //Como seran las columnas 
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "ID",
                Width = 50
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre",
                Width = 150
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TipoMembresia",
                HeaderText = " Tipo",
                Width = 80

            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FechaInicio",
                HeaderText = " Inicio",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FechaFin",
                HeaderText = "Vencimiento",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CostoTotal",
                HeaderText = "Costo",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            dataGridView1.Columns.Add(new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "Activa",
                HeaderText = "Activa",
                Width = 60
            });
        }

        //EVENTOS PARA LOS BOTONES 
        private void AsignarEventosBotones()
        {
            if (btnAgregar != null)// para ver si se creo el boton
            {
                btnAgregar.Click -= BtnAgregar_Click;
                btnAgregar.Click += BtnAgregar_Click;
            }

            if (btnEditar != null)
            {
                btnEditar.Click -= BtnEditar_Click;
                btnEditar.Click += BtnEditar_Click;
            }

            if (btnEliminar != null)
            {

                btnEliminar.Click -= BtnEliminar_Click;
                btnEliminar.Click += BtnEliminar_Click;
            }

            if (btnConsultar != null)
            {
                btnConsultar.Click -= BtnConsultar_Click;
                btnConsultar.Click += BtnConsultar_Click;
            }

            if (dataGridView1 != null)
            {
                dataGridView1.SelectionChanged -= DataGridView1_SelectionChanged;
                dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            }
        }

        public void BtnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarCampos();

                List<Membresia> membresias = _servicioMembresia.ObtenerTodasLasMembresias();

                if (membresias != null && membresias.Count > 0)
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = membresias;
                    MessageBox.Show($"Se cargaron {membresias.Count} membresias correctamente.", "Consulta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dataGridView1.DataSource = null;
                    MessageBox.Show("No se encontraron membresias en la base de datos.", " Sin Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al Consultar las membresias: {ex.Message}", "Error de Consultar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public void BtnAgregar_Click(object sender, EventArgs e) //AGREGAR NUEVA MEMEBRSIA 
        {
            try //Captura de error
            {

                //para validar datos de antrada 
                if (string.IsNullOrWhiteSpace(txtNombreCliente.Text) ||
                   cmbTipoMembresia.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(mtxtTelefono.Text))

                {
                    MessageBox.Show("Por Favor, rellenar todos los campos correctamente. La fecha debe ser valida. ", " Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!mtxtTelefono.MaskCompleted)
                {
                    MessageBox.Show("Por favor, complete el número de teléfono.",
                                  "Teléfono Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mtxtTelefono.Focus();
                    return;
                }

                if (!ValidarTelefono(mtxtTelefono.Text))
                {
                    MessageBox.Show("El número de teléfono no es válido. Debe usar un código de área válido (809, 829, 849).",
                                  "Teléfono Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mtxtTelefono.Focus();
                    return;
                }


                DateTime fechaInicio = dateTimePickerInicio.Value.Date;
                string nombreCliente = txtNombreCliente.Text.Trim();
                string telefonoCliente = mtxtTelefono.Text.Trim();

                // Crear la memebresia segun su tipo
                Membresia nuevaMembresia;
                string tipoMembresiaInput = cmbTipoMembresia.SelectedItem.ToString().ToLower();

                if (tipoMembresiaInput == "anual")
                {
                    nuevaMembresia = new Anual(fechaInicio, nombreCliente, telefonoCliente);
                }
                else if (tipoMembresiaInput == "mensual")
                {
                    nuevaMembresia = new Mensual(fechaInicio, nombreCliente, telefonoCliente);
                }
                else
                {
                    MessageBox.Show("Tipo de membresía no válido. Debe ser 'Mensual' o 'Anual'.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _servicioMembresia.RegistrarMembresia(nuevaMembresia);
                MessageBox.Show("Membresia agregada con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                LimpiarCampos();
                //recargar los datos automaticamente despues de agregar una nueva membresia 
                BtnConsultar_Click(sender, e);

            }
            catch (Exception ex) //Captura de error 
            {
                MessageBox.Show($"Error al agregar la membresia: {ex.Message} ", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)//EDITAR MEMBRESIAS QUE YA EXISTEN O FUERON CREADAS 
        {
            try//captura de error 
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por Favor, seleccionar una membresia para editar.", " Seleccion Requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    cmbTipoMembresia.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(mtxtTelefono.Text))
                {
                    MessageBox.Show("Por favor, Completa Nombre, Tipo de Cliente y una fecha de Inicio Valida para actualizar.", " Datos Imcompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }

                if (!mtxtTelefono.MaskCompleted)
                {
                    MessageBox.Show("Por favor, complete el número de teléfono.",
                                  "Teléfono Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mtxtTelefono.Focus();
                    return;
                }

                if (!ValidarTelefono(mtxtTelefono.Text))
                {
                    MessageBox.Show("El número de teléfono no es válido.",
                                  "Teléfono Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mtxtTelefono.Focus();
                    return;
                }

                DateTime fechaInicioActualizada = dateTimePickerInicio.Value.Date;
                DateTime fechaFinActualizada;
                string tipoMembresiaLower = cmbTipoMembresia.SelectedItem.ToString().ToLower(); // Convertir a minúsculas para comparar

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
                membresiaAEditar.Telefono = mtxtTelefono.Text.Trim();
                membresiaAEditar.FechaFin = fechaFinActualizada;

                _servicioMembresia.ActualizarMembresia(membresiaAEditar);
                MessageBox.Show("Membresia Actualizada exitosamente.", " Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                BtnConsultar_Click(sender, e);

            }
            catch (Exception ex)//captura de error
            {
                MessageBox.Show($" Error al Actualizar la membresia: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)//ELIMINAR MEMEBRESIAS QUE ESTAN CREADAS 
        {
            try//Captura de error
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecciona una membresia para Eliminar.", " Ninguna Seleccion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
                Membresia membresiaAEliminar = dataGridView1.SelectedRows[0].DataBoundItem as Membresia;
                if (membresiaAEliminar == null)
                {
                    MessageBox.Show(" No se pudo obtener la membresia seleccionada para eliminar.", "Error Interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult resultado = MessageBox.Show
                    ($"Estas seguro de que quieres eliminar  la membresia de {membresiaAEliminar.Nombre} (ID: {membresiaAEliminar.Id})",
                    " Confirmar Eliminacion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    _servicioMembresia.EliminarMembresia(membresiaAEliminar.Id);
                    MessageBox.Show("Membresia Eliminada exitosamente.", " Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    BtnConsultar_Click(sender, e);

                }
            }

            catch (Exception ex)//captura de error 
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
                    cmbTipoMembresia.SelectedItem = membresiaSeleccionada.TipoMembresia;
                    mtxtTelefono.Text = membresiaSeleccionada.Telefono;
                    dateTimePickerInicio.Value = membresiaSeleccionada.FechaInicio;
                }
            }
            else
            {
                LimpiarCampos();
            }

        }

        private void ConfigurarComboBoxTipoMembresia()//configuracion del combo box 
        {
            cmbTipoMembresia.Items.Clear();

            //hecho para que permita seleccionar una de las dos opciones y no escribir en el
            cmbTipoMembresia.Items.Add("Mensual");//opcion MENSUAL
            cmbTipoMembresia.Items.Add("Anual");//opcion Anual
            cmbTipoMembresia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoMembresia.SelectedIndex = -1;

        }

        //Poner modificaciones para el telefono
        private void ConfigurarMaskedTextBoxTelefono()
        {
            //esto es para obligar a completar con ese formato establecido 
            mtxtTelefono.Mask = "(000) 000-0000";
            mtxtTelefono.PromptChar = '_';
            mtxtTelefono.ResetOnPrompt = true;
            mtxtTelefono.ResetOnSpace = true;
            mtxtTelefono.SkipLiterals = true;

            mtxtTelefono.Text = "";

            mtxtTelefono.Leave += MtxtTelefono_Leave;
        }

        private void MtxtTelefono_Leave(object sender, EventArgs e)
        //cpatura de error para evitar que dejen campos vacios o incompletos 
        {
            MaskedTextBox mtxt = sender as MaskedTextBox;

            if (!mtxt.MaskCompleted && !string.IsNullOrWhiteSpace(mtxt.Text))
            {
                MessageBox.Show("Por favor, complete el número de teléfono correctamente.",
                               "Teléfono Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtxt.Focus();
            }
        }
        private bool ValidarTelefono(string telefono)
        {
            string telefonoLimpio = telefono.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");

            // Validar que tenga exactamente  los 10 digitos 
            if (telefonoLimpio.Length != 10)
            {
                return false;
            }

            // Validar que todos sean  numeros 
            if (!telefonoLimpio.All(char.IsDigit))
            {
                return false;
            }

            return true;
        }

        private void LimpiarCampos()// limpia los campos de las cjas de textos
        {
            txtNombreCliente.Clear();
            cmbTipoMembresia.SelectedIndex = -1;
            mtxtTelefono.Clear();
            dateTimePickerInicio.Value = DateTime.Now;

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTipoMembresia_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbTipoMembresia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefonoCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTelefono_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isNavigating)
            {
                _dashboard.Show();
            }
            instancia = null;
        }

        private void PicEntrenadores_Click(object sender, EventArgs e)
        {
            _isNavigating = true; // Avisamos que estamos navegando
            RegistroEntrenadores form2Entrenadores = new RegistroEntrenadores(_dashboard); // Le pasamos el dashboard
            form2Entrenadores.WindowState = this.WindowState;
            form2Entrenadores.Show(); //Navegacion entre formularios
            this.Close(); // Cerramos este formulario


        }
        private void PicRutinas_Click(object sender, EventArgs e)
        {
            _isNavigating = true; // Avisamos que estamos navegando
            RegistroRutina formRutinas = new RegistroRutina(_dashboard); // Le pasamos el dashboard
            formRutinas.WindowState = this.WindowState;
            formRutinas.Show();
            this.Hide(); // Cerramos este formulario
        }

        private void PicMemInicio_Click(object sender, EventArgs e)
        {
            _isNavigating = true; // Avisamos que estamos navegando
            _dashboard.Show();    // Mostramos el panel principal
            this.Close();         // Cerramos la ventana actual
        }

        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {

        }
    }

}
