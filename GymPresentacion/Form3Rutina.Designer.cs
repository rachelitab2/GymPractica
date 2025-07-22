namespace GymPresentacion
{
    partial class Form3Rutina
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnAgregarRutina = new Button();
            btnConsultarRutina = new Button();
            btnEliminarRutina = new Button();
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
            pictureBox1 = new PictureBox();
            PicRutinaInicio = new PictureBox();
            PicEntrenadorIr = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PicMemRutina).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRutinas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDuracion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicRutinaInicio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicEntrenadorIr).BeginInit();
            SuspendLayout();
            // 
            // btnAgregarRutina
            // 
            btnAgregarRutina.BackColor = Color.DodgerBlue;
            btnAgregarRutina.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold);
            btnAgregarRutina.ForeColor = Color.Black;
            btnAgregarRutina.Location = new Point(1185, 565);
            btnAgregarRutina.Name = "btnAgregarRutina";
            btnAgregarRutina.Size = new Size(145, 52);
            btnAgregarRutina.TabIndex = 0;
            btnAgregarRutina.Text = "Agregar";
            btnAgregarRutina.UseVisualStyleBackColor = false;
            // 
            // btnConsultarRutina
            // 
            btnConsultarRutina.BackColor = Color.DodgerBlue;
            btnConsultarRutina.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold);
            btnConsultarRutina.ForeColor = Color.Black;
            btnConsultarRutina.Location = new Point(369, 565);
            btnConsultarRutina.Name = "btnConsultarRutina";
            btnConsultarRutina.Size = new Size(136, 52);
            btnConsultarRutina.TabIndex = 1;
            btnConsultarRutina.Text = "Consultar";
            btnConsultarRutina.UseVisualStyleBackColor = false;
            // 
            // btnEliminarRutina
            // 
            btnEliminarRutina.BackColor = Color.DodgerBlue;
            btnEliminarRutina.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold);
            btnEliminarRutina.ForeColor = Color.Black;
            btnEliminarRutina.Location = new Point(553, 565);
            btnEliminarRutina.Name = "btnEliminarRutina";
            btnEliminarRutina.Size = new Size(139, 52);
            btnEliminarRutina.TabIndex = 2;
            btnEliminarRutina.Text = "Eliminar";
            btnEliminarRutina.UseVisualStyleBackColor = false;
            btnEliminarRutina.Click += btnEliminarRutina_Click;
            // 
            // lblGeneroRutina
            // 
            lblGeneroRutina.AutoSize = true;
            lblGeneroRutina.BackColor = Color.Transparent;
            lblGeneroRutina.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGeneroRutina.ForeColor = Color.Lavender;
            lblGeneroRutina.Location = new Point(930, 237);
            lblGeneroRutina.Name = "lblGeneroRutina";
            lblGeneroRutina.Size = new Size(163, 25);
            lblGeneroRutina.TabIndex = 4;
            lblGeneroRutina.Text = "Genero Cliente";
            lblGeneroRutina.Click += lblGeneroRutina_Click;
            // 
            // lblZonaRutina
            // 
            lblZonaRutina.AutoSize = true;
            lblZonaRutina.BackColor = Color.Transparent;
            lblZonaRutina.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblZonaRutina.ForeColor = Color.Lavender;
            lblZonaRutina.Location = new Point(930, 317);
            lblZonaRutina.Name = "lblZonaRutina";
            lblZonaRutina.Size = new Size(135, 25);
            lblZonaRutina.TabIndex = 5;
            lblZonaRutina.Text = "Area Rutina";
            // 
            // cmbGeneroRutina
            // 
            cmbGeneroRutina.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGeneroRutina.FormattingEnabled = true;
            cmbGeneroRutina.Location = new Point(1174, 238);
            cmbGeneroRutina.Name = "cmbGeneroRutina";
            cmbGeneroRutina.Size = new Size(296, 28);
            cmbGeneroRutina.TabIndex = 9;
            cmbGeneroRutina.SelectedIndexChanged += cmbGeneroRutina_SelectedIndexChanged;
            // 
            // PicMemRutina
            // 
            PicMemRutina.BackColor = Color.Transparent;
            PicMemRutina.BackgroundImage = Properties.Resources.image_removebg_preview__3_;
            PicMemRutina.BackgroundImageLayout = ImageLayout.Zoom;
            PicMemRutina.Cursor = Cursors.Hand;
            PicMemRutina.Location = new Point(138, 64);
            PicMemRutina.Name = "PicMemRutina";
            PicMemRutina.Size = new Size(100, 84);
            PicMemRutina.SizeMode = PictureBoxSizeMode.Zoom;
            PicMemRutina.TabIndex = 10;
            PicMemRutina.TabStop = false;
            PicMemRutina.Click += PicMemRutina_Click;
            // 
            // dgvRutinas
            // 
            dgvRutinas.AllowUserToAddRows = false;
            dgvRutinas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvRutinas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvRutinas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRutinas.BackgroundColor = Color.Black;
            dgvRutinas.BorderStyle = BorderStyle.None;
            dgvRutinas.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvRutinas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvRutinas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvRutinas.DefaultCellStyle = dataGridViewCellStyle3;
            dgvRutinas.EnableHeadersVisualStyles = false;
            dgvRutinas.GridColor = Color.DodgerBlue;
            dgvRutinas.Location = new Point(42, 160);
            dgvRutinas.MultiSelect = false;
            dgvRutinas.Name = "dgvRutinas";
            dgvRutinas.ReadOnly = true;
            dgvRutinas.RowHeadersVisible = false;
            dgvRutinas.RowHeadersWidth = 51;
            dgvRutinas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRutinas.Size = new Size(846, 388);
            dgvRutinas.TabIndex = 5;
            // 
            // lblNombreRutina
            // 
            lblNombreRutina.AutoSize = true;
            lblNombreRutina.BackColor = Color.Transparent;
            lblNombreRutina.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreRutina.ForeColor = Color.Lavender;
            lblNombreRutina.Location = new Point(930, 160);
            lblNombreRutina.Name = "lblNombreRutina";
            lblNombreRutina.Size = new Size(204, 25);
            lblNombreRutina.TabIndex = 11;
            lblNombreRutina.Text = "Nombre de Rutina ";
            // 
            // txtNombreRutina
            // 
            txtNombreRutina.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreRutina.Location = new Point(1174, 161);
            txtNombreRutina.Name = "txtNombreRutina";
            txtNombreRutina.ShortcutsEnabled = false;
            txtNombreRutina.Size = new Size(296, 27);
            txtNombreRutina.TabIndex = 12;
            txtNombreRutina.TextChanged += txtNombreRutina_TextChanged;
            txtNombreRutina.KeyPress += txtNombreRutina_KeyPress;
            // 
            // cmbAreaRutina
            // 
            cmbAreaRutina.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAreaRutina.FormattingEnabled = true;
            cmbAreaRutina.Location = new Point(1174, 317);
            cmbAreaRutina.Name = "cmbAreaRutina";
            cmbAreaRutina.Size = new Size(296, 28);
            cmbAreaRutina.TabIndex = 13;
            // 
            // lblDuracion
            // 
            lblDuracion.AutoSize = true;
            lblDuracion.BackColor = Color.Transparent;
            lblDuracion.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDuracion.ForeColor = Color.Lavender;
            lblDuracion.Location = new Point(930, 394);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(158, 25);
            lblDuracion.TabIndex = 14;
            lblDuracion.Text = "Duracion(min)";
            lblDuracion.Click += lblDuracion_Click;
            // 
            // nudDuracion
            // 
            nudDuracion.Location = new Point(1228, 396);
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
            btnEditarRutina.BackColor = Color.DodgerBlue;
            btnEditarRutina.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold);
            btnEditarRutina.ForeColor = Color.Black;
            btnEditarRutina.Location = new Point(745, 565);
            btnEditarRutina.Name = "btnEditarRutina";
            btnEditarRutina.Size = new Size(143, 52);
            btnEditarRutina.TabIndex = 16;
            btnEditarRutina.Text = "Editar";
            btnEditarRutina.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.image_removebg_preview__4_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(514, -8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(589, 162);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // PicRutinaInicio
            // 
            PicRutinaInicio.BackColor = Color.Transparent;
            PicRutinaInicio.BackgroundImage = Properties.Resources.image_removebg_preview__7_;
            PicRutinaInicio.BackgroundImageLayout = ImageLayout.Zoom;
            PicRutinaInicio.Location = new Point(42, 64);
            PicRutinaInicio.Name = "PicRutinaInicio";
            PicRutinaInicio.Size = new Size(100, 84);
            PicRutinaInicio.TabIndex = 21;
            PicRutinaInicio.TabStop = false;
            PicRutinaInicio.Click += PicRutinaInicio_Click;
            // 
            // PicEntrenadorIr
            // 
            PicEntrenadorIr.BackColor = Color.Transparent;
            PicEntrenadorIr.BackgroundImage = Properties.Resources.image_removebg_preview__9_;
            PicEntrenadorIr.BackgroundImageLayout = ImageLayout.Zoom;
            PicEntrenadorIr.Location = new Point(234, 64);
            PicEntrenadorIr.Name = "PicEntrenadorIr";
            PicEntrenadorIr.Size = new Size(100, 84);
            PicEntrenadorIr.SizeMode = PictureBoxSizeMode.StretchImage;
            PicEntrenadorIr.TabIndex = 19;
            PicEntrenadorIr.TabStop = false;
            // 
            // Form3Rutina
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design__13_;
            ClientSize = new Size(1532, 667);
            Controls.Add(PicRutinaInicio);
            Controls.Add(pictureBox1);
            Controls.Add(PicEntrenadorIr);
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
            Controls.Add(btnEliminarRutina);
            Controls.Add(btnConsultarRutina);
            Controls.Add(btnAgregarRutina);
            Cursor = Cursors.Hand;
            Name = "Form3Rutina";
            Text = "Form3";
            Load += PicMem2_Load;
            ((System.ComponentModel.ISupportInitialize)PicMemRutina).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRutinas).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDuracion).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicRutinaInicio).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicEntrenadorIr).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarRutina;
        private Button btnConsultarRutina;
        private Button btnEliminarRutina;
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
        private PictureBox pictureBox1;
        private PictureBox PicRutinaInicio;
        private PictureBox PicEntrenadorIr;
    }
}