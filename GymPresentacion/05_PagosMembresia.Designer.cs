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
            PicPagoInicio.Location = new Point(127, 166);
            PicPagoInicio.Name = "PicPagoInicio";
            PicPagoInicio.Size = new Size(125, 62);
            PicPagoInicio.TabIndex = 1;
            PicPagoInicio.TabStop = false;
            PicPagoInicio.Click += PicPagoInicio_Click;
            // 
            // dtpPago
            // 
            dtpPago.Location = new Point(1118, 491);
            dtpPago.Name = "dtpPago";
            dtpPago.Size = new Size(250, 27);
            dtpPago.TabIndex = 2;
            // 
            // PicPagoRegistroMembresia
            // 
            PicPagoRegistroMembresia.BackColor = Color.Transparent;
            PicPagoRegistroMembresia.BackgroundImage = Properties.Resources.image_removebg_preview__3_;
            PicPagoRegistroMembresia.BackgroundImageLayout = ImageLayout.Zoom;
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
            dgvPagoMembresia.BackgroundColor = Color.Black;
            dgvPagoMembresia.BorderStyle = BorderStyle.None;
            dgvPagoMembresia.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvPagoMembresia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPagoMembresia.EnableHeadersVisualStyles = false;
            dgvPagoMembresia.GridColor = Color.DodgerBlue;
            dgvPagoMembresia.Location = new Point(127, 258);
            dgvPagoMembresia.MultiSelect = false;
            dgvPagoMembresia.Name = "dgvPagoMembresia";
            dgvPagoMembresia.ReadOnly = true;
            dgvPagoMembresia.RowHeadersVisible = false;
            dgvPagoMembresia.RowHeadersWidth = 51;
            dgvPagoMembresia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPagoMembresia.Size = new Size(726, 448);
            dgvPagoMembresia.TabIndex = 4;
            // 
            // cmbClientePago
            // 
            cmbClientePago.FormattingEnabled = true;
            cmbClientePago.Location = new Point(1118, 311);
            cmbClientePago.Name = "cmbClientePago";
            cmbClientePago.Size = new Size(250, 28);
            cmbClientePago.TabIndex = 5;
            // 
            // cmbTipoClientePago
            // 
            cmbTipoClientePago.FormattingEnabled = true;
            cmbTipoClientePago.Location = new Point(1118, 427);
            cmbTipoClientePago.Name = "cmbTipoClientePago";
            cmbTipoClientePago.Size = new Size(250, 28);
            cmbTipoClientePago.TabIndex = 6;
            // 
            // txtFechaVencimientoPago
            // 
            txtFechaVencimientoPago.Location = new Point(1118, 372);
            txtFechaVencimientoPago.Name = "txtFechaVencimientoPago";
            txtFechaVencimientoPago.ReadOnly = true;
            txtFechaVencimientoPago.Size = new Size(250, 27);
            txtFechaVencimientoPago.TabIndex = 7;
            // 
            // btnPago
            // 
            btnPago.BackColor = Color.DodgerBlue;
            btnPago.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold);
            btnPago.Location = new Point(1118, 612);
            btnPago.Name = "btnPago";
            btnPago.Size = new Size(155, 52);
            btnPago.TabIndex = 8;
            btnPago.Text = "Pago";
            btnPago.UseVisualStyleBackColor = false;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(1118, 551);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(250, 27);
            txtMonto.TabIndex = 9;
            // 
            // PagosMembresia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design__13_;
            ClientSize = new Size(1420, 763);
            Controls.Add(txtMonto);
            Controls.Add(btnPago);
            Controls.Add(txtFechaVencimientoPago);
            Controls.Add(cmbTipoClientePago);
            Controls.Add(cmbClientePago);
            Controls.Add(dgvPagoMembresia);
            Controls.Add(PicPagoRegistroMembresia);
            Controls.Add(dtpPago);
            Controls.Add(PicPagoInicio);
            Controls.Add(pictureBox1);
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
    }
}