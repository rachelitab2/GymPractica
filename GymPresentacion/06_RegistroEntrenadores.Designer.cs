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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            maskedTextBox1 = new MaskedTextBox();
            txtNombreEntrenador = new TextBox();
            dtpIngresoEntrenador = new DateTimePicker();
            lblIngresoEntrenador = new Label();
            lblDuracion = new Label();
            nudDuracion = new NumericUpDown();
            pictureBox1 = new PictureBox();
            PicEntrenadorInicio = new PictureBox();
            lblSalario = new Label();
            nudSalario = new NumericUpDown();
            chkEnviarCorreo = new CheckBox();
            lblCorreoEntrenador = new Label();
            txtCorreoEntrenador = new TextBox();
            btnLimpiar1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEntrenadores).BeginInit();
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
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvEntrenadores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvEntrenadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEntrenadores.BackgroundColor = Color.Lavender;
            dgvEntrenadores.BorderStyle = BorderStyle.None;
            dgvEntrenadores.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvEntrenadores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvEntrenadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvEntrenadores.DefaultCellStyle = dataGridViewCellStyle3;
            dgvEntrenadores.EnableHeadersVisualStyles = false;
            dgvEntrenadores.GridColor = Color.DodgerBlue;
            dgvEntrenadores.Location = new Point(104, 142);
            dgvEntrenadores.Margin = new Padding(3, 2, 3, 2);
            dgvEntrenadores.MultiSelect = false;
            dgvEntrenadores.Name = "dgvEntrenadores";
            dgvEntrenadores.ReadOnly = true;
            dgvEntrenadores.RowHeadersVisible = false;
            dgvEntrenadores.RowHeadersWidth = 51;
            dgvEntrenadores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEntrenadores.Size = new Size(736, 325);
            dgvEntrenadores.TabIndex = 5;
            dgvEntrenadores.CellContentClick += dgvEntrenadores_CellContentClick;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.DodgerBlue;
            btnConsultar.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold);
            btnConsultar.ForeColor = Color.Black;
            btnConsultar.Location = new Point(247, 478);
            btnConsultar.Margin = new Padding(3, 2, 3, 2);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(146, 46);
            btnConsultar.TabIndex = 1;
            btnConsultar.Text = "🔍 Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            // 
            // btnEditarEntrenador
            // 
            btnEditarEntrenador.BackColor = Color.DodgerBlue;
            btnEditarEntrenador.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold);
            btnEditarEntrenador.ForeColor = Color.Black;
            btnEditarEntrenador.Location = new Point(557, 478);
            btnEditarEntrenador.Margin = new Padding(3, 2, 3, 2);
            btnEditarEntrenador.Name = "btnEditarEntrenador";
            btnEditarEntrenador.Size = new Size(140, 46);
            btnEditarEntrenador.TabIndex = 2;
            btnEditarEntrenador.Text = "✏️ Editar";
            btnEditarEntrenador.UseVisualStyleBackColor = false;
            // 
            // btnEliminarEntrenador
            // 
            btnEliminarEntrenador.BackColor = Color.DodgerBlue;
            btnEliminarEntrenador.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarEntrenador.ForeColor = Color.Black;
            btnEliminarEntrenador.Location = new Point(411, 479);
            btnEliminarEntrenador.Margin = new Padding(3, 2, 3, 2);
            btnEliminarEntrenador.Name = "btnEliminarEntrenador";
            btnEliminarEntrenador.Size = new Size(140, 44);
            btnEliminarEntrenador.TabIndex = 3;
            btnEliminarEntrenador.Text = "🗑️ Eliminar";
            btnEliminarEntrenador.UseVisualStyleBackColor = false;
            btnEliminarEntrenador.Click += button3_Click;
            // 
            // btnAgregarEntrenador
            // 
            btnAgregarEntrenador.BackColor = Color.DodgerBlue;
            btnAgregarEntrenador.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarEntrenador.ForeColor = Color.Black;
            btnAgregarEntrenador.Location = new Point(705, 478);
            btnAgregarEntrenador.Margin = new Padding(3, 2, 3, 2);
            btnAgregarEntrenador.Name = "btnAgregarEntrenador";
            btnAgregarEntrenador.Size = new Size(135, 45);
            btnAgregarEntrenador.TabIndex = 4;
            btnAgregarEntrenador.Text = "➕ Agregar";
            btnAgregarEntrenador.UseVisualStyleBackColor = false;
            btnAgregarEntrenador.Click += btnAgregarEntrenador_Click_1;
            // 
            // checkDisponible
            // 
            checkDisponible.AutoSize = true;
            checkDisponible.BackColor = Color.Lavender;
            checkDisponible.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            checkDisponible.Location = new Point(915, 466);
            checkDisponible.Margin = new Padding(3, 2, 3, 2);
            checkDisponible.Name = "checkDisponible";
            checkDisponible.Size = new Size(141, 26);
            checkDisponible.TabIndex = 5;
            checkDisponible.Text = "Disponibilidad";
            checkDisponible.UseVisualStyleBackColor = false;
            checkDisponible.CheckedChanged += checkDisponible_CheckedChanged;
            // 
            // cmbGeneroEntrenador
            // 
            cmbGeneroEntrenador.BackColor = Color.DodgerBlue;
            cmbGeneroEntrenador.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGeneroEntrenador.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            cmbGeneroEntrenador.ForeColor = Color.Black;
            cmbGeneroEntrenador.FormattingEnabled = true;
            cmbGeneroEntrenador.Location = new Point(1048, 182);
            cmbGeneroEntrenador.Margin = new Padding(3, 2, 3, 2);
            cmbGeneroEntrenador.Name = "cmbGeneroEntrenador";
            cmbGeneroEntrenador.Size = new Size(264, 25);
            cmbGeneroEntrenador.TabIndex = 6;
            // 
            // cmbAreaEntrenador
            // 
            cmbAreaEntrenador.BackColor = Color.DodgerBlue;
            cmbAreaEntrenador.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAreaEntrenador.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            cmbAreaEntrenador.FormattingEnabled = true;
            cmbAreaEntrenador.Location = new Point(1048, 220);
            cmbAreaEntrenador.Margin = new Padding(3, 2, 3, 2);
            cmbAreaEntrenador.Name = "cmbAreaEntrenador";
            cmbAreaEntrenador.Size = new Size(264, 25);
            cmbAreaEntrenador.TabIndex = 7;
            cmbAreaEntrenador.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // lblNombreEntrenador
            // 
            lblNombreEntrenador.AutoSize = true;
            lblNombreEntrenador.BackColor = Color.Transparent;
            lblNombreEntrenador.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreEntrenador.ForeColor = Color.Lavender;
            lblNombreEntrenador.Location = new Point(891, 142);
            lblNombreEntrenador.Name = "lblNombreEntrenador";
            lblNombreEntrenador.Size = new Size(81, 22);
            lblNombreEntrenador.TabIndex = 8;
            lblNombreEntrenador.Text = "Nombre ";
            // 
            // lblGeneroEntrendor
            // 
            lblGeneroEntrendor.AutoSize = true;
            lblGeneroEntrendor.BackColor = Color.Transparent;
            lblGeneroEntrendor.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGeneroEntrendor.ForeColor = Color.Lavender;
            lblGeneroEntrendor.Location = new Point(893, 181);
            lblGeneroEntrendor.Name = "lblGeneroEntrendor";
            lblGeneroEntrendor.Size = new Size(71, 22);
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
            lblAreaEntrenador.Location = new Point(893, 223);
            lblAreaEntrenador.Name = "lblAreaEntrenador";
            lblAreaEntrenador.Size = new Size(50, 22);
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
            lblTelefono.Location = new Point(893, 268);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(80, 22);
            lblTelefono.TabIndex = 11;
            lblTelefono.Text = "Telefono";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            maskedTextBox1.Location = new Point(1048, 269);
            maskedTextBox1.Margin = new Padding(3, 2, 3, 2);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(264, 24);
            maskedTextBox1.TabIndex = 13;
            // 
            // txtNombreEntrenador
            // 
            txtNombreEntrenador.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            txtNombreEntrenador.Location = new Point(1048, 142);
            txtNombreEntrenador.Margin = new Padding(3, 2, 3, 2);
            txtNombreEntrenador.Name = "txtNombreEntrenador";
            txtNombreEntrenador.ShortcutsEnabled = false;
            txtNombreEntrenador.Size = new Size(264, 24);
            txtNombreEntrenador.TabIndex = 14;
            txtNombreEntrenador.KeyPress += txtNombreEntrenador_KeyPress;
            // 
            // dtpIngresoEntrenador
            // 
            dtpIngresoEntrenador.CalendarFont = new Font("Verdana", 10.2F, FontStyle.Bold);
            dtpIngresoEntrenador.Format = DateTimePickerFormat.Short;
            dtpIngresoEntrenador.Location = new Point(1047, 310);
            dtpIngresoEntrenador.Margin = new Padding(3, 2, 3, 2);
            dtpIngresoEntrenador.Name = "dtpIngresoEntrenador";
            dtpIngresoEntrenador.Size = new Size(264, 23);
            dtpIngresoEntrenador.TabIndex = 15;
            // 
            // lblIngresoEntrenador
            // 
            lblIngresoEntrenador.AutoSize = true;
            lblIngresoEntrenador.BackColor = Color.Transparent;
            lblIngresoEntrenador.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIngresoEntrenador.ForeColor = Color.Lavender;
            lblIngresoEntrenador.Location = new Point(894, 310);
            lblIngresoEntrenador.Name = "lblIngresoEntrenador";
            lblIngresoEntrenador.Size = new Size(127, 22);
            lblIngresoEntrenador.TabIndex = 16;
            lblIngresoEntrenador.Text = "Fecha Ingreso";
            // 
            // lblDuracion
            // 
            lblDuracion.AutoSize = true;
            lblDuracion.BackColor = Color.Transparent;
            lblDuracion.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDuracion.ForeColor = Color.Lavender;
            lblDuracion.Location = new Point(893, 346);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(86, 22);
            lblDuracion.TabIndex = 18;
            lblDuracion.Text = "Duracion";
            // 
            // nudDuracion
            // 
            nudDuracion.Cursor = Cursors.Hand;
            nudDuracion.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            nudDuracion.Location = new Point(1047, 347);
            nudDuracion.Margin = new Padding(3, 2, 3, 2);
            nudDuracion.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            nudDuracion.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            nudDuracion.Name = "nudDuracion";
            nudDuracion.ReadOnly = true;
            nudDuracion.Size = new Size(263, 29);
            nudDuracion.TabIndex = 19;
            nudDuracion.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = Properties.Resources.image_removebg_preview__4_;
            pictureBox1.Location = new Point(557, 2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(515, 122);
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
            PicEntrenadorInicio.Location = new Point(104, 60);
            PicEntrenadorInicio.Margin = new Padding(3, 2, 3, 2);
            PicEntrenadorInicio.Name = "PicEntrenadorInicio";
            PicEntrenadorInicio.Size = new Size(88, 63);
            PicEntrenadorInicio.SizeMode = PictureBoxSizeMode.Zoom;
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
            lblSalario.Location = new Point(891, 385);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(69, 22);
            lblSalario.TabIndex = 22;
            lblSalario.Text = "Salario";
            // 
            // nudSalario
            // 
            nudSalario.Cursor = Cursors.SizeAll;
            nudSalario.DecimalPlaces = 2;
            nudSalario.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            nudSalario.Location = new Point(1047, 386);
            nudSalario.Margin = new Padding(3, 2, 3, 2);
            nudSalario.Maximum = new decimal(new int[] { 30000, 0, 0, 0 });
            nudSalario.Name = "nudSalario";
            nudSalario.Size = new Size(131, 29);
            nudSalario.TabIndex = 23;
            nudSalario.ThousandsSeparator = true;
            // 
            // chkEnviarCorreo
            // 
            chkEnviarCorreo.AutoSize = true;
            chkEnviarCorreo.BackColor = Color.Lavender;
            chkEnviarCorreo.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            chkEnviarCorreo.Location = new Point(1107, 466);
            chkEnviarCorreo.Margin = new Padding(3, 2, 3, 2);
            chkEnviarCorreo.Name = "chkEnviarCorreo";
            chkEnviarCorreo.Size = new Size(134, 26);
            chkEnviarCorreo.TabIndex = 24;
            chkEnviarCorreo.Text = "Enviar Correo";
            chkEnviarCorreo.UseVisualStyleBackColor = false;
            // 
            // lblCorreoEntrenador
            // 
            lblCorreoEntrenador.AutoSize = true;
            lblCorreoEntrenador.BackColor = Color.Transparent;
            lblCorreoEntrenador.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            lblCorreoEntrenador.ForeColor = Color.Lavender;
            lblCorreoEntrenador.Location = new Point(888, 424);
            lblCorreoEntrenador.Name = "lblCorreoEntrenador";
            lblCorreoEntrenador.Size = new Size(69, 22);
            lblCorreoEntrenador.TabIndex = 25;
            lblCorreoEntrenador.Text = "Correo";
            // 
            // txtCorreoEntrenador
            // 
            txtCorreoEntrenador.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            txtCorreoEntrenador.Location = new Point(1048, 425);
            txtCorreoEntrenador.Margin = new Padding(3, 2, 3, 2);
            txtCorreoEntrenador.Name = "txtCorreoEntrenador";
            txtCorreoEntrenador.Size = new Size(265, 24);
            txtCorreoEntrenador.TabIndex = 26;
            txtCorreoEntrenador.TextChanged += textBox1_TextChanged;
            // 
            // btnLimpiar1
            // 
            btnLimpiar1.BackColor = Color.DodgerBlue;
            btnLimpiar1.Cursor = Cursors.Hand;
            btnLimpiar1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            btnLimpiar1.Location = new Point(97, 479);
            btnLimpiar1.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar1.Name = "btnLimpiar1";
            btnLimpiar1.Size = new Size(133, 46);
            btnLimpiar1.TabIndex = 29;
            btnLimpiar1.Text = "Limpiar";
            btnLimpiar1.UseVisualStyleBackColor = false;
            btnLimpiar1.Click += btnLimpiar1_Click;
            // 
            // RegistroEntrenadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 27, 27);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1441, 620);
            Controls.Add(btnLimpiar1);
            Controls.Add(txtCorreoEntrenador);
            Controls.Add(lblCorreoEntrenador);
            Controls.Add(chkEnviarCorreo);
            Controls.Add(nudSalario);
            Controls.Add(lblSalario);
            Controls.Add(PicEntrenadorInicio);
            Controls.Add(pictureBox1);
            Controls.Add(nudDuracion);
            Controls.Add(lblDuracion);
            Controls.Add(lblIngresoEntrenador);
            Controls.Add(dtpIngresoEntrenador);
            Controls.Add(txtNombreEntrenador);
            Controls.Add(maskedTextBox1);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "RegistroEntrenadores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistroEntrenadores";
            Load += Form2Entrenadores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEntrenadores).EndInit();
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
        private MaskedTextBox maskedTextBox1;
        private TextBox txtNombreEntrenador;
        private DateTimePicker dtpIngresoEntrenador;
        private Label lblIngresoEntrenador;
        private Label lblDuracion;
        private NumericUpDown nudDuracion;
        private PictureBox pictureBox1;
        private PictureBox PicEntrenadorInicio;
        private Label lblSalario;
        private NumericUpDown nudSalario;
        private CheckBox chkEnviarCorreo;
        private Label lblCorreoEntrenador;
        private TextBox txtCorreoEntrenador;
        private Button btnLimpiar1;
    }
}