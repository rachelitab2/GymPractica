using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq; //prueba 
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymNegocio.ClasesEntrenador;
using System.Net;
using System.Net.Mail;

namespace GymPresentacion
{
    public partial class RegistroEntrenadores : Form
    {
        private readonly Servicio_Entrenadores _servicioEntrenadores;
        private Entrenador _entrenadorSeleccionado;
        private readonly Form _formPrincipal;
        private bool _isNavigating = false;
        private readonly Form _dashboard;
        public RegistroEntrenadores(Form dashboard)
        {

            InitializeComponent();
            _dashboard = dashboard;
            _servicioEntrenadores = new Servicio_Entrenadores();
            AsignarEventos();

        }

        private void Form2Entrenadores_Load(object sender, EventArgs e)
        {
            ConfigurarComboBoxes();
            ConfigurarDataGridView();
            ConfigurarNumericUpDown();
            ConfigurarMaskedTextBoxTelefono();
            LimpiarCampos();
        }


        private void ConfigurarDataGridView()
        {
            dgvEntrenadores.AutoGenerateColumns = false;
            dgvEntrenadores.Columns.Clear();
            dgvEntrenadores.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", Name = "Id", Visible = false });
            dgvEntrenadores.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Genero", Name = "Genero", Visible = false });

            dgvEntrenadores.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre",
                Name = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvEntrenadores.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Area",
                HeaderText = "Area",
                Name = "Area",
                Width = 100
            });

            dgvEntrenadores.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Telefono",
                HeaderText = "Telefono",
                Name = "Telefono",
                Width = 100
            });

            dgvEntrenadores.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FechaIngreso",
                HeaderText = "Fecha Ingreso",
                Name = "FechaIngreso",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            dgvEntrenadores.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Duracion",
                HeaderText = "Duracion (Meses)",
                Name = "Duracion",
                Width = 80
            });

            dgvEntrenadores.Columns.Add(new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "Activo",
                HeaderText = "Activo",
                Name = "Activo",
                Width = 60
            });

            dgvEntrenadores.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Salario",
                HeaderText = "Salario",
                Name = "Salario",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            dgvEntrenadores.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SalarioTotal",
                HeaderText = "Salario Total",
                Name = "SalarioTotal",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            dgvEntrenadores.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EstadoContrato",
                HeaderText = "Estado",
                Name = "EstadoContrato",
                Width = 80
            });


        }

        private void ConfigurarComboBoxes()
        {
            if (cmbGeneroEntrenador.Items.Count == 0)
            {
                cmbGeneroEntrenador.Items.Add("Masculino");
                cmbGeneroEntrenador.Items.Add("Femenino");
                cmbGeneroEntrenador.Items.Add("Mixto");
                cmbGeneroEntrenador.DropDownStyle = ComboBoxStyle.DropDownList;
            }

            if (cmbAreaEntrenador.Items.Count == 0)
            {
                cmbAreaEntrenador.Items.Add("Cardio");
                cmbAreaEntrenador.Items.Add("Pesas");
                cmbAreaEntrenador.Items.Add("Pilates");
                cmbAreaEntrenador.Items.Add("Yoga");
                cmbAreaEntrenador.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }
        private void ConfigurarNumericUpDown()
        {
            nudDuracion.Minimum = 1;
            nudDuracion.Maximum = 36;
            nudDuracion.Value = 12;

        }

        private void AsignarEventos()
        {
            this.Load += Form2Entrenadores_Load;
            this.FormClosing += Form2Entrenadores_FormClosing;
            dgvEntrenadores.SelectionChanged += dvgEntrenadores_SelectionChanged;
            btnAgregarEntrenador.Click += btnAgregarEntrenador_Click;
            btnEditarEntrenador.Click += btnEditar_Click;
            btnEliminarEntrenador.Click += btnEliminar_Click;
            btnConsultar.Click += (s, e) => CargarEntrenadores();
            txtCorreoEntrenador.TextChanged += this.textBox1_TextChanged;
        }

        private void Form2Entrenadores_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isNavigating)
            {
                _dashboard.Show();
            }
        }

        private void CargarEntrenadores()
        {
            try
            {
                dgvEntrenadores.DataSource = null;
                dgvEntrenadores.DataSource = _servicioEntrenadores.ObtenerTodos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los entrenadores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dvgEntrenadores_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEntrenadores.SelectedRows.Count > 0)
            {
                _entrenadorSeleccionado = dgvEntrenadores.SelectedRows[0].DataBoundItem as Entrenador;

                if (_entrenadorSeleccionado != null)
                {
                    txtNombreEntrenador.Text = _entrenadorSeleccionado.Nombre;
                    maskedTextBox1.Text = _entrenadorSeleccionado.Telefono;
                    cmbGeneroEntrenador.SelectedItem = _entrenadorSeleccionado.Genero;
                    cmbAreaEntrenador.SelectedItem = _entrenadorSeleccionado.Area;
                    dtpIngresoEntrenador.Value = _entrenadorSeleccionado.FechaIngreso;
                    nudDuracion.Value = _entrenadorSeleccionado.Duracion;
                    checkDisponible.Checked = _entrenadorSeleccionado.Activo;
                    nudSalario.Value = _entrenadorSeleccionado.Salario;
                }

            }
            else
            {
                LimpiarCampos();
            }
        }


        //Boton Agregar 
        private void btnAgregarEntrenador_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombreEntrenador.Text) || cmbAreaEntrenador.SelectedItem == null)
                {
                    MessageBox.Show("El Nombre y el Área son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!maskedTextBox1.MaskCompleted)
                {
                    MessageBox.Show("Por favor, complete el número de teléfono.", "Teléfono Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    maskedTextBox1.Focus();
                    return;
                }

                if (!ValidarTelefono(maskedTextBox1.Text))
                {
                    MessageBox.Show("El número de teléfono no es válido. Debe tener 10 dígitos.", "Teléfono Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    maskedTextBox1.Focus();
                    return;
                }

                if (nudSalario.Value < 0)
                {
                    MessageBox.Show("El salario no puede ser negativo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (chkEnviarCorreo.Checked)
                {
                    if (string.IsNullOrWhiteSpace(txtCorreoEntrenador.Text))
                    {
                        MessageBox.Show("El correo es obligatorio si se desea enviar confirmación.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!txtCorreoEntrenador.Text.Contains("@") || !txtCorreoEntrenador.Text.Contains("."))
                    {
                        MessageBox.Show("El correo no tiene un formato válido.", "Correo Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                Entrenador nuevoAccesoEntrenador;
                string areaSeleccionada = cmbAreaEntrenador.SelectedItem.ToString();

                switch (areaSeleccionada)
                {
                    case "Pesas":
                        nuevoAccesoEntrenador = new EntrenadorPesas();
                        break;
                    case "Cardio":
                        nuevoAccesoEntrenador = new EntrenadorCardio();
                        break;
                    case "Pilates":
                        nuevoAccesoEntrenador = new EntrenadorPilates();
                        break;
                    case "Yoga":
                        nuevoAccesoEntrenador = new EntrenadorYoga();
                        break;
                    default:
                        MessageBox.Show("Por favor, seleccione un área válida.", "Área", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                }

                // Asignar datos
                nuevoAccesoEntrenador.Nombre = txtNombreEntrenador.Text.Trim();
                nuevoAccesoEntrenador.Telefono = maskedTextBox1.Text.Trim();
                nuevoAccesoEntrenador.Genero = cmbGeneroEntrenador.SelectedItem?.ToString();
                nuevoAccesoEntrenador.FechaIngreso = dtpIngresoEntrenador.Value;
                nuevoAccesoEntrenador.Duracion = (int)nudDuracion.Value;
                nuevoAccesoEntrenador.Activo = checkDisponible.Checked;
                nuevoAccesoEntrenador.Salario = nudSalario.Value;

                _servicioEntrenadores.RegistrarEntrenador(nuevoAccesoEntrenador);
                MessageBox.Show("Entrenador registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // ENVÍO DE CORREO (solo si checkbox está marcado)
                if (chkEnviarCorreo.Checked)
                {
                    try
                    {
                        string correoDestino = txtCorreoEntrenador.Text.Trim();
                        string nombre = nuevoAccesoEntrenador.Nombre;
                        string genero = nuevoAccesoEntrenador.Genero;
                        string telefono = nuevoAccesoEntrenador.Telefono;
                        DateTime ingreso = nuevoAccesoEntrenador.FechaIngreso;
                        string area = areaSeleccionada;
                        decimal salario = nuevoAccesoEntrenador.Salario;

                        MailMessage correo = new MailMessage();
                        correo.From = new MailAddress("tugimnasio@gmail.com", "PowerFit");
                        correo.To.Add(correoDestino);
                        correo.Subject = "Bienvenido a PowerFit - Confirmación de Registro";
                        correo.IsBodyHtml = true;

                        correo.Body = $@"
            <html>
            <head>
                <style>
                    body {{
                        font-family: 'Segoe UI', sans-serif;
                        background-color: #f5f5f5;
                        padding: 20px;
                        color: #333;
                    }}
                    .container {{
                        background-color: #ffffff;
                        padding: 25px;
                        border-radius: 10px;
                        box-shadow: 0 0 10px rgba(0,0,0,0.1);
                    }}
                    h2 {{
                        color: #0066cc;
                        text-align: center;
                    }}
                    table {{
                        width: 100%;
                        border-collapse: collapse;
                        margin-top: 20px;
                    }}
                    th, td {{
                        border: 1px solid #cccccc;
                        padding: 10px;
                        text-align: left;
                    }}
                    th {{
                        background-color: #e6f2ff;
                    }}
                    .footer {{
                        margin-top: 30px;
                        text-align: center;
                        color: #555;
                    }}
                </style>
            </head>
            <body>
                <div class='container'>
                    <h2>¡Bienvenido al equipo de PowerFit!</h2>
                    <p>Hola <strong>{nombre}</strong>, gracias por unirte como entrenador. Aquí están tus datos registrados:</p>

                    <table>
                        <tr><th>Nombre:</th><td>{nombre}</td></tr>
                        <tr><th>Género:</th><td>{genero}</td></tr>
                        <tr><th>Área:</th><td>{area}</td></tr>
                        <tr><th>Teléfono:</th><td>{telefono}</td></tr>
                        <tr><th>Fecha de Ingreso:</th><td>{ingreso:dd/MM/yyyy}</td></tr>
                        <tr><th>Salario:</th><td>{salario.ToString("C2", new System.Globalization.CultureInfo("es-DO"))}</td></tr>
                    </table>

                    <div class='footer'>
                        <p><i><b>PowerFit - Train Hard 💪</b></i></p>
                    </div>
                </div>
            </body>
            </html>";

                        SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                        smtp.Credentials = new NetworkCredential("gympowerfit98@gmail.com", "rlvcynhaatwfwzic"); // REEMPLAZAR
                        smtp.EnableSsl = true;

                        smtp.Send(correo);
                        MessageBox.Show("Correo enviado al entrenador.", "Correo Enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception exCorreo)
                    {
                        MessageBox.Show("Error al enviar el correo: " + exCorreo.Message, "Correo Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                CargarEntrenadores();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el entrenador: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        //Boton Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {

                if (_entrenadorSeleccionado == null)
                {
                    MessageBox.Show("Por favor, Seleccione un Entrenador para Editar.", " Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNombreEntrenador.Text) || cmbAreaEntrenador.SelectedItem == null)
                {
                    MessageBox.Show("El Nombre y el Area son Obligatorios.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!maskedTextBox1.MaskCompleted)
                {
                    MessageBox.Show("Por Favor, Complete el numero de telefono.", "Telefono Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    maskedTextBox1.Focus();
                    return;
                }

                if (!ValidarTelefono(maskedTextBox1.Text))
                {
                    MessageBox.Show("El numero de Telefono no es valido. Debe tener 10 digitos.", "Telefono Invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    maskedTextBox1.Focus();
                    return;
                }


                _entrenadorSeleccionado.Nombre = txtNombreEntrenador.Text;
                _entrenadorSeleccionado.Telefono = maskedTextBox1.Text;
                _entrenadorSeleccionado.Genero = cmbGeneroEntrenador.SelectedItem?.ToString();
                _entrenadorSeleccionado.FechaIngreso = dtpIngresoEntrenador.Value;
                _entrenadorSeleccionado.Duracion = (int)nudDuracion.Value;
                _entrenadorSeleccionado.Activo = checkDisponible.Checked;
                _entrenadorSeleccionado.Salario = nudSalario.Value;

                _servicioEntrenadores.ActualizarEntrenador(_entrenadorSeleccionado);

                MessageBox.Show("Entrenador actualizar  con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarEntrenadores();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al Actualizar el Entrenador: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ConfigurarMaskedTextBoxTelefono()
        {
            maskedTextBox1.Mask = "(000) 000-0000";
            maskedTextBox1.PromptChar = '_';
            maskedTextBox1.ResetOnPrompt = true;
            maskedTextBox1.ResetOnSpace = true;
            maskedTextBox1.SkipLiterals = true;
            maskedTextBox1.Leave += MtxtTelefono_Leave;
        }

        private void MtxtTelefono_Leave(object sender, EventArgs e)
        {
            MaskedTextBox mtxt = sender as MaskedTextBox;
            if (!mtxt.MaskCompleted && !string.IsNullOrWhiteSpace(mtxt.Text.Replace("(", "").Replace(")", "").Replace("-", "").Trim()))
            {
                MessageBox.Show("Por favor Complete el numero de Telefono Correctamente.", "Telefono Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtxt.Focus();
            }
        }
        private bool ValidarTelefono(string telefono)
        {
            string telefonoLimpio = telefono.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
            if (telefonoLimpio.Length != 10)
            {
                return false;
            }
            return telefonoLimpio.All(char.IsDigit);
        }
        //Boton Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_entrenadorSeleccionado == null)
            {
                MessageBox.Show("Por favor, Seleccione un Entrenador para Eliminar.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Pedir la confirmacion
            var confirmacion = MessageBox.Show($"¿Esta seguro que desea Eliminar a {_entrenadorSeleccionado.Nombre}?", "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    _servicioEntrenadores.EliminarEntrenador(_entrenadorSeleccionado.Id);
                    MessageBox.Show("Entrenador Eliminado exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarEntrenadores();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al Eliminar el Entrenador: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CargarEntrenadores();
            MessageBox.Show("Lista de Entrenadores Actualizada.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PicMem2_Click(object sender, EventArgs e)
        {
            _isNavigating = true;
            RegistroMembresias formMembresias = new RegistroMembresias(_dashboard);
            formMembresias.WindowState = this.WindowState;
            formMembresias.Show(); //Navegacion entre formularios 
            this.Close();
        }

        private void PicRutinaEntrenador_Click(object sender, EventArgs e)
        {
            _isNavigating = true;
            RegistroRutina formRutina = new RegistroRutina(_dashboard);
            formRutina.WindowState = this.WindowState;
            formRutina.Show();
            this.Close();
        }

        private void PicEntrenadorInicio_Click(object sender, EventArgs e)
        {
            _isNavigating = true;
            _dashboard.Show();
            this.Close();
        }

        private void LimpiarCampos()
        {
            txtNombreEntrenador.Clear();
            maskedTextBox1.Clear();
            cmbGeneroEntrenador.SelectedIndex = -1;
            cmbAreaEntrenador.SelectedIndex = -1;
            dtpIngresoEntrenador.Value = DateTime.Now;
            nudDuracion.Value = 12;
            checkDisponible.Checked = true;
            _entrenadorSeleccionado = null;
            nudSalario.Value = 0;

            if (dgvEntrenadores.SelectedRows.Count > 0)
            {
                dgvEntrenadores.ClearSelection();
            }
        }
        private void lblGeneroEntrendor_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void checkDisponible_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgvEntrenadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtNombreEntrenador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnAgregarEntrenador_Click_1(object sender, EventArgs e)
        {

        }
    }
}
