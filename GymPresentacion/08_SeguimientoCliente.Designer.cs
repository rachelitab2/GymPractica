namespace GymPresentacion
{
    partial class PesoSeguimien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesoSeguimien));
            lblSEGUIMIENTO = new Label();
            lblClienteSeguimiento = new Label();
            label3 = new Label();
            lblPeso = new Label();
            lblAltura = new Label();
            lblGrasa = new Label();
            pictureBox1 = new PictureBox();
            DatosdelClienteP = new DataGridView();
            AlturSeguemiento = new TextBox();
            ClienteSeguimiento = new TextBox();
            PesoSeguimieto = new TextBox();
            BotonSeguimin = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            FechaSeguimin = new DateTimePicker();
            label1 = new Label();
            button1 = new Button();
            AtrasInicio = new PictureBox();
            GrasaSeguimiento = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DatosdelClienteP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AtrasInicio).BeginInit();
            SuspendLayout();
            // 
            // lblSEGUIMIENTO
            // 
            lblSEGUIMIENTO.AutoSize = true;
            lblSEGUIMIENTO.BackColor = Color.Transparent;
            lblSEGUIMIENTO.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSEGUIMIENTO.ForeColor = Color.Lavender;
            lblSEGUIMIENTO.Location = new Point(261, 160);
            lblSEGUIMIENTO.Name = "lblSEGUIMIENTO";
            lblSEGUIMIENTO.Size = new Size(420, 45);
            lblSEGUIMIENTO.TabIndex = 0;
            lblSEGUIMIENTO.Text = "Seguimiento de Proceso";
            lblSEGUIMIENTO.Click += label1_Click;
            // 
            // lblClienteSeguimiento
            // 
            lblClienteSeguimiento.AutoSize = true;
            lblClienteSeguimiento.BackColor = Color.Transparent;
            lblClienteSeguimiento.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            lblClienteSeguimiento.ForeColor = Color.Lavender;
            lblClienteSeguimiento.Location = new Point(882, 236);
            lblClienteSeguimiento.Name = "lblClienteSeguimiento";
            lblClienteSeguimiento.Size = new Size(90, 25);
            lblClienteSeguimiento.TabIndex = 1;
            lblClienteSeguimiento.Text = "Cliente:";
            lblClienteSeguimiento.Click += lblClienteSeguimiento_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1061, 403);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "label3";
            label3.Click += label3_Click;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.BackColor = Color.Transparent;
            lblPeso.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            lblPeso.ForeColor = Color.Lavender;
            lblPeso.Location = new Point(866, 293);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(119, 25);
            lblPeso.TabIndex = 3;
            lblPeso.Text = "Peso (Kg):";
            lblPeso.Click += lblPeso_Click;
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.BackColor = Color.Transparent;
            lblAltura.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            lblAltura.ForeColor = Color.Lavender;
            lblAltura.Location = new Point(849, 354);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(136, 25);
            lblAltura.TabIndex = 4;
            lblAltura.Text = "Altura (cm):";
            // 
            // lblGrasa
            // 
            lblGrasa.AutoSize = true;
            lblGrasa.BackColor = Color.Transparent;
            lblGrasa.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            lblGrasa.ForeColor = Color.Lavender;
            lblGrasa.Location = new Point(799, 418);
            lblGrasa.Name = "lblGrasa";
            lblGrasa.Size = new Size(218, 25);
            lblGrasa.TabIndex = 5;
            lblGrasa.Text = "Grasa Corporal(%):";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.image_removebg_preview__4_;
            pictureBox1.Location = new Point(495, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(415, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // DatosdelClienteP
            // 
            DatosdelClienteP.AllowUserToAddRows = false;
            DatosdelClienteP.AllowUserToDeleteRows = false;
            DatosdelClienteP.AllowUserToResizeColumns = false;
            DatosdelClienteP.AllowUserToResizeRows = false;
            DatosdelClienteP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DatosdelClienteP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DatosdelClienteP.GridColor = SystemColors.MenuHighlight;
            DatosdelClienteP.Location = new Point(22, 223);
            DatosdelClienteP.Margin = new Padding(2);
            DatosdelClienteP.Name = "DatosdelClienteP";
            DatosdelClienteP.ReadOnly = true;
            DatosdelClienteP.RowHeadersWidth = 62;
            DatosdelClienteP.Size = new Size(758, 298);
            DatosdelClienteP.TabIndex = 7;
            // 
            // AlturSeguemiento
            // 
            AlturSeguemiento.BackColor = Color.White;
            AlturSeguemiento.Cursor = Cursors.IBeam;
            AlturSeguemiento.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AlturSeguemiento.Location = new Point(984, 359);
            AlturSeguemiento.MaxLength = 30;
            AlturSeguemiento.Name = "AlturSeguemiento";
            AlturSeguemiento.ShortcutsEnabled = false;
            AlturSeguemiento.Size = new Size(296, 27);
            AlturSeguemiento.TabIndex = 8;
            AlturSeguemiento.TextChanged += dd_TextChanged;
            // 
            // ClienteSeguimiento
            // 
            ClienteSeguimiento.BackColor = Color.White;
            ClienteSeguimiento.Cursor = Cursors.IBeam;
            ClienteSeguimiento.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClienteSeguimiento.Location = new Point(977, 236);
            ClienteSeguimiento.MaxLength = 30;
            ClienteSeguimiento.Name = "ClienteSeguimiento";
            ClienteSeguimiento.ShortcutsEnabled = false;
            ClienteSeguimiento.Size = new Size(302, 27);
            ClienteSeguimiento.TabIndex = 10;
            ClienteSeguimiento.TextChanged += ClienteSeguimiento_TextChanged;
            // 
            // PesoSeguimieto
            // 
            PesoSeguimieto.BackColor = Color.White;
            PesoSeguimieto.Cursor = Cursors.IBeam;
            PesoSeguimieto.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PesoSeguimieto.Location = new Point(994, 298);
            PesoSeguimieto.MaxLength = 30;
            PesoSeguimieto.Name = "PesoSeguimieto";
            PesoSeguimieto.ShortcutsEnabled = false;
            PesoSeguimieto.Size = new Size(296, 27);
            PesoSeguimieto.TabIndex = 11;
            PesoSeguimieto.TextChanged += PesoSeguimiento_TextChanged;
            // 
            // BotonSeguimin
            // 
            BotonSeguimin.Cursor = Cursors.Hand;
            BotonSeguimin.Location = new Point(1030, 538);
            BotonSeguimin.Margin = new Padding(2);
            BotonSeguimin.Name = "BotonSeguimin";
            BotonSeguimin.Size = new Size(119, 62);
            BotonSeguimin.TabIndex = 12;
            BotonSeguimin.UseVisualStyleBackColor = true;
            BotonSeguimin.Click += BotonSeguimin_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // FechaSeguimin
            // 
            FechaSeguimin.Location = new Point(994, 482);
            FechaSeguimin.Name = "FechaSeguimin";
            FechaSeguimin.Size = new Size(296, 27);
            FechaSeguimin.TabIndex = 13;
            FechaSeguimin.ValueChanged += FechaSeguimin_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label1.ForeColor = Color.Lavender;
            label1.Location = new Point(909, 482);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 14;
            label1.Text = "Fecha:";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(22, 538);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(101, 62);
            button1.TabIndex = 15;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AtrasInicio
            // 
            AtrasInicio.BackColor = Color.Transparent;
            AtrasInicio.BackgroundImage = Properties.Resources.image_removebg_preview__7_;
            AtrasInicio.BackgroundImageLayout = ImageLayout.Zoom;
            AtrasInicio.Cursor = Cursors.Hand;
            AtrasInicio.Location = new Point(22, 155);
            AtrasInicio.Name = "AtrasInicio";
            AtrasInicio.Size = new Size(125, 62);
            AtrasInicio.TabIndex = 16;
            AtrasInicio.TabStop = false;
            AtrasInicio.Click += AtrasInicio_Click;
            // 
            // GrasaSeguimiento
            // 
            GrasaSeguimiento.BackColor = Color.White;
            GrasaSeguimiento.Cursor = Cursors.IBeam;
            GrasaSeguimiento.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GrasaSeguimiento.Location = new Point(1009, 418);
            GrasaSeguimiento.MaxLength = 30;
            GrasaSeguimiento.Name = "GrasaSeguimiento";
            GrasaSeguimiento.ShortcutsEnabled = false;
            GrasaSeguimiento.Size = new Size(270, 27);
            GrasaSeguimiento.TabIndex = 9;
            // 
            // PesoSeguimien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1300, 616);
            Controls.Add(AtrasInicio);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(FechaSeguimin);
            Controls.Add(BotonSeguimin);
            Controls.Add(PesoSeguimieto);
            Controls.Add(ClienteSeguimiento);
            Controls.Add(GrasaSeguimiento);
            Controls.Add(AlturSeguemiento);
            Controls.Add(DatosdelClienteP);
            Controls.Add(pictureBox1);
            Controls.Add(lblGrasa);
            Controls.Add(lblAltura);
            Controls.Add(lblPeso);
            Controls.Add(label3);
            Controls.Add(lblClienteSeguimiento);
            Controls.Add(lblSEGUIMIENTO);
            DoubleBuffered = true;
            Name = "PesoSeguimien";
            Text = "SeguimientoCliente";
            Load += SeguimientoCliente_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DatosdelClienteP).EndInit();
            ((System.ComponentModel.ISupportInitialize)AtrasInicio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSEGUIMIENTO;
        private Label lblClienteSeguimiento;
        private Label label3;
        private Label lblPeso;
        private Label lblAltura;
        private Label lblGrasa;
        private PictureBox pictureBox1;

        private DataGridView DatosdelClienteP;
        private ComboBox cmbTipoMembresia;
        private TextBox AlturSeguemiento;
        private TextBox ClienteSeguimiento;
        private TextBox PesoSeguimieto;
        private Button BotonSeguimin;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DateTimePicker FechaSeguimin;
        private Label label1;
        private Button button1;
        private PictureBox AtrasInicio;
        private TextBox GrasaSeguimiento;
    }
}