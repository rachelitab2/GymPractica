namespace GymPresentacion
{
    partial class RegistroRutina
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
            dgvRutinas = new DataGridView();
            lblNombreRutina = new Label();
            txtNombreRutina = new TextBox();
            cmbAreaRutina = new ComboBox();
            lblDuracion = new Label();
            nudDuracion = new NumericUpDown();
            btnEditarRutina = new Button();
            pictureBox1 = new PictureBox();
            PicRutinaInicio = new PictureBox();
            btnLimpiar1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRutinas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDuracion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicRutinaInicio).BeginInit();
            SuspendLayout();
            // 
            // btnAgregarRutina
            // 
            btnAgregarRutina.BackColor = Color.DodgerBlue;
            btnAgregarRutina.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold);
            btnAgregarRutina.ForeColor = Color.Black;
            btnAgregarRutina.Location = new Point(1000, 424);
            btnAgregarRutina.Margin = new Padding(3, 2, 3, 2);
            btnAgregarRutina.Name = "btnAgregarRutina";
            btnAgregarRutina.Size = new Size(133, 39);
            btnAgregarRutina.TabIndex = 0;
            btnAgregarRutina.Text = "➕ Agregar";
            btnAgregarRutina.UseVisualStyleBackColor = false;
            // 
            // btnConsultarRutina
            // 
            btnConsultarRutina.BackColor = Color.DodgerBlue;
            btnConsultarRutina.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold);
            btnConsultarRutina.ForeColor = Color.Black;
            btnConsultarRutina.Location = new Point(293, 424);
            btnConsultarRutina.Margin = new Padding(3, 2, 3, 2);
            btnConsultarRutina.Name = "btnConsultarRutina";
            btnConsultarRutina.Size = new Size(149, 39);
            btnConsultarRutina.TabIndex = 1;
            btnConsultarRutina.Text = "🔍 Consultar";
            btnConsultarRutina.UseVisualStyleBackColor = false;
            btnConsultarRutina.Click += btnConsultarRutina_Click_1;
            // 
            // btnEliminarRutina
            // 
            btnEliminarRutina.BackColor = Color.DodgerBlue;
            btnEliminarRutina.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold);
            btnEliminarRutina.ForeColor = Color.Black;
            btnEliminarRutina.Location = new Point(465, 424);
            btnEliminarRutina.Margin = new Padding(3, 2, 3, 2);
            btnEliminarRutina.Name = "btnEliminarRutina";
            btnEliminarRutina.Size = new Size(136, 39);
            btnEliminarRutina.TabIndex = 2;
            btnEliminarRutina.Text = "🗑️ Eliminar";
            btnEliminarRutina.UseVisualStyleBackColor = false;
            btnEliminarRutina.Click += btnEliminarRutina_Click;
            // 
            // lblGeneroRutina
            // 
            lblGeneroRutina.AutoSize = true;
            lblGeneroRutina.BackColor = Color.Transparent;
            lblGeneroRutina.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGeneroRutina.ForeColor = Color.Lavender;
            lblGeneroRutina.Location = new Point(809, 208);
            lblGeneroRutina.Name = "lblGeneroRutina";
            lblGeneroRutina.Size = new Size(134, 22);
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
            lblZonaRutina.Location = new Point(814, 257);
            lblZonaRutina.Name = "lblZonaRutina";
            lblZonaRutina.Size = new Size(110, 22);
            lblZonaRutina.TabIndex = 5;
            lblZonaRutina.Text = "Area Rutina";
            // 
            // cmbGeneroRutina
            // 
            cmbGeneroRutina.BackColor = Color.DodgerBlue;
            cmbGeneroRutina.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGeneroRutina.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            cmbGeneroRutina.FormattingEnabled = true;
            cmbGeneroRutina.Location = new Point(1000, 208);
            cmbGeneroRutina.Margin = new Padding(3, 2, 3, 2);
            cmbGeneroRutina.Name = "cmbGeneroRutina";
            cmbGeneroRutina.Size = new Size(260, 25);
            cmbGeneroRutina.TabIndex = 9;
            cmbGeneroRutina.SelectedIndexChanged += cmbGeneroRutina_SelectedIndexChanged;
            // 
            // dgvRutinas
            // 
            dgvRutinas.AllowUserToAddRows = false;
            dgvRutinas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvRutinas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvRutinas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRutinas.BackgroundColor = Color.Lavender;
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
            dgvRutinas.Location = new Point(37, 144);
            dgvRutinas.Margin = new Padding(3, 2, 3, 2);
            dgvRutinas.MultiSelect = false;
            dgvRutinas.Name = "dgvRutinas";
            dgvRutinas.ReadOnly = true;
            dgvRutinas.RowHeadersVisible = false;
            dgvRutinas.RowHeadersWidth = 51;
            dgvRutinas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRutinas.Size = new Size(706, 267);
            dgvRutinas.TabIndex = 5;
            // 
            // lblNombreRutina
            // 
            lblNombreRutina.AutoSize = true;
            lblNombreRutina.BackColor = Color.Transparent;
            lblNombreRutina.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreRutina.ForeColor = Color.Lavender;
            lblNombreRutina.Location = new Point(809, 164);
            lblNombreRutina.Name = "lblNombreRutina";
            lblNombreRutina.Size = new Size(165, 22);
            lblNombreRutina.TabIndex = 11;
            lblNombreRutina.Text = "Nombre de Rutina ";
            // 
            // txtNombreRutina
            // 
            txtNombreRutina.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            txtNombreRutina.Location = new Point(1000, 165);
            txtNombreRutina.Margin = new Padding(3, 2, 3, 2);
            txtNombreRutina.Name = "txtNombreRutina";
            txtNombreRutina.ShortcutsEnabled = false;
            txtNombreRutina.Size = new Size(260, 24);
            txtNombreRutina.TabIndex = 12;
            txtNombreRutina.TextChanged += txtNombreRutina_TextChanged;
            txtNombreRutina.KeyPress += txtNombreRutina_KeyPress;
            // 
            // cmbAreaRutina
            // 
            cmbAreaRutina.BackColor = Color.DodgerBlue;
            cmbAreaRutina.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAreaRutina.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            cmbAreaRutina.FormattingEnabled = true;
            cmbAreaRutina.Location = new Point(1000, 258);
            cmbAreaRutina.Margin = new Padding(3, 2, 3, 2);
            cmbAreaRutina.Name = "cmbAreaRutina";
            cmbAreaRutina.Size = new Size(260, 25);
            cmbAreaRutina.TabIndex = 13;
            // 
            // lblDuracion
            // 
            lblDuracion.AutoSize = true;
            lblDuracion.BackColor = Color.Transparent;
            lblDuracion.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDuracion.ForeColor = Color.Lavender;
            lblDuracion.Location = new Point(814, 296);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(128, 22);
            lblDuracion.TabIndex = 14;
            lblDuracion.Text = "Duracion(min)";
            lblDuracion.Click += lblDuracion_Click;
            // 
            // nudDuracion
            // 
            nudDuracion.Location = new Point(1074, 297);
            nudDuracion.Margin = new Padding(3, 2, 3, 2);
            nudDuracion.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            nudDuracion.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            nudDuracion.Name = "nudDuracion";
            nudDuracion.Size = new Size(131, 23);
            nudDuracion.TabIndex = 15;
            nudDuracion.Value = new decimal(new int[] { 10, 0, 0, 0 });
            nudDuracion.ValueChanged += nudDuracion_ValueChanged;
            // 
            // btnEditarRutina
            // 
            btnEditarRutina.BackColor = Color.DodgerBlue;
            btnEditarRutina.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold);
            btnEditarRutina.ForeColor = Color.Black;
            btnEditarRutina.Location = new Point(618, 424);
            btnEditarRutina.Margin = new Padding(3, 2, 3, 2);
            btnEditarRutina.Name = "btnEditarRutina";
            btnEditarRutina.Size = new Size(125, 39);
            btnEditarRutina.TabIndex = 16;
            btnEditarRutina.Text = "✏️ Editar";
            btnEditarRutina.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.image_removebg_preview__4_;
            pictureBox1.Location = new Point(557, 18);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(515, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // PicRutinaInicio
            // 
            PicRutinaInicio.BackColor = Color.Transparent;
            PicRutinaInicio.BackgroundImageLayout = ImageLayout.None;
            PicRutinaInicio.Image = Properties.Resources.image_removebg_preview__7_;
            PicRutinaInicio.Location = new Point(37, 76);
            PicRutinaInicio.Margin = new Padding(3, 2, 3, 2);
            PicRutinaInicio.Name = "PicRutinaInicio";
            PicRutinaInicio.Size = new Size(88, 63);
            PicRutinaInicio.SizeMode = PictureBoxSizeMode.Zoom;
            PicRutinaInicio.TabIndex = 21;
            PicRutinaInicio.TabStop = false;
            PicRutinaInicio.Click += PicRutinaInicio_Click;
            // 
            // btnLimpiar1
            // 
            btnLimpiar1.BackColor = Color.DodgerBlue;
            btnLimpiar1.Cursor = Cursors.Hand;
            btnLimpiar1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            btnLimpiar1.Location = new Point(852, 424);
            btnLimpiar1.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar1.Name = "btnLimpiar1";
            btnLimpiar1.Size = new Size(122, 39);
            btnLimpiar1.TabIndex = 30;
            btnLimpiar1.Text = "Limpiar";
            btnLimpiar1.UseVisualStyleBackColor = false;
            btnLimpiar1.Click += btnLimpiar1_Click;
            // 
            // RegistroRutina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 27, 27);
            ClientSize = new Size(1340, 500);
            Controls.Add(btnLimpiar1);
            Controls.Add(PicRutinaInicio);
            Controls.Add(pictureBox1);
            Controls.Add(btnEditarRutina);
            Controls.Add(nudDuracion);
            Controls.Add(lblDuracion);
            Controls.Add(cmbAreaRutina);
            Controls.Add(txtNombreRutina);
            Controls.Add(lblNombreRutina);
            Controls.Add(dgvRutinas);
            Controls.Add(cmbGeneroRutina);
            Controls.Add(lblZonaRutina);
            Controls.Add(lblGeneroRutina);
            Controls.Add(btnEliminarRutina);
            Controls.Add(btnConsultarRutina);
            Controls.Add(btnAgregarRutina);
            Cursor = Cursors.Hand;
            Margin = new Padding(3, 2, 3, 2);
            Name = "RegistroRutina";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistroRutina";
            Load += PicMem2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRutinas).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDuracion).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicRutinaInicio).EndInit();
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
        private Button btnLimpiar1;
    }
}