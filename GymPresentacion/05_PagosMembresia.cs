using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using GymNegocio.ClasesMembresia;
using GymNegocio.Login;
using System.Timers;
using GymDatos;

namespace GymPresentacion
{
    public partial class PagosMembresia : Form
    {
        private static PagosMembresia _instancia;
        private UsuariosActivos _usuariosActivos;
        private Servicio_Membresia _serviciosMembresia;
        private Servicio_PagoMembresia _servicioPagoMembresia;
        private List<Membresia> _listaMembresias;
        private List<PagoMembresia> _listaPago;
        private bool _isNavigating = false;
        private bool _isChangingSelection = false;

        public PagosMembresia(UsuariosActivos usuariosActivos)
        {
            InitializeComponent();
            _usuariosActivos = usuariosActivos;
            _serviciosMembresia = new Servicio_Membresia(new MemGymnasio());
            _servicioPagoMembresia = new Servicio_PagoMembresia();
          

            ConfigurarDataGridView();
            CargarMembresias();
            AsignarEventos();
            

            this.FormClosing += PagosMembresia_FormClosing;
        }
        public static PagosMembresia ObtenerInstancia(UsuariosActivos usuarios)
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new PagosMembresia(usuarios);
            }
            return _instancia;

        }

        private void PagosMembresia_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isNavigating)
            {
                Application.Exit();
            }
        }

        private void ConfigurarDataGridView()
        {
            dgvPagoMembresia.AutoGenerateColumns = false;
            dgvPagoMembresia.Columns.Clear();

            dgvPagoMembresia.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "ID",
                Width = 50,
                Visible = false
            });

            dgvPagoMembresia.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre",
                Width = 150,

            });


            dgvPagoMembresia.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FechaPago",
                HeaderText = "Fecha de Pago",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" },
                Width = 120
            });

            dgvPagoMembresia.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Monto",
                HeaderText = "Monto",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            dgvPagoMembresia.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MetodoPago",
                HeaderText = "Método de Pago",
                Width = 150
            });


        }


        private async void CargarMembresias()
        {
            try
            {
                _listaMembresias = await _serviciosMembresia.ObtenerTodasLasMembresiasAsync();
           

                cmbClientePago.DataSource = null;
                cmbClientePago.DataSource = _listaMembresias;
                cmbClientePago.DisplayMember = "Nombre";
                cmbClientePago.ValueMember = "Id";

                cmbMetodoPago.Items.AddRange(new object[] { "Efectivo", "Transacción", "Tarjeta" });
                cmbMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbMetodoPago.SelectedIndex = 0;

                cmbTipoClientePago.Items.Clear();
                cmbTipoClientePago.Items.AddRange(new object[] { "Mensual", "Anual" });
                cmbTipoClientePago.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbTipoClientePago.SelectedIndex = 0;

                // El DataGridView mostrará solo los pagos

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Cargar Membresias: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void CargarPagos(int membresiaId)
        {
            try
            {
                _listaPago = _servicioPagoMembresia.ObtenerPagosPorMembresia(membresiaId);
                dgvPagoMembresia.DataSource = null;
                dgvPagoMembresia.DataSource = _listaPago;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pagos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AsignarEventos()
        {
            dgvPagoMembresia.SelectionChanged += DgvPagoMemebresias_SelectionChanged;
            cmbClientePago.SelectedIndexChanged += ClientePago_SelectedIndexChanged;
            cmbTipoClientePago.SelectedIndexChanged += TipoMembresia_SelectedIndexChanged;
            btnPago.Click += BtnPago_Click;
            //PicPagoRegistroMembresia.Click += PicPagoRegistroMembresia_Click;
            PicPagoInicio.Click += PicPagoInicio_Click;
            ConsultaPago.Click += Consulta_Click;
            EliminarPago.Click += EliminarPago_Click;
            EditarPago.Click += EditarPago_Click;
            GuardarPago.Click += GuardarDoc_Click;
        }

        private void DgvPagoMemebresias_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPagoMembresia.SelectedRows.Count > 0)
            {
                var pago = dgvPagoMembresia.SelectedRows[0].DataBoundItem as PagoMembresia;
                if(pago != null)
                {
                    txtFechaVencimientoPago.Text = pago.FechaPago.ToShortDateString();
                    cmbMetodoPago.SelectedItem = pago.MetodoPago;
                    txtMonto.Text = pago.Monto.ToString("F2");
                

                    _isChangingSelection = false;
                }
            }
        }
        private void ClientePago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isChangingSelection) return;
            if (cmbClientePago.SelectedItem is Membresia membresia)
            {
                _isChangingSelection = true;

                txtFechaVencimientoPago.Text = membresia.FechaFin.ToShortDateString();
                cmbTipoClientePago.SelectedItem = membresia.TipoMembresia;
                txtMonto.Text = membresia.CostoTotal.ToString("F2");

                CargarPagos(membresia.Id);

                this.BeginInvoke(new Action(() =>
                {
                    _isChangingSelection = false;
                }));
            }

        }

        private void TipoMembresia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoClientePago.SelectedItem != null)
            {
                string tipo = cmbTipoClientePago.SelectedItem.ToString();
                if (tipo == "Mensual")
                    txtMonto.Text = "1200";
                else if (tipo == "Anual")
                    txtMonto.Text = "14400";
                else
                    txtMonto.Text = "0";
            }
        }
        private void Consulta_Click(object sender, EventArgs e)
        {
            if (cmbClientePago.SelectedItem is Membresia membresia)
            {
                try
                {
                    _listaPago = _servicioPagoMembresia.ObtenerTodosLosPagos(); // Necesitarás crear este método en tu servicio
                    dgvPagoMembresia.DataSource = null;
                    dgvPagoMembresia.DataSource = _listaPago;

                    MessageBox.Show("Todos los pagos cargados Correctamente.", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar todos los pagos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una membresía válida.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EliminarPago_Click(object sender, EventArgs e)
        {
            if(dgvPagoMembresia.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un pago para eliminar.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var pago = dgvPagoMembresia.SelectedRows[0].DataBoundItem as PagoMembresia;
            if (pago == null)
            {
                MessageBox.Show("Pago invalido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                _servicioPagoMembresia.EliminarPago(pago.Id);
                MessageBox.Show("Pago Eliminado Correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(cmbClientePago.SelectedItem is Membresia membresia)
                {
                    CargarPagos(membresia.Id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Eliminar pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void EditarPago_Click (object sender, EventArgs e)
        {
            if (dgvPagoMembresia.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selccione un Pago para Editar.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            var pago = dgvPagoMembresia.SelectedRows[0].DataBoundItem as PagoMembresia;
            if(pago == null)
            {
                MessageBox.Show("Pago Invalido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                pago.FechaPago = DateTime.Now;
                if(decimal.TryParse(txtMonto.Text, out decimal monto))
                {
                    pago.Monto = monto;
                }
                else
                {
                    MessageBox.Show("Monto invalido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                pago.MetodoPago = cmbMetodoPago.SelectedItem?.ToString() ?? "Efectivo";

                _servicioPagoMembresia.ActualizarPago(pago);
                MessageBox.Show("Pago Actualizado Correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(cmbClientePago.SelectedItem is Membresia membresia)
                {
                    CargarPagos(membresia.Id);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Actualizar Pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void GuardarDoc_Click(object sender, EventArgs e)
        {
            if (dgvPagoMembresia.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un pago para guardar el Documento.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var pago = dgvPagoMembresia.SelectedRows[0].DataBoundItem as PagoMembresia;
            if (pago == null)
            {
                MessageBox.Show("Pago Invalido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                GenerarReciboPDF(pago);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al Gaurdar el Documento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnPago_Click(object sender, EventArgs e)
        {
            if (cmbClientePago.SelectedItem is not Membresia membresia)
            {
                MessageBox.Show("Seleccione una membresias para registrar el pago.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DateTime fechapago = DateTime.Now;
                string tipoMembresia = membresia.TipoMembresia;
                string metodoPago = cmbMetodoPago.SelectedItem?.ToString() ?? "Efectivo";

                if(metodoPago == "Transaccion" || metodoPago == "Tarjeta")
                {
                    string mensaje = metodoPago == "Transaccion"
                        ? "¿Ha verificado que la transaccion bancaria se completo correctsamente?"
                        : "¿Ha verificado que el pago con tarjeta se proceso exitosamente?";

                    DialogResult resultado = MessageBox.Show(mensaje, "Validacion de " + metodoPago, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if(resultado == DialogResult.No)
                    {
                        MessageBox.Show("Complete la validacion del pago antes de continuar.", "Validacion Requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                if (tipoMembresia == "Mensual")
                {
                    membresia.FechaFin = membresia.FechaFin > fechapago ? membresia.FechaFin.AddMonths(1) : fechapago.AddMonths(1);

                }
                else if (tipoMembresia == "Anual")
                {
                    membresia.FechaFin = membresia.FechaFin > fechapago ? membresia.FechaFin.AddYears(1) : fechapago.AddYears(1);
                }

                membresia.FechaInicio = fechapago;
                membresia.CalcularCostoTotal();
                membresia.Activa = true;

                _serviciosMembresia.ActualizarMembresiaAsync(membresia);

                PagoMembresia pago = new PagoMembresia(membresia.Id, membresia.CostoTotal, metodoPago);
                _servicioPagoMembresia.RegistrarPago(pago);

                MessageBox.Show("Pago resgistrdo y Fecha de vencimiento Actualizada.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtFechaVencimientoPago.Text = membresia.FechaFin.ToShortDateString();
                txtMonto.Text = membresia.CostoTotal.ToString("F2");

                GenerarReciboPDF(pago);
                CargarPagos(membresia.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Registrar pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void GenerarReciboPDF(PagoMembresia pago)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    string nombreCliente = "";
                    if (cmbClientePago.SelectedItem is Membresia membresia)
                        nombreCliente = membresia.Nombre;
                    foreach (char c in Path.GetInvalidFileNameChars())
                        nombreCliente = nombreCliente.Replace(c, '_');


                    string fechaActual = DateTime.Now.ToString("yyyyMMddHHmmss");
                    saveFileDialog.Filter = "Archivo PDF (*.pdf)|*.pdf";
                    saveFileDialog.FileName = $"ReciboPago_{nombreCliente}_{pago.Id}_{fechaActual}.PDF";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string fileName = saveFileDialog.FileName;
                        Document doc = new Document(PageSize.A4, 40, 40, 40, 40 );
                        PdfWriter.GetInstance(doc, new FileStream(fileName, FileMode.Create));
                        doc.Open();

                        string logoPath = @"C:\Users\madeg\Source\Repos\GymPractica21\GymPresentacion\Resources\image-removebg-preview (4).png"; // Cambia esta ruta
                        if (File.Exists(logoPath))
                        {
                            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logoPath);
                            logo.ScaleToFit(120f, 120f);
                            logo.Alignment = Element.ALIGN_LEFT;
                            doc.Add(logo);
                        }

                        // Espacio
                        doc.Add(new Paragraph("\n"));

                        var tituloFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 22);
                        var headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.WHITE);
                        var cellFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);
                        var mensajeFont = FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 10);

                        //TITULO 
                        Paragraph titulo = new Paragraph("Recibo de pago de Membresia", tituloFont);
                        titulo.Alignment = Element.ALIGN_CENTER;
                        doc.Add(titulo);
                        doc.Add(new Paragraph("\n"));

                        // Tabla
                        PdfPTable tabla = new PdfPTable(2);
                        tabla.WidthPercentage = 80;
                        tabla.HorizontalAlignment = Element.ALIGN_CENTER;

                        // Cabecera
                        PdfPCell celdaCampo = new PdfPCell(new Phrase("Campo", headerFont));
                        celdaCampo.BackgroundColor = new BaseColor(0, 123, 194);
                        celdaCampo.HorizontalAlignment = Element.ALIGN_CENTER;
                        tabla.AddCell(celdaCampo);


                        PdfPCell celdaDetalle = new PdfPCell(new Phrase("Detalle", headerFont));
                        celdaDetalle.BackgroundColor = new BaseColor(0, 123, 194);
                        celdaDetalle.HorizontalAlignment = Element.ALIGN_CENTER;
                        tabla.AddCell(celdaDetalle);


                        // FILAS DE DATOS
                        tabla.AddCell(new Phrase("ID Pago", cellFont));
                        tabla.AddCell(new Phrase(pago.Id.ToString(), cellFont));
                        tabla.AddCell(new Phrase("Fecha de Pago", cellFont));
                        tabla.AddCell(new Phrase(pago.FechaPago.ToShortDateString(), cellFont));
                        tabla.AddCell(new Phrase("Monto", cellFont));
                        tabla.AddCell(new Phrase(pago.Monto.ToString("C"), cellFont));
                        tabla.AddCell(new Phrase("Método de Pago", cellFont));
                        tabla.AddCell(new Phrase(pago.MetodoPago, cellFont));


                        doc.Add(tabla);

                        // MENSAJE FINAL
                        doc.Add(new Paragraph("\nPor favor, realice el pago antes de la fecha de vencimiento para evitar la suspensión de la membresía.", mensajeFont));

                        doc.Close();

                        MessageBox.Show($"Recibo guardado en: {fileName}", "Recibo PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Guardar recibo PDF:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       public void LimpiarCampos()// limpia los campos de las cjas de textos
       {
            cmbClientePago.SelectedIndex = -1;
            cmbMetodoPago.SelectedIndex = 0;
            cmbTipoClientePago.SelectedIndex = 0;
            txtFechaVencimientoPago.Clear();
            txtMonto.Clear();
            dgvPagoMembresia.ClearSelection();


            

       }
        private void PicPagoInicio_Click(object sender, EventArgs e)
        {
            _isNavigating = true;
            btnDespliegue panelPrincipal = new btnDespliegue(_usuariosActivos);
            panelPrincipal.StartPosition = FormStartPosition.CenterScreen;
            panelPrincipal.Show();
            this.Close();
        }

        private void PicPagoRegistroMembresia_Click(object sender, EventArgs e)
        {
            _isNavigating = true;
            RegistroMembresias registroMembresias = new RegistroMembresias(_usuariosActivos);
            registroMembresias.Show();
            this.Close();
        }
        private void PagosMembresia_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
