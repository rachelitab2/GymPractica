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
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            txtNombreClienteSeguimiento = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
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
            lblClienteSeguimiento.Location = new Point(1077, 337);
            lblClienteSeguimiento.Name = "lblClienteSeguimiento";
            lblClienteSeguimiento.Size = new Size(82, 25);
            lblClienteSeguimiento.TabIndex = 1;
            lblClienteSeguimiento.Text = "Cliente";
            lblClienteSeguimiento.Click += this.lblClienteSeguimiento_Click;
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
            lblPeso.Location = new Point(1077, 398);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(119, 25);
            lblPeso.TabIndex = 3;
            lblPeso.Text = "Peso (Kg):";
            lblPeso.Click += this.lblPeso_Click;
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.BackColor = Color.Transparent;
            lblAltura.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            lblAltura.ForeColor = Color.Lavender;
            lblAltura.Location = new Point(1077, 458);
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
            lblGrasa.Location = new Point(1077, 516);
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
            pictureBox1.Location = new Point(637, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(589, 162);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(1202, 396);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(214, 27);
            numericUpDown1.TabIndex = 7;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(1301, 518);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(115, 27);
            numericUpDown2.TabIndex = 8;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(1219, 456);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(197, 27);
            numericUpDown3.TabIndex = 9;
            numericUpDown3.ValueChanged += this.numericUpDown3_ValueChanged;
            // 
            // txtNombreClienteSeguimiento
            // 
            txtNombreClienteSeguimiento.Location = new Point(1185, 335);
            txtNombreClienteSeguimiento.Name = "txtNombreClienteSeguimiento";
            txtNombreClienteSeguimiento.Size = new Size(231, 27);
            txtNombreClienteSeguimiento.TabIndex = 10;
            // 
            // SeguimientoCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1567, 767);
            Controls.Add(txtNombreClienteSeguimiento);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
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
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
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
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private TextBox txtNombreClienteSeguimiento;
    }
}