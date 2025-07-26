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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblSEGUIMIENTO
            // 
            lblSEGUIMIENTO.AutoSize = true;
            lblSEGUIMIENTO.BackColor = Color.Transparent;
            lblSEGUIMIENTO.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSEGUIMIENTO.ForeColor = Color.Lavender;
            lblSEGUIMIENTO.Location = new Point(739, 203);
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
            lblClienteSeguimiento.Location = new Point(1061, 350);
            lblClienteSeguimiento.Name = "lblClienteSeguimiento";
            lblClienteSeguimiento.Size = new Size(82, 25);
            lblClienteSeguimiento.TabIndex = 1;
            lblClienteSeguimiento.Text = "Cliente";
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
            lblPeso.Location = new Point(1061, 454);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(119, 25);
            lblPeso.TabIndex = 3;
            lblPeso.Text = "Peso (Kg):";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.BackColor = Color.Transparent;
            lblAltura.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            lblAltura.ForeColor = Color.Lavender;
            lblAltura.Location = new Point(1061, 499);
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
            lblGrasa.Location = new Point(1061, 543);
            lblGrasa.Name = "lblGrasa";
            lblGrasa.Size = new Size(218, 25);
            lblGrasa.TabIndex = 5;
            lblGrasa.Text = "Grasa Corporal(%):";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.image_removebg_preview__4_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(637, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(589, 162);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // SeguimientoCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design__13_;
            ClientSize = new Size(1567, 767);
            Controls.Add(pictureBox1);
            Controls.Add(lblGrasa);
            Controls.Add(lblAltura);
            Controls.Add(lblPeso);
            Controls.Add(label3);
            Controls.Add(lblClienteSeguimiento);
            Controls.Add(lblSEGUIMIENTO);
            DoubleBuffered = true;
            Name = "SeguimientoCliente";
            Text = "SeguimientoCliente";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}