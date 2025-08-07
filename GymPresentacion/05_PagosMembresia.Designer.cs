namespace GymPresentacion
{
    partial class PagosMembresia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            PicPagoInicio = new PictureBox();
            dtpPago = new DateTimePicker();
            PicPagoRegistroMembresia = new PictureBox();
            dgvPagoMembresia = new DataGridView();
            cmbClientePago = new ComboBox();
            cmbTipoClientePago = new ComboBox();
            txtFechaVencimientoPago = new TextBox();
            btnPago = new Button();
            txtMonto = new TextBox();
            EliminarPago = new Button();
            EditarPago = new Button();
            GuardarPago = new Button();
            ConsultaPago = new Button();
            cmbMetodoPago = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicPagoInicio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicPagoRegistroMembresia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPagoMembresia).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.image_removebg_preview__4_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(637, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(589, 162);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // PicPagoInicio
            // 
            PicPagoInicio.BackColor = Color.Transparent;
            PicPagoInicio.BackgroundImage = Properties.Resources.image_removebg_preview__7_;
            PicPagoInicio.BackgroundImageLayout = ImageLayout.Zoom;
            PicPagoInicio.Cursor = Cursors.Hand;
            PicPagoInicio.Location = new Point(127, 166);
            PicPagoInicio.Name = "PicPagoInicio";
            PicPagoInicio.Size = new Size(125, 62);
            PicPagoInicio.TabIndex = 1;
            PicPagoInicio.TabStop = false;
            PicPagoInicio.Click += PicPagoInicio_Click;
            // 
            // dtpPago
            // 
            dtpPago.CalendarFont = new Font("Verdana", 10.2F, FontStyle.Bold);
            dtpPago.CalendarMonthBackground = Color.Lavender;
            dtpPago.CalendarTitleBackColor = Color.DodgerBlue;
            dtpPago.Location = new Point(997, 441);
            dtpPago.Name = "dtpPago";
            dtpPago.Size = new Size(371, 27);
            dtpPago.TabIndex = 2;
            // 
            // PicPagoRegistroMembresia
            // 
            PicPagoRegistroMembresia.BackColor = Color.Transparent;
            PicPagoRegistroMembresia.BackgroundImage = Properties.Resources.image_removebg_preview__3_;
            PicPagoRegistroMembresia.BackgroundImageLayout = ImageLayout.Zoom;
            PicPagoRegistroMembresia.Cursor = Cursors.Hand;
            PicPagoRegistroMembresia.Location = new Point(284, 166);
            PicPagoRegistroMembresia.Name = "PicPagoRegistroMembresia";
            PicPagoRegistroMembresia.Size = new Size(125, 62);
            PicPagoRegistroMembresia.TabIndex = 3;
            PicPagoRegistroMembresia.TabStop = false;
            PicPagoRegistroMembresia.Click += PicPagoRegistroMembresia_Click;
            // 
            // dgvPagoMembresia
            // 
            dgvPagoMembresia.AllowUserToAddRows = false;
            dgvPagoMembresia.AllowUserToDeleteRows = false;
            dgvPagoMembresia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPagoMembresia.BackgroundColor = Color.Lavender;
            dgvPagoMembresia.BorderStyle = BorderStyle.None;
            dgvPagoMembresia.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvPagoMembresia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPagoMembresia.Cursor = Cursors.Hand;
            dgvPagoMembresia.EnableHeadersVisualStyles = false;
            dgvPagoMembresia.GridColor = Color.DodgerBlue;
            dgvPagoMembresia.Location = new Point(127, 234);
            dgvPagoMembresia.MultiSelect = false;
            dgvPagoMembresia.Name = "dgvPagoMembresia";
            dgvPagoMembresia.ReadOnly = true;
            dgvPagoMembresia.RowHeadersVisible = false;
            dgvPagoMembresia.RowHeadersWidth = 51;
            dgvPagoMembresia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPagoMembresia.Size = new Size(734, 382);
            dgvPagoMembresia.TabIndex = 4;
            // 
            // cmbClientePago
            // 
            cmbClientePago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClientePago.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            cmbClientePago.FormattingEnabled = true;
            cmbClientePago.Location = new Point(997, 285);
            cmbClientePago.Name = "cmbClientePago";
            cmbClientePago.Size = new Size(371, 28);
            cmbClientePago.TabIndex = 5;
            // 
            // cmbTipoClientePago
            // 
            cmbTipoClientePago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoClientePago.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            cmbTipoClientePago.FormattingEnabled = true;
            cmbTipoClientePago.Location = new Point(997, 387);
            cmbTipoClientePago.Name = "cmbTipoClientePago";
            cmbTipoClientePago.Size = new Size(371, 28);
            cmbTipoClientePago.TabIndex = 6;
            // 
            // txtFechaVencimientoPago
            // 
            txtFechaVencimientoPago.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            txtFechaVencimientoPago.ForeColor = Color.Black;
            txtFechaVencimientoPago.Location = new Point(997, 336);
            txtFechaVencimientoPago.Name = "txtFechaVencimientoPago";
            txtFechaVencimientoPago.ReadOnly = true;
            txtFechaVencimientoPago.Size = new Size(371, 28);
            txtFechaVencimientoPago.TabIndex = 7;
            // 
            // btnPago
            // 
            btnPago.BackColor = Color.DodgerBlue;
            btnPago.Cursor = Cursors.Hand;
            btnPago.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold);
            btnPago.Location = new Point(1118, 631);
            btnPago.Name = "btnPago";
            btnPago.Size = new Size(155, 52);
            btnPago.TabIndex = 8;
            btnPago.Text = "Pago";
            btnPago.UseVisualStyleBackColor = false;
            // 
            // txtMonto
            // 
            txtMonto.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            txtMonto.Location = new Point(997, 498);
            txtMonto.Name = "txtMonto";
            txtMonto.ReadOnly = true;
            txtMonto.Size = new Size(371, 28);
            txtMonto.TabIndex = 9;
            // 
            // EliminarPago
            // 
            EliminarPago.BackColor = Color.DodgerBlue;
            EliminarPago.Cursor = Cursors.Hand;
            EliminarPago.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold);
            EliminarPago.Location = new Point(370, 631);
            EliminarPago.Name = "EliminarPago";
            EliminarPago.Size = new Size(153, 55);
            EliminarPago.TabIndex = 10;
            EliminarPago.Text = "🗑️ Eliminar";
            EliminarPago.UseVisualStyleBackColor = false;
            // 
            // EditarPago
            // 
            EditarPago.BackColor = Color.DodgerBlue;
            EditarPago.Cursor = Cursors.Hand;
            EditarPago.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold);
            EditarPago.Location = new Point(529, 631);
            EditarPago.Name = "EditarPago";
            EditarPago.Size = new Size(162, 55);
            EditarPago.TabIndex = 11;
            EditarPago.Text = "✏️ Editar";
            EditarPago.UseVisualStyleBackColor = false;
            // 
            // GuardarPago
            // 
            GuardarPago.BackColor = Color.DodgerBlue;
            GuardarPago.Cursor = Cursors.Hand;
            GuardarPago.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold);
            GuardarPago.Location = new Point(697, 631);
            GuardarPago.Name = "GuardarPago";
            GuardarPago.Size = new Size(164, 55);
            GuardarPago.TabIndex = 12;
            GuardarPago.Text = "Guardar Doc ";
            GuardarPago.UseVisualStyleBackColor = false;
            // 
            // ConsultaPago
            // 
            ConsultaPago.BackColor = Color.DodgerBlue;
            ConsultaPago.Cursor = Cursors.Hand;
            ConsultaPago.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold);
            ConsultaPago.Location = new Point(194, 631);
            ConsultaPago.Name = "ConsultaPago";
            ConsultaPago.Size = new Size(170, 55);
            ConsultaPago.TabIndex = 13;
            ConsultaPago.Text = "🔍 Consultar";
            ConsultaPago.UseVisualStyleBackColor = false;
            // 
            // cmbMetodoPago
            // 
            cmbMetodoPago.Cursor = Cursors.Hand;
            cmbMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMetodoPago.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            cmbMetodoPago.FormattingEnabled = true;
            cmbMetodoPago.Location = new Point(997, 550);
            cmbMetodoPago.Name = "cmbMetodoPago";
            cmbMetodoPago.Size = new Size(367, 28);
            cmbMetodoPago.TabIndex = 14;
            // 
            // PagosMembresia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 27, 27);
            ClientSize = new Size(1420, 763);
            Controls.Add(cmbMetodoPago);
            Controls.Add(ConsultaPago);
            Controls.Add(GuardarPago);
            Controls.Add(EditarPago);
            Controls.Add(EliminarPago);
            Controls.Add(pictureBox1);
            Controls.Add(txtMonto);
            Controls.Add(btnPago);
            Controls.Add(txtFechaVencimientoPago);
            Controls.Add(cmbTipoClientePago);
            Controls.Add(cmbClientePago);
            Controls.Add(dgvPagoMembresia);
            Controls.Add(PicPagoRegistroMembresia);
            Controls.Add(dtpPago);
            Controls.Add(PicPagoInicio);
            Name = "PagosMembresia";
            Text = "PagosMembresia";
            Load += PagosMembresia_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicPagoInicio).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicPagoRegistroMembresia).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPagoMembresia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox PicPagoInicio;
        private DateTimePicker dtpPago;
        private PictureBox PicPagoRegistroMembresia;
        private DataGridView dgvPagoMembresia;
        private ComboBox cmbClientePago;
        private ComboBox cmbTipoClientePago;
        private TextBox txtFechaVencimientoPago;
        private Button btnPago;
        private TextBox txtMonto;
        private Button EliminarPago;
        private Button EditarPago;
        private Button GuardarPago;
        private Button ConsultaPago;
        private ComboBox cmbMetodoPago;
    }
}