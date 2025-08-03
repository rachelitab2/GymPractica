namespace GymPresentacion
{
    partial class RegistroEntrenadores
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dgvEntrenadores = new DataGridView();
            btnConsultar = new Button();
            btnEditarEntrenador = new Button();
            btnEliminarEntrenador = new Button();
            btnAgregarEntrenador = new Button();
            checkDisponible = new CheckBox();
            cmbGeneroEntrenador = new ComboBox();
            cmbAreaEntrenador = new ComboBox();
            lblNombreEntrenador = new Label();
            lblGeneroEntrendor = new Label();
            lblAreaEntrenador = new Label();
            lblTelefono = new Label();
            PicMem2 = new PictureBox();
            maskedTextBox1 = new MaskedTextBox();
            txtNombreEntrenador = new TextBox();
            dtpIngresoEntrenador = new DateTimePicker();
            lblIngresoEntrenador = new Label();
            PicRutinaEntrenador = new PictureBox();
            lblDuracion = new Label();
            nudDuracion = new NumericUpDown();
            pictureBox1 = new PictureBox();
            PicEntrenadorInicio = new PictureBox();
            lblSalario = new Label();
            nudSalario = new NumericUpDown();
            checkCorreoEntrenador = new CheckBox();
            lblCorreoEntrenador = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvEntrenadores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicMem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicRutinaEntrenador).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDuracion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicEntrenadorInicio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSalario).BeginInit();
            SuspendLayout();
            // 
            // dgvEntrenadores
            // 
            dgvEntrenadores.AllowUserToAddRows = false;
            dgvEntrenadores.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.White;
            dgvEntrenadores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvEntrenadores.BackgroundColor = Color.Lavender;
            dgvEntrenadores.BorderStyle = BorderStyle.None;
            dgvEntrenadores.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.Black;
            dataGridViewCellStyle5.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvEntrenadores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvEntrenadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.DodgerBlue;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvEntrenadores.DefaultCellStyle = dataGridViewCellStyle6;
            dgvEntrenadores.EnableHeadersVisualStyles = false;
            dgvEntrenadores.GridColor = Color.DodgerBlue;
            dgvEntrenadores.Location = new Point(119, 180);
            dgvEntrenadores.MultiSelect = false;
            dgvEntrenadores.Name = "dgvEntrenadores";
            dgvEntrenadores.ReadOnly = true;
            dgvEntrenadores.RowHeadersVisible = false;
            dgvEntrenadores.RowHeadersWidth = 51;
            dgvEntrenadores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEntrenadores.Size = new Size(841, 465);
            dgvEntrenadores.TabIndex = 5;
            dgvEntrenadores.CellContentClick += dgvEntrenadores_CellContentClick;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.DodgerBlue;
            btnConsultar.Cursor = Cursors.Hand;
            btnConsultar.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold);
            btnConsultar.ForeColor = Color.Black;
            btnConsultar.Location = new Point(303, 656);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(167, 61);
            btnConsultar.TabIndex = 1;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            // 
            // btnEditarEntrenador
            // 
            btnEditarEntrenador.BackColor = Color.DodgerBlue;
            btnEditarEntrenador.Cursor = Cursors.Hand;
            btnEditarEntrenador.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold);
            btnEditarEntrenador.ForeColor = Color.Black;
            btnEditarEntrenador.Location = new Point(475, 656);
            btnEditarEntrenador.Name = "btnEditarEntrenador";
            btnEditarEntrenador.Size = new Size(160, 61);
            btnEditarEntrenador.TabIndex = 2;
            btnEditarEntrenador.Text = "Editar";
            btnEditarEntrenador.UseVisualStyleBackColor = false;
            // 
            // btnEliminarEntrenador
            // 
            btnEliminarEntrenador.BackColor = Color.DodgerBlue;
            btnEliminarEntrenador.Cursor = Cursors.Hand;
            btnEliminarEntrenador.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarEntrenador.ForeColor = Color.Black;
            btnEliminarEntrenador.Location = new Point(641, 656);
            btnEliminarEntrenador.Name = "btnEliminarEntrenador";
            btnEliminarEntrenador.Size = new Size(160, 59);
            btnEliminarEntrenador.TabIndex = 3;
            btnEliminarEntrenador.Text = "Eliminar";
            btnEliminarEntrenador.UseVisualStyleBackColor = false;
            btnEliminarEntrenador.Click += button3_Click;
            // 
            // btnAgregarEntrenador
            // 
            btnAgregarEntrenador.BackColor = Color.DodgerBlue;
            btnAgregarEntrenador.Cursor = Cursors.Hand;
            btnAgregarEntrenador.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarEntrenador.ForeColor = Color.Black;
            btnAgregarEntrenador.Location = new Point(806, 654);
            btnAgregarEntrenador.Name = "btnAgregarEntrenador";
            btnAgregarEntrenador.Size = new Size(154, 60);
            btnAgregarEntrenador.TabIndex = 4;
            btnAgregarEntrenador.Text = "Agregar";
            btnAgregarEntrenador.UseVisualStyleBackColor = false;
            // 
            // checkDisponible
            // 
            checkDisponible.AutoSize = true;
            checkDisponible.BackColor = Color.Lavender;
            checkDisponible.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            checkDisponible.Location = new Point(1046, 622);
            checkDisponible.Name = "checkDisponible";
            checkDisponible.Size = new Size(171, 31);
            checkDisponible.TabIndex = 5;
            checkDisponible.Text = "Disponibilidad";
            checkDisponible.UseVisualStyleBackColor = false;
            checkDisponible.CheckedChanged += checkDisponible_CheckedChanged;
            // 
            // cmbGeneroEntrenador
            // 
            cmbGeneroEntrenador.FormattingEnabled = true;
            cmbGeneroEntrenador.Location = new Point(1198, 242);
            cmbGeneroEntrenador.Name = "cmbGeneroEntrenador";
            cmbGeneroEntrenador.Size = new Size(301, 28);
            cmbGeneroEntrenador.TabIndex = 6;
            // 
            // cmbAreaEntrenador
            // 
            cmbAreaEntrenador.FormattingEnabled = true;
            cmbAreaEntrenador.Location = new Point(1198, 294);
            cmbAreaEntrenador.Name = "cmbAreaEntrenador";
            cmbAreaEntrenador.Size = new Size(301, 28);
            cmbAreaEntrenador.TabIndex = 7;
            cmbAreaEntrenador.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // lblNombreEntrenador
            // 
            lblNombreEntrenador.AutoSize = true;
            lblNombreEntrenador.BackColor = Color.Transparent;
            lblNombreEntrenador.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreEntrenador.ForeColor = Color.Lavender;
            lblNombreEntrenador.Location = new Point(1018, 189);
            lblNombreEntrenador.Name = "lblNombreEntrenador";
            lblNombreEntrenador.Size = new Size(100, 25);
            lblNombreEntrenador.TabIndex = 8;
            lblNombreEntrenador.Text = "Nombre ";
            // 
            // lblGeneroEntrendor
            // 
            lblGeneroEntrendor.AutoSize = true;
            lblGeneroEntrendor.BackColor = Color.Transparent;
            lblGeneroEntrendor.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGeneroEntrendor.ForeColor = Color.Lavender;
            lblGeneroEntrendor.Location = new Point(1021, 241);
            lblGeneroEntrendor.Name = "lblGeneroEntrendor";
            lblGeneroEntrendor.Size = new Size(87, 25);
            lblGeneroEntrendor.TabIndex = 9;
            lblGeneroEntrendor.Text = "Genero";
            lblGeneroEntrendor.Click += lblGeneroEntrendor_Click;
            // 
            // lblAreaEntrenador
            // 
            lblAreaEntrenador.AutoSize = true;
            lblAreaEntrenador.BackColor = Color.Transparent;
            lblAreaEntrenador.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAreaEntrenador.ForeColor = Color.Lavender;
            lblAreaEntrenador.Location = new Point(1021, 297);
            lblAreaEntrenador.Name = "lblAreaEntrenador";
            lblAreaEntrenador.Size = new Size(61, 25);
            lblAreaEntrenador.TabIndex = 10;
            lblAreaEntrenador.Text = "Area";
            lblAreaEntrenador.Click += label3_Click;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.BackColor = Color.Transparent;
            lblTelefono.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefono.ForeColor = Color.Lavender;
            lblTelefono.Location = new Point(1021, 358);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(97, 25);
            lblTelefono.TabIndex = 11;
            lblTelefono.Text = "Telefono";
            // 
            // PicMem2
            // 
            PicMem2.BackColor = Color.Transparent;
            PicMem2.BackgroundImageLayout = ImageLayout.None;
            PicMem2.Cursor = Cursors.Hand;
            PicMem2.Image = Properties.Resources.image_removebg_preview__3_;
            PicMem2.Location = new Point(210, 80);
            PicMem2.Name = "PicMem2";
            PicMem2.Size = new Size(100, 84);
            PicMem2.SizeMode = PictureBoxSizeMode.Zoom;
            PicMem2.TabIndex = 12;
            PicMem2.TabStop = false;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Cursor = Cursors.Hand;
            maskedTextBox1.Location = new Point(1198, 359);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(301, 27);
            maskedTextBox1.TabIndex = 13;
            // 
            // txtNombreEntrenador
            // 
            txtNombreEntrenador.Cursor = Cursors.Hand;
            txtNombreEntrenador.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreEntrenador.Location = new Point(1198, 189);
            txtNombreEntrenador.Name = "txtNombreEntrenador";
            txtNombreEntrenador.ShortcutsEnabled = false;
            txtNombreEntrenador.Size = new Size(301, 27);
            txtNombreEntrenador.TabIndex = 14;
            txtNombreEntrenador.KeyPress += txtNombreEntrenador_KeyPress;
            // 
            // dtpIngresoEntrenador
            // 
            dtpIngresoEntrenador.CalendarFont = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpIngresoEntrenador.Format = DateTimePickerFormat.Short;
            dtpIngresoEntrenador.Location = new Point(1197, 414);
            dtpIngresoEntrenador.Name = "dtpIngresoEntrenador";
            dtpIngresoEntrenador.Size = new Size(301, 27);
            dtpIngresoEntrenador.TabIndex = 15;
            // 
            // lblIngresoEntrenador
            // 
            lblIngresoEntrenador.AutoSize = true;
            lblIngresoEntrenador.BackColor = Color.Transparent;
            lblIngresoEntrenador.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIngresoEntrenador.ForeColor = Color.Lavender;
            lblIngresoEntrenador.Location = new Point(1022, 414);
            lblIngresoEntrenador.Name = "lblIngresoEntrenador";
            lblIngresoEntrenador.Size = new Size(156, 25);
            lblIngresoEntrenador.TabIndex = 16;
            lblIngresoEntrenador.Text = "Fecha Ingreso";
            // 
            // PicRutinaEntrenador
            // 
            PicRutinaEntrenador.BackColor = Color.Transparent;
            PicRutinaEntrenador.BackgroundImageLayout = ImageLayout.None;
            PicRutinaEntrenador.Cursor = Cursors.Hand;
            PicRutinaEntrenador.Image = Properties.Resources.image_removebg_preview__5_;
            PicRutinaEntrenador.Location = new Point(303, 80);
            PicRutinaEntrenador.Name = "PicRutinaEntrenador";
            PicRutinaEntrenador.Size = new Size(100, 84);
            PicRutinaEntrenador.SizeMode = PictureBoxSizeMode.Zoom;
            PicRutinaEntrenador.TabIndex = 17;
            PicRutinaEntrenador.TabStop = false;
            // 
            // lblDuracion
            // 
            lblDuracion.AutoSize = true;
            lblDuracion.BackColor = Color.Transparent;
            lblDuracion.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDuracion.ForeColor = Color.Lavender;
            lblDuracion.Location = new Point(1021, 461);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(105, 25);
            lblDuracion.TabIndex = 18;
            lblDuracion.Text = "Duracion";
            // 
            // nudDuracion
            // 
            nudDuracion.Location = new Point(1197, 463);
            nudDuracion.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            nudDuracion.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            nudDuracion.Name = "nudDuracion";
            nudDuracion.ReadOnly = true;
            nudDuracion.Size = new Size(301, 27);
            nudDuracion.TabIndex = 19;
            nudDuracion.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = Properties.Resources.image_removebg_preview__4_;
            pictureBox1.Location = new Point(637, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(589, 162);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // PicEntrenadorInicio
            // 
            PicEntrenadorInicio.BackColor = Color.Transparent;
            PicEntrenadorInicio.BackgroundImageLayout = ImageLayout.None;
            PicEntrenadorInicio.Cursor = Cursors.Hand;
            PicEntrenadorInicio.Image = Properties.Resources.image_removebg_preview__7_;
            PicEntrenadorInicio.Location = new Point(119, 80);
            PicEntrenadorInicio.Name = "PicEntrenadorInicio";
            PicEntrenadorInicio.Size = new Size(100, 84);
            PicEntrenadorInicio.TabIndex = 21;
            PicEntrenadorInicio.TabStop = false;
            PicEntrenadorInicio.Click += PicEntrenadorInicio_Click;
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.BackColor = Color.Transparent;
            lblSalario.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalario.ForeColor = Color.Lavender;
            lblSalario.Location = new Point(1018, 513);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(81, 25);
            lblSalario.TabIndex = 22;
            lblSalario.Text = "Salario";
            // 
            // nudSalario
            // 
            nudSalario.DecimalPlaces = 2;
            nudSalario.Location = new Point(1197, 515);
            nudSalario.Maximum = new decimal(new int[] { 30000, 0, 0, 0 });
            nudSalario.Name = "nudSalario";
            nudSalario.Size = new Size(150, 27);
            nudSalario.TabIndex = 23;
            nudSalario.ThousandsSeparator = true;
            // 
            // checkCorreoEntrenador
            // 
            checkCorreoEntrenador.AutoSize = true;
            checkCorreoEntrenador.BackColor = Color.Lavender;
            checkCorreoEntrenador.Cursor = Cursors.Hand;
            checkCorreoEntrenador.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            checkCorreoEntrenador.Location = new Point(1265, 622);
            checkCorreoEntrenador.Name = "checkCorreoEntrenador";
            checkCorreoEntrenador.Size = new Size(160, 31);
            checkCorreoEntrenador.TabIndex = 24;
            checkCorreoEntrenador.Text = "Enviar Correo";
            checkCorreoEntrenador.UseVisualStyleBackColor = false;
            // 
            // lblCorreoEntrenador
            // 
            lblCorreoEntrenador.AutoSize = true;
            lblCorreoEntrenador.BackColor = Color.Transparent;
            lblCorreoEntrenador.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            lblCorreoEntrenador.ForeColor = Color.Lavender;
            lblCorreoEntrenador.Location = new Point(1015, 566);
            lblCorreoEntrenador.Name = "lblCorreoEntrenador";
            lblCorreoEntrenador.Size = new Size(84, 25);
            lblCorreoEntrenador.TabIndex = 25;
            lblCorreoEntrenador.Text = "Correo";
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(1198, 567);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(302, 27);
            textBox1.TabIndex = 26;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // RegistroEntrenadores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1647, 826);
            Controls.Add(textBox1);
            Controls.Add(lblCorreoEntrenador);
            Controls.Add(checkCorreoEntrenador);
            Controls.Add(nudSalario);
            Controls.Add(lblSalario);
            Controls.Add(PicEntrenadorInicio);
            Controls.Add(pictureBox1);
            Controls.Add(nudDuracion);
            Controls.Add(lblDuracion);
            Controls.Add(PicRutinaEntrenador);
            Controls.Add(lblIngresoEntrenador);
            Controls.Add(dtpIngresoEntrenador);
            Controls.Add(txtNombreEntrenador);
            Controls.Add(maskedTextBox1);
            Controls.Add(PicMem2);
            Controls.Add(lblTelefono);
            Controls.Add(lblAreaEntrenador);
            Controls.Add(lblGeneroEntrendor);
            Controls.Add(lblNombreEntrenador);
            Controls.Add(cmbAreaEntrenador);
            Controls.Add(cmbGeneroEntrenador);
            Controls.Add(checkDisponible);
            Controls.Add(btnAgregarEntrenador);
            Controls.Add(btnEliminarEntrenador);
            Controls.Add(btnEditarEntrenador);
            Controls.Add(btnConsultar);
            Controls.Add(dgvEntrenadores);
            DoubleBuffered = true;
            Name = "RegistroEntrenadores";
            Text = "Form2";
            Load += Form2Entrenadores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEntrenadores).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicMem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicRutinaEntrenador).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDuracion).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicEntrenadorInicio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSalario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEntrenadores;
        private Button btnConsultar;
        private Button btnEditarEntrenador;
        private Button btnEliminarEntrenador;
        private Button btnAgregarEntrenador;
        private CheckBox checkDisponible;
        private ComboBox cmbGeneroEntrenador;
        private ComboBox cmbAreaEntrenador;
        private Label lblNombreEntrenador;
        private Label lblGeneroEntrendor;
        private Label lblAreaEntrenador;
        private Label lblTelefono;
        private PictureBox PicMem2;
        private MaskedTextBox maskedTextBox1;
        private TextBox txtNombreEntrenador;
        private DateTimePicker dtpIngresoEntrenador;
        private Label lblIngresoEntrenador;
        private PictureBox PicRutinaEntrenador;
        private Label lblDuracion;
        private NumericUpDown nudDuracion;
        private PictureBox pictureBox1;
        private PictureBox PicEntrenadorInicio;
        private Label lblSalario;
        private NumericUpDown nudSalario;
        private CheckBox checkCorreoEntrenador;
        private Label lblCorreoEntrenador;
        private TextBox textBox1;
    }
}