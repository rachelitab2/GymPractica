namespace GymPresentacion
{
    partial class PicMem3
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
            btnAgregarRutina = new Button();
            btnConsultarRutina = new Button();
            btnEliminarRutina = new Button();
            btnBuscarRutina = new Button();
            lblGeneroRutina = new Label();
            lblZonaRutina = new Label();
            cmbGeneroRutina = new ComboBox();
            PicMemRutina = new PictureBox();
            dgvRutinas = new DataGridView();
            lblNombreRutina = new Label();
            txtNombreRutina = new TextBox();
            cmbAreaRutina = new ComboBox();
            lblDuracion = new Label();
            nudDuracion = new NumericUpDown();
            btnEditarRutina = new Button();
            lblEntrenador = new Label();
            cmbEntrenador = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)PicMemRutina).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRutinas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDuracion).BeginInit();
            SuspendLayout();
            // 
            // btnAgregarRutina
            // 
            btnAgregarRutina.BackColor = Color.IndianRed;
            btnAgregarRutina.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarRutina.ForeColor = Color.White;
            btnAgregarRutina.Location = new Point(847, 548);
            btnAgregarRutina.Name = "btnAgregarRutina";
            btnAgregarRutina.Size = new Size(145, 52);
            btnAgregarRutina.TabIndex = 0;
            btnAgregarRutina.Text = "Agregar";
            btnAgregarRutina.UseVisualStyleBackColor = false;
            // 
            // btnConsultarRutina
            // 
            btnConsultarRutina.BackColor = Color.IndianRed;
            btnConsultarRutina.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultarRutina.ForeColor = Color.White;
            btnConsultarRutina.Location = new Point(556, 546);
            btnConsultarRutina.Name = "btnConsultarRutina";
            btnConsultarRutina.Size = new Size(136, 52);
            btnConsultarRutina.TabIndex = 1;
            btnConsultarRutina.Text = "Consultar";
            btnConsultarRutina.UseVisualStyleBackColor = false;
            // 
            // btnEliminarRutina
            // 
            btnEliminarRutina.BackColor = Color.IndianRed;
            btnEliminarRutina.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarRutina.ForeColor = Color.White;
            btnEliminarRutina.Location = new Point(411, 548);
            btnEliminarRutina.Name = "btnEliminarRutina";
            btnEliminarRutina.Size = new Size(139, 52);
            btnEliminarRutina.TabIndex = 2;
            btnEliminarRutina.Text = "Eliminar";
            btnEliminarRutina.UseVisualStyleBackColor = false;
            btnEliminarRutina.Click += btnEliminarRutina_Click;
            // 
            // btnBuscarRutina
            // 
            btnBuscarRutina.BackColor = Color.IndianRed;
            btnBuscarRutina.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarRutina.ForeColor = Color.White;
            btnBuscarRutina.Location = new Point(1248, 548);
            btnBuscarRutina.Name = "btnBuscarRutina";
            btnBuscarRutina.Size = new Size(145, 53);
            btnBuscarRutina.TabIndex = 3;
            btnBuscarRutina.Text = "Buscar";
            btnBuscarRutina.UseVisualStyleBackColor = false;
            // 
            // lblGeneroRutina
            // 
            lblGeneroRutina.AutoSize = true;
            lblGeneroRutina.BackColor = Color.IndianRed;
            lblGeneroRutina.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGeneroRutina.ForeColor = Color.White;
            lblGeneroRutina.Location = new Point(1013, 237);
            lblGeneroRutina.Name = "lblGeneroRutina";
            lblGeneroRutina.Size = new Size(163, 25);
            lblGeneroRutina.TabIndex = 4;
            lblGeneroRutina.Text = "Genero Cliente";
            lblGeneroRutina.Click += lblGeneroRutina_Click;
            // 
            // lblZonaRutina
            // 
            lblZonaRutina.AutoSize = true;
            lblZonaRutina.BackColor = Color.IndianRed;
            lblZonaRutina.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblZonaRutina.ForeColor = Color.White;
            lblZonaRutina.Location = new Point(1013, 313);
            lblZonaRutina.Name = "lblZonaRutina";
            lblZonaRutina.Size = new Size(135, 25);
            lblZonaRutina.TabIndex = 5;
            lblZonaRutina.Text = "Area Rutina";
            // 
            // cmbGeneroRutina
            // 
            cmbGeneroRutina.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGeneroRutina.FormattingEnabled = true;
            cmbGeneroRutina.Location = new Point(1223, 238);
            cmbGeneroRutina.Name = "cmbGeneroRutina";
            cmbGeneroRutina.Size = new Size(296, 28);
            cmbGeneroRutina.TabIndex = 9;
            cmbGeneroRutina.SelectedIndexChanged += cmbGeneroRutina_SelectedIndexChanged;
            // 
            // PicMemRutina
            // 
            PicMemRutina.BackColor = Color.Transparent;
            PicMemRutina.BackgroundImage = Properties.Resources._1;
            PicMemRutina.BackgroundImageLayout = ImageLayout.Zoom;
            PicMemRutina.Cursor = Cursors.Hand;
            PicMemRutina.Image = Properties.Resources._1;
            PicMemRutina.Location = new Point(32, 39);
            PicMemRutina.Name = "PicMemRutina";
            PicMemRutina.Size = new Size(319, 86);
            PicMemRutina.SizeMode = PictureBoxSizeMode.Zoom;
            PicMemRutina.TabIndex = 10;
            PicMemRutina.TabStop = false;
            PicMemRutina.Click += PicMemRutina_Click;
            // 
            // dgvRutinas
            // 
            dgvRutinas.AllowUserToAddRows = false;
            dgvRutinas.AllowUserToDeleteRows = false;
            dgvRutinas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRutinas.BackgroundColor = Color.WhiteSmoke;
            dgvRutinas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRutinas.GridColor = SystemColors.ScrollBar;
            dgvRutinas.Location = new Point(146, 131);
            dgvRutinas.Name = "dgvRutinas";
            dgvRutinas.ReadOnly = true;
            dgvRutinas.RowHeadersWidth = 51;
            dgvRutinas.Size = new Size(846, 388);
            dgvRutinas.TabIndex = 5;
            // 
            // lblNombreRutina
            // 
            lblNombreRutina.AutoSize = true;
            lblNombreRutina.BackColor = Color.IndianRed;
            lblNombreRutina.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreRutina.ForeColor = Color.White;
            lblNombreRutina.Location = new Point(1013, 159);
            lblNombreRutina.Name = "lblNombreRutina";
            lblNombreRutina.Size = new Size(204, 25);
            lblNombreRutina.TabIndex = 11;
            lblNombreRutina.Text = "Nombre de Rutina ";
            // 
            // txtNombreRutina
            // 
            txtNombreRutina.Location = new Point(1223, 160);
            txtNombreRutina.Name = "txtNombreRutina";
            txtNombreRutina.Size = new Size(296, 27);
            txtNombreRutina.TabIndex = 12;
            txtNombreRutina.TextChanged += txtNombreRutina_TextChanged;
            // 
            // cmbAreaRutina
            // 
            cmbAreaRutina.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAreaRutina.FormattingEnabled = true;
            cmbAreaRutina.Location = new Point(1223, 314);
            cmbAreaRutina.Name = "cmbAreaRutina";
            cmbAreaRutina.Size = new Size(296, 28);
            cmbAreaRutina.TabIndex = 13;
            // 
            // lblDuracion
            // 
            lblDuracion.AutoSize = true;
            lblDuracion.BackColor = Color.IndianRed;
            lblDuracion.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDuracion.ForeColor = Color.White;
            lblDuracion.Location = new Point(1013, 396);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(158, 25);
            lblDuracion.TabIndex = 14;
            lblDuracion.Text = "Duracion(min)";
            lblDuracion.Click += lblDuracion_Click;
            // 
            // nudDuracion
            // 
            nudDuracion.Location = new Point(1299, 394);
            nudDuracion.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            nudDuracion.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            nudDuracion.Name = "nudDuracion";
            nudDuracion.Size = new Size(150, 27);
            nudDuracion.TabIndex = 15;
            nudDuracion.Value = new decimal(new int[] { 10, 0, 0, 0 });
            nudDuracion.ValueChanged += nudDuracion_ValueChanged;
            // 
            // btnEditarRutina
            // 
            btnEditarRutina.BackColor = Color.IndianRed;
            btnEditarRutina.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarRutina.ForeColor = Color.White;
            btnEditarRutina.Location = new Point(698, 548);
            btnEditarRutina.Name = "btnEditarRutina";
            btnEditarRutina.Size = new Size(143, 52);
            btnEditarRutina.TabIndex = 16;
            btnEditarRutina.Text = "Editar";
            btnEditarRutina.UseVisualStyleBackColor = false;
            // 
            // lblEntrenador
            // 
            lblEntrenador.AutoSize = true;
            lblEntrenador.BackColor = Color.IndianRed;
            lblEntrenador.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEntrenador.ForeColor = Color.White;
            lblEntrenador.Location = new Point(1013, 475);
            lblEntrenador.Name = "lblEntrenador";
            lblEntrenador.Size = new Size(129, 25);
            lblEntrenador.TabIndex = 17;
            lblEntrenador.Text = "Entrenador";
            // 
            // cmbEntrenador
            // 
            cmbEntrenador.FormattingEnabled = true;
            cmbEntrenador.Location = new Point(1223, 472);
            cmbEntrenador.Name = "cmbEntrenador";
            cmbEntrenador.Size = new Size(296, 28);
            cmbEntrenador.TabIndex = 18;
            // 
            // PicMem3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._4;
            ClientSize = new Size(1572, 706);
            Controls.Add(cmbEntrenador);
            Controls.Add(lblEntrenador);
            Controls.Add(btnEditarRutina);
            Controls.Add(nudDuracion);
            Controls.Add(lblDuracion);
            Controls.Add(cmbAreaRutina);
            Controls.Add(txtNombreRutina);
            Controls.Add(lblNombreRutina);
            Controls.Add(dgvRutinas);
            Controls.Add(PicMemRutina);
            Controls.Add(cmbGeneroRutina);
            Controls.Add(lblZonaRutina);
            Controls.Add(lblGeneroRutina);
            Controls.Add(btnBuscarRutina);
            Controls.Add(btnEliminarRutina);
            Controls.Add(btnConsultarRutina);
            Controls.Add(btnAgregarRutina);
            Cursor = Cursors.Hand;
            Name = "PicMem3";
            Text = "Form3";
            Load += PicMem2_Load;
            ((System.ComponentModel.ISupportInitialize)PicMemRutina).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRutinas).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDuracion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarRutina;
        private Button btnConsultarRutina;
        private Button btnEliminarRutina;
        private Button btnBuscarRutina;
        private Label lblGeneroRutina;
        private Label lblZonaRutina;
        private ComboBox cmbGeneroRutina;
        private PictureBox PicMemRutina;
        private DataGridView dgvRutinas;
        private Label lblNombreRutina;
        private TextBox txtNombreRutina;
        private ComboBox cmbAreaRutina;
        private Label lblDuracion;
        private NumericUpDown nudDuracion;
        private Button btnEditarRutina;
        private Label lblEntrenador;
        private ComboBox cmbEntrenador;
    }
}