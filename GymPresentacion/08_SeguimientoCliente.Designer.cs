namespace GymPresentacion
{
    partial class SeguimientoCliente
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
            lblSEGUIMIENTO = new Label();
            lblClienteSeguimiento = new Label();
            label3 = new Label();
            lblPeso = new Label();
            lblAltura = new Label();
            lblGrasa = new Label();
            pictureBox1 = new PictureBox();
            DatosdelClienteP = new DataGridView();
            AlturSeguemien = new TextBox();
            PesoSeguimien = new TextBox();
            ClienteSeguimiento = new TextBox();
            GrasaSeguimien = new TextBox();
            BotonSeguimin = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            FechaSeguimin = new DateTimePicker();
            label1 = new Label();
            button1 = new Button();
            AtrasInicio = new PictureBox();
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
            lblSEGUIMIENTO.Location = new Point(302, 244);
            lblSEGUIMIENTO.Margin = new Padding(4, 0, 4, 0);
            lblSEGUIMIENTO.Name = "lblSEGUIMIENTO";
            lblSEGUIMIENTO.Size = new Size(506, 55);
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
            lblClienteSeguimiento.Location = new Point(1233, 362);
            lblClienteSeguimiento.Margin = new Padding(4, 0, 4, 0);
            lblClienteSeguimiento.Name = "lblClienteSeguimiento";
            lblClienteSeguimiento.Size = new Size(99, 32);
            lblClienteSeguimiento.TabIndex = 1;
            lblClienteSeguimiento.Text = "Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1326, 504);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
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
            lblPeso.Location = new Point(1233, 444);
            lblPeso.Margin = new Padding(4, 0, 4, 0);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(140, 32);
            lblPeso.TabIndex = 3;
            lblPeso.Text = "Peso (Kg):";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.BackColor = Color.Transparent;
            lblAltura.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            lblAltura.ForeColor = Color.Lavender;
            lblAltura.Location = new Point(1233, 534);
            lblAltura.Margin = new Padding(4, 0, 4, 0);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(161, 32);
            lblAltura.TabIndex = 4;
            lblAltura.Text = "Altura (cm):";
            // 
            // lblGrasa
            // 
            lblGrasa.AutoSize = true;
            lblGrasa.BackColor = Color.Transparent;
            lblGrasa.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            lblGrasa.ForeColor = Color.Lavender;
            lblGrasa.Location = new Point(1158, 614);
            lblGrasa.Margin = new Padding(4, 0, 4, 0);
            lblGrasa.Name = "lblGrasa";
            lblGrasa.Size = new Size(257, 32);
            lblGrasa.TabIndex = 5;
            lblGrasa.Text = "Grasa Corporal(%):";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.image_removebg_preview__4_;
            pictureBox1.Location = new Point(692, 13);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(736, 202);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // DatosdelClienteP
            // 
            DatosdelClienteP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DatosdelClienteP.Location = new Point(68, 353);
            DatosdelClienteP.Name = "DatosdelClienteP";
            DatosdelClienteP.RowHeadersWidth = 62;
            DatosdelClienteP.Size = new Size(986, 443);
            DatosdelClienteP.TabIndex = 7;
            // 
            // AlturSeguemien
            // 
            AlturSeguemien.BackColor = Color.White;
            AlturSeguemien.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AlturSeguemien.Location = new Point(1423, 535);
            AlturSeguemien.Margin = new Padding(4);
            AlturSeguemien.MaxLength = 30;
            AlturSeguemien.Name = "AlturSeguemien";
            AlturSeguemien.ShortcutsEnabled = false;
            AlturSeguemien.Size = new Size(369, 31);
            AlturSeguemien.TabIndex = 8;
            // 
            // PesoSeguimien
            // 
            PesoSeguimien.BackColor = Color.White;
            PesoSeguimien.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PesoSeguimien.Location = new Point(1405, 445);
            PesoSeguimien.Margin = new Padding(4);
            PesoSeguimien.MaxLength = 30;
            PesoSeguimien.Name = "PesoSeguimien";
            PesoSeguimien.ShortcutsEnabled = false;
            PesoSeguimien.Size = new Size(369, 31);
            PesoSeguimien.TabIndex = 9;
            // 
            // ClienteSeguimiento
            // 
            ClienteSeguimiento.BackColor = Color.White;
            ClienteSeguimiento.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClienteSeguimiento.Location = new Point(1387, 363);
            ClienteSeguimiento.Margin = new Padding(4);
            ClienteSeguimiento.MaxLength = 30;
            ClienteSeguimiento.Name = "ClienteSeguimiento";
            ClienteSeguimiento.ShortcutsEnabled = false;
            ClienteSeguimiento.Size = new Size(376, 31);
            ClienteSeguimiento.TabIndex = 10;
            // 
            // GrasaSeguimien
            // 
            GrasaSeguimien.BackColor = Color.White;
            GrasaSeguimien.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GrasaSeguimien.Location = new Point(1443, 620);
            GrasaSeguimien.Margin = new Padding(4);
            GrasaSeguimien.MaxLength = 30;
            GrasaSeguimien.Name = "GrasaSeguimien";
            GrasaSeguimien.ShortcutsEnabled = false;
            GrasaSeguimien.Size = new Size(369, 31);
            GrasaSeguimien.TabIndex = 11;
            // 
            // BotonSeguimin
            // 
            BotonSeguimin.Location = new Point(1405, 819);
            BotonSeguimin.Name = "BotonSeguimin";
            BotonSeguimin.Size = new Size(194, 89);
            BotonSeguimin.TabIndex = 12;
            BotonSeguimin.Text = "Guardar";
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
            FechaSeguimin.Location = new Point(1443, 691);
            FechaSeguimin.Margin = new Padding(4);
            FechaSeguimin.Name = "FechaSeguimin";
            FechaSeguimin.Size = new Size(369, 31);
            FechaSeguimin.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label1.ForeColor = Color.Lavender;
            label1.Location = new Point(1250, 690);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 32);
            label1.TabIndex = 14;
            label1.Text = "Fecha";
            // 
            // button1
            // 
            button1.Location = new Point(68, 819);
            button1.Name = "button1";
            button1.Size = new Size(185, 89);
            button1.TabIndex = 15;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AtrasInicio
            // 
            AtrasInicio.BackColor = Color.Transparent;
            AtrasInicio.BackgroundImage = Properties.Resources.image_removebg_preview__7_;
            AtrasInicio.BackgroundImageLayout = ImageLayout.Zoom;
            AtrasInicio.Location = new Point(68, 244);
            AtrasInicio.Margin = new Padding(4);
            AtrasInicio.Name = "AtrasInicio";
            AtrasInicio.Size = new Size(156, 78);
            AtrasInicio.TabIndex = 16;
            AtrasInicio.TabStop = false;
            AtrasInicio.Click += AtrasInicio_Click;
            // 
            // SeguimientoCliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1924, 959);
            Controls.Add(AtrasInicio);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(FechaSeguimin);
            Controls.Add(BotonSeguimin);
            Controls.Add(GrasaSeguimien);
            Controls.Add(ClienteSeguimiento);
            Controls.Add(PesoSeguimien);
            Controls.Add(AlturSeguemien);
            Controls.Add(DatosdelClienteP);
            Controls.Add(pictureBox1);
            Controls.Add(lblGrasa);
            Controls.Add(lblAltura);
            Controls.Add(lblPeso);
            Controls.Add(label3);
            Controls.Add(lblClienteSeguimiento);
            Controls.Add(lblSEGUIMIENTO);
            DoubleBuffered = true;
            Margin = new Padding(4);
            Name = "SeguimientoCliente";
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
        private TextBox AlturSeguemien;
        private TextBox PesoSeguimien;
        private TextBox ClienteSeguimiento;
        private TextBox GrasaSeguimien;
        private Button BotonSeguimin;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DateTimePicker FechaSeguimin;
        private Label label1;
        private Button button1;
        private PictureBox AtrasInicio;
    }
}