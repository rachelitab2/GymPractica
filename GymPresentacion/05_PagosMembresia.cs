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

namespace GymPresentacion
{
    public partial class PagosMembresia : Form
    {
        private static PagosMembresia _instancia;
        private UsuariosActivos _usuariosActivos;
        private Servicio_Membresia _serviciosMembresia;
        private List<Membresia> _listaMembresias;
        private bool _isNavigating = false;
        private bool _isChangingSelection = false;

        public PagosMembresia(UsuariosActivos usuariosActivos)
        {
            InitializeComponent();
            _usuariosActivos = usuariosActivos;
            _serviciosMembresia = new Servicio_Membresia();

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
        private void PagosMembresia_FormClosing(object sender , FormClosingEventArgs e)
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
                Width = 150
            });

            dgvPagoMembresia.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TipoMembresia",
                HeaderText = "Tipo",
                Width = 80
            });

            dgvPagoMembresia.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FechaInicio",
                HeaderText = "Inicio",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            dgvPagoMembresia.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FechaFin",
                HeaderText = "Vencimiento",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            dgvPagoMembresia.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CostoTotal",
                HeaderText = "Costo",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            dgvPagoMembresia.Columns.Add(new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "Activa",
                HeaderText = "Activa",
                Width = 60
            });


        }


        private void CargarMembresias()
        {
            try
            {
                _listaMembresias = _serviciosMembresia.ObtenerTodasLasMembresias();
                dgvPagoMembresia.DataSource = null;
                dgvPagoMembresia.DataSource = _listaMembresias;

                cmbClientePago.DataSource = null;
                cmbClientePago.DataSource = _listaMembresias;
                cmbClientePago.DisplayMember = "Nombre";
                cmbClientePago.ValueMember = "Id";

                cmbTipoClientePago.Items.Clear();
                cmbTipoClientePago.Items.AddRange(new object[] { "Mensual", "Anual" });
                cmbTipoClientePago.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbTipoClientePago.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Cargar Mmembresias: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void AsignarEventos()
        {
            dgvPagoMembresia.SelectionChanged += DgvPagoMemebresias_SelectionChanged;
            cmbClientePago.SelectedIndexChanged += ClientePago_SelectedIndexChanged;
            cmbTipoClientePago.SelectedIndexChanged += TipoMembresia_SelectedIndexChanged;
            btnPago.Click += BtnPago_Click;
            PicPagoRegistroMembresia.Click += PicPagoRegistroMembresia_Click;
            PicPagoInicio.Click += PicPagoInicio_Click;
        }

        private void DgvPagoMemebresias_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPagoMembresia.SelectedRows.Count > 0)
            {
                var membresia = dgvPagoMembresia.SelectedRows[0].DataBoundItem as Membresia;
                if(membresia != null)
                {
                    txtFechaVencimientoPago.Text = membresia.FechaFin.ToShortDateString();
                    cmbClientePago.SelectedItem = membresia.TipoMembresia;
                    cmbTipoClientePago.SelectedItem = membresia.TipoMembresia;
                    txtMonto.Text = membresia.CostoTotal.ToString("F2");

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

                 this.BeginInvoke(new Action(() =>
                 {
                     foreach (DataGridViewRow row in dgvPagoMembresia.Rows)
                     {
                         if (row.DataBoundItem is Membresia m && m.Id == membresia.Id)
                         {
                             dgvPagoMembresia.ClearSelection();
                             row.Selected = true;
                             if (row.Cells.Count > 0)
                             {
                                 dgvPagoMembresia.CurrentCell = row.Cells[0];
                             }
                             break;
                         }
                     }
                     _isChangingSelection = false;
                 }));
            }

        }

        private void TipoMembresia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbTipoClientePago.SelectedItem != null)
            {
                string tipo = cmbTipoClientePago.SelectedItem.ToString();
                if (tipo == "Mensua")
                    txtMonto.Text = "1200";
                else if (tipo == "Anual")
                    txtMonto.Text = "14400";
                else
                    txtMonto.Text = "0";
            }
        }

        private void BtnPago_Click (object sender, EventArgs e)
        {
           if (dgvPagoMembresia.SelectedRows.Count == 0)
           {
                MessageBox.Show("Seleccione una membresias para registrar el pago.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
           }

            var membresia = dgvPagoMembresia.SelectedRows[0].DataBoundItem as Membresia;
            if(membresia == null)
            {
                MessageBox.Show("Memebreias invalida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                DateTime fechapago = DateTime.Now;
                string tipoMembresia = membresia.TipoMembresia;

                if(tipoMembresia == "Mensual")
                {
                    membresia.FechaFin = membresia.FechaFin > fechapago ? membresia.FechaFin.AddMonths(1) : fechapago.AddMonths(1);

                }
                else if(tipoMembresia == "Anual")
                {
                    membresia.FechaFin = membresia.FechaFin > fechapago ? fechapago = membresia.FechaFin.AddYears(1) : fechapago.AddYears(1);
                }

                membresia.FechaInicio = fechapago;
                membresia.CalcularCostoTotal();
                membresia.Activa = true;

                _serviciosMembresia.ActualizarMembresia(membresia);

                MessageBox.Show("Pago resgistrdo y Fecha de vencimiento Actualizada.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtFechaVencimientoPago.Text = membresia.FechaFin.ToShortDateString();
                txtMonto.Text = membresia.CostoTotal.ToString("F2");

                GenerarReciboPDF(membresia);
                CargarMembresias();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Registrar pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void GenerarReciboPDF(Membresia membresia)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Archivo PDF (*.pdf)|*.pdf";
                    saveFileDialog.FileName = $"ReciboPago_{membresia.Nombre}_{DateTime.Now:yyyyMMddHHmmss}.PDF";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string fileName = saveFileDialog.FileName;
                        Document doc = new Document();
                        PdfWriter.GetInstance(doc, new FileStream(fileName, FileMode.Create));
                        doc.Open();

                        doc.Add(new Paragraph("Recibo de Pago de Membresía"));
                        doc.Add(new Paragraph($"Nombre: {membresia.Nombre}"));
                        doc.Add(new Paragraph($"Tipo de Membresia: {membresia.TipoMembresia}"));
                        doc.Add(new Paragraph($"Fecha de Inicio: {membresia.FechaInicio.ToShortDateString()}"));
                        doc.Add(new Paragraph($"Fecha de Vencimiento: {membresia.FechaFin.ToShortDateString()}"));
                        doc.Add(new Paragraph($"Monto Pagado: {membresia.CostoTotal:C}"));
                        doc.Add(new Paragraph($"Fecha de Pago: {DateTime.Now.ToShortDateString()}"));

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

        private void PicPagoInicio_Click(object sender, EventArgs e)
        {
            _isNavigating = true;
            btnDespliegue panelPrincipal = new btnDespliegue(_usuariosActivos);
            panelPrincipal.Show();
            this.Close();
        }

        private void PicPagoRegistroMembresia_Click(object sender, EventArgs e)
        {
            _isNavigating= true;
            RegistroMembresias registroMembresias = new RegistroMembresias(_usuariosActivos);
            registroMembresias.Show();
            this.Close();
        }
        private void PagosMembresia_Load(object sender, EventArgs e)
        {

        }

        
    }
}
