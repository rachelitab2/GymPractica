namespace GymPresentacion
{
    partial class RegistroEquipo
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
            dgvEquipos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            AreaUso = new DataGridViewTextBoxColumn();
            FechaEntrega = new DataGridViewTextBoxColumn();
            lblNombreEquipo = new Label();
            lblDescripcionEquipo = new Label();
            lblAreaUsoEquipo = new Label();
            lblFechaEntrega = new Label();
            lblPrecioEquipo = new Label();
            txtNombreEquipo = new TextBox();
            cmbAreaUso = new ComboBox();
            dtpFechaEntrega = new DateTimePicker();
            txtPrecioEquipo = new TextBox();
            txtDescripcion = new TextBox();
            btnAgregarEquipo = new Button();
            btnEliminarEquipo = new Button();
            btnEditarEquipo = new Button();
            btnConsultarEquipo = new Button();
            PicEquipoInicio = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicEquipoInicio).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.image_removebg_preview__4_;
            pictureBox1.Location = new Point(470, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(589, 163);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dgvEquipos
            // 
            dgvEquipos.AllowUserToAddRows = false;
            dgvEquipos.AllowUserToDeleteRows = false;
            dgvEquipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEquipos.BackgroundColor = Color.Lavender;
            dgvEquipos.BorderStyle = BorderStyle.None;
            dgvEquipos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipos.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Descripcion, Precio, AreaUso, FechaEntrega });
            dgvEquipos.EnableHeadersVisualStyles = false;
            dgvEquipos.GridColor = Color.DodgerBlue;
            dgvEquipos.Location = new Point(75, 201);
            dgvEquipos.MultiSelect = false;
            dgvEquipos.Name = "dgvEquipos";
            dgvEquipos.ReadOnly = true;
            dgvEquipos.RowHeadersVisible = false;
            dgvEquipos.RowHeadersWidth = 51;
            dgvEquipos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEquipos.Size = new Size(768, 372);
            dgvEquipos.TabIndex = 1;
            dgvEquipos.CellContentClick += dgvEquipos_CellContentClick;
            // 
            // Id
            // 
            Id.HeaderText = "ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripción\n";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // AreaUso
            // 
            AreaUso.HeaderText = "Área de Uso\n";
            AreaUso.MinimumWidth = 6;
            AreaUso.Name = "AreaUso";
            AreaUso.ReadOnly = true;
            // 
            // FechaEntrega
            // 
            FechaEntrega.HeaderText = "Fecha de Entrega\n\n";
            FechaEntrega.MinimumWidth = 6;
            FechaEntrega.Name = "FechaEntrega";
            FechaEntrega.ReadOnly = true;
            // 
            // lblNombreEquipo
            // 
            lblNombreEquipo.AutoSize = true;
            lblNombreEquipo.BackColor = Color.Transparent;
            lblNombreEquipo.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            lblNombreEquipo.ForeColor = Color.Lavender;
            lblNombreEquipo.Location = new Point(889, 281);
            lblNombreEquipo.Name = "lblNombreEquipo";
            lblNombreEquipo.Size = new Size(206, 25);
            lblNombreEquipo.TabIndex = 2;
            lblNombreEquipo.Text = "Nombre del Equipo";
            // 
            // lblDescripcionEquipo
            // 
            lblDescripcionEquipo.AutoSize = true;
            lblDescripcionEquipo.BackColor = Color.Transparent;
            lblDescripcionEquipo.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            lblDescripcionEquipo.ForeColor = Color.Lavender;
            lblDescripcionEquipo.Location = new Point(889, 325);
            lblDescripcionEquipo.Name = "lblDescripcionEquipo";
            lblDescripcionEquipo.Size = new Size(129, 25);
            lblDescripcionEquipo.TabIndex = 3;
            lblDescripcionEquipo.Text = "Descripcion";
            // 
            // lblAreaUsoEquipo
            // 
            lblAreaUsoEquipo.AutoSize = true;
            lblAreaUsoEquipo.BackColor = Color.Transparent;
            lblAreaUsoEquipo.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            lblAreaUsoEquipo.ForeColor = Color.Lavender;
            lblAreaUsoEquipo.Location = new Point(889, 376);
            lblAreaUsoEquipo.Name = "lblAreaUsoEquipo";
            lblAreaUsoEquipo.Size = new Size(135, 25);
            lblAreaUsoEquipo.TabIndex = 4;
            lblAreaUsoEquipo.Text = "Area de Uso";
            lblAreaUsoEquipo.Click += lblAreaUsoEquipo_Click;
            // 
            // lblFechaEntrega
            // 
            lblFechaEntrega.AutoSize = true;
            lblFechaEntrega.BackColor = Color.Transparent;
            lblFechaEntrega.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            lblFechaEntrega.ForeColor = Color.Lavender;
            lblFechaEntrega.Location = new Point(889, 428);
            lblFechaEntrega.Name = "lblFechaEntrega";
            lblFechaEntrega.Size = new Size(155, 25);
            lblFechaEntrega.TabIndex = 5;
            lblFechaEntrega.Text = "FechaEntrega";
            // 
            // lblPrecioEquipo
            // 
            lblPrecioEquipo.AutoSize = true;
            lblPrecioEquipo.BackColor = Color.Transparent;
            lblPrecioEquipo.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            lblPrecioEquipo.ForeColor = Color.Lavender;
            lblPrecioEquipo.Location = new Point(889, 476);
            lblPrecioEquipo.Name = "lblPrecioEquipo";
            lblPrecioEquipo.Size = new Size(153, 25);
            lblPrecioEquipo.TabIndex = 6;
            lblPrecioEquipo.Text = "Precio Equipo";
            lblPrecioEquipo.Click += lblPrecioEquipo_Click;
            // 
            // txtNombreEquipo
            // 
            txtNombreEquipo.Cursor = Cursors.Hand;
            txtNombreEquipo.Location = new Point(1101, 279);
            txtNombreEquipo.Name = "txtNombreEquipo";
            txtNombreEquipo.Size = new Size(199, 27);
            txtNombreEquipo.TabIndex = 7;
            txtNombreEquipo.TextChanged += txtNombreEquipo_TextChanged;
            // 
            // cmbAreaUso
            // 
            cmbAreaUso.Cursor = Cursors.Hand;
            cmbAreaUso.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAreaUso.FormattingEnabled = true;
            cmbAreaUso.Items.AddRange(new object[] { "Área de Pesas Libres", "Máquinas de Musculación", "Cardio", "Sala de Spinning", "Zona Funcional", "Área de Estiramiento", "Salón de Clases Grupales", "Yoga / Pilates", "Piscina", "Sanitario / Baños" });
            cmbAreaUso.Location = new Point(1048, 376);
            cmbAreaUso.Name = "cmbAreaUso";
            cmbAreaUso.Size = new Size(253, 28);
            cmbAreaUso.TabIndex = 8;
            cmbAreaUso.SelectedIndexChanged += cmbAreaUso_SelectedIndexChanged;
            // 
            // dtpFechaEntrega
            // 
            dtpFechaEntrega.Cursor = Cursors.Hand;
            dtpFechaEntrega.Location = new Point(1051, 427);
            dtpFechaEntrega.Name = "dtpFechaEntrega";
            dtpFechaEntrega.Size = new Size(250, 27);
            dtpFechaEntrega.TabIndex = 9;
            dtpFechaEntrega.ValueChanged += dtpFechaEntrega_ValueChanged;
            // 
            // txtPrecioEquipo
            // 
            txtPrecioEquipo.Cursor = Cursors.Hand;
            txtPrecioEquipo.Location = new Point(1048, 475);
            txtPrecioEquipo.Name = "txtPrecioEquipo";
            txtPrecioEquipo.Size = new Size(253, 27);
            txtPrecioEquipo.TabIndex = 10;
            txtPrecioEquipo.TextChanged += textBox2_TextChanged;
            txtPrecioEquipo.KeyPress += textBox2_KeyPress;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Cursor = Cursors.Hand;
            txtDescripcion.Location = new Point(1032, 323);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(269, 27);
            txtDescripcion.TabIndex = 11;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // btnAgregarEquipo
            // 
            btnAgregarEquipo.BackColor = Color.DodgerBlue;
            btnAgregarEquipo.Cursor = Cursors.Hand;
            btnAgregarEquipo.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold);
            btnAgregarEquipo.ForeColor = Color.Black;
            btnAgregarEquipo.Location = new Point(1151, 586);
            btnAgregarEquipo.Name = "btnAgregarEquipo";
            btnAgregarEquipo.Size = new Size(150, 59);
            btnAgregarEquipo.TabIndex = 12;
            btnAgregarEquipo.Text = "➕ Agregar";
            btnAgregarEquipo.UseVisualStyleBackColor = false;
            btnAgregarEquipo.Click += btnAgregarEquipo_Click;
            // 
            // btnEliminarEquipo
            // 
            btnEliminarEquipo.BackColor = Color.DodgerBlue;
            btnEliminarEquipo.Cursor = Cursors.Hand;
            btnEliminarEquipo.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold);
            btnEliminarEquipo.ForeColor = Color.Black;
            btnEliminarEquipo.Location = new Point(508, 589);
            btnEliminarEquipo.Name = "btnEliminarEquipo";
            btnEliminarEquipo.Size = new Size(163, 56);
            btnEliminarEquipo.TabIndex = 13;
            btnEliminarEquipo.Text = "🗑️ Eliminar";
            btnEliminarEquipo.UseVisualStyleBackColor = false;
            btnEliminarEquipo.Click += btnEliminarEquipo_Click;
            // 
            // btnEditarEquipo
            // 
            btnEditarEquipo.BackColor = Color.DodgerBlue;
            btnEditarEquipo.Cursor = Cursors.Hand;
            btnEditarEquipo.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold);
            btnEditarEquipo.Location = new Point(690, 589);
            btnEditarEquipo.Name = "btnEditarEquipo";
            btnEditarEquipo.Size = new Size(153, 56);
            btnEditarEquipo.TabIndex = 14;
            btnEditarEquipo.Text = "✏️ Editar";
            btnEditarEquipo.UseVisualStyleBackColor = false;
            btnEditarEquipo.Click += btnEditarEquipo_Click;
            // 
            // btnConsultarEquipo
            // 
            btnConsultarEquipo.BackColor = Color.DodgerBlue;
            btnConsultarEquipo.Cursor = Cursors.Hand;
            btnConsultarEquipo.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold);
            btnConsultarEquipo.Location = new Point(311, 589);
            btnConsultarEquipo.Name = "btnConsultarEquipo";
            btnConsultarEquipo.Size = new Size(166, 56);
            btnConsultarEquipo.TabIndex = 15;
            btnConsultarEquipo.Text = "🔍 Consultar";
            btnConsultarEquipo.UseVisualStyleBackColor = false;
            btnConsultarEquipo.Click += btnConsultarEquipo_Click;
            // 
            // PicEquipoInicio
            // 
            PicEquipoInicio.BackColor = Color.Transparent;
            PicEquipoInicio.BackgroundImageLayout = ImageLayout.None;
            PicEquipoInicio.Cursor = Cursors.Hand;
            PicEquipoInicio.Image = Properties.Resources.image_removebg_preview__7_;
            PicEquipoInicio.Location = new Point(79, 131);
            PicEquipoInicio.Name = "PicEquipoInicio";
            PicEquipoInicio.Size = new Size(125, 61);
            PicEquipoInicio.SizeMode = PictureBoxSizeMode.Zoom;
            PicEquipoInicio.TabIndex = 16;
            PicEquipoInicio.TabStop = false;
            PicEquipoInicio.Click += PicEquipoInicio_Click;
            // 
            // RegistroEquipo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 27, 27);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1415, 741);
            Controls.Add(PicEquipoInicio);
            Controls.Add(btnConsultarEquipo);
            Controls.Add(btnEditarEquipo);
            Controls.Add(btnEliminarEquipo);
            Controls.Add(btnAgregarEquipo);
            Controls.Add(txtDescripcion);
            Controls.Add(txtPrecioEquipo);
            Controls.Add(dtpFechaEntrega);
            Controls.Add(cmbAreaUso);
            Controls.Add(txtNombreEquipo);
            Controls.Add(lblPrecioEquipo);
            Controls.Add(lblFechaEntrega);
            Controls.Add(lblAreaUsoEquipo);
            Controls.Add(lblDescripcionEquipo);
            Controls.Add(lblNombreEquipo);
            Controls.Add(dgvEquipos);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "RegistroEquipo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistroEquipo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicEquipoInicio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView dgvEquipos;
        private Label lblNombreEquipo;
        private Label lblDescripcionEquipo;
        private Label lblAreaUsoEquipo;
        private Label lblFechaEntrega;
        private Label lblPrecioEquipo;
        private TextBox txtNombreEquipo;
        private ComboBox cmbAreaUso;
        private DateTimePicker dtpFechaEntrega;
        private TextBox txtPrecioEquipo;
        private TextBox txtDescripcion;
        private Button btnAgregarEquipo;
        private Button btnEliminarEquipo;
        private Button btnEditarEquipo;
        private Button btnConsultarEquipo;
        private PictureBox PicEquipoInicio;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn AreaUso;
        private DataGridViewTextBoxColumn FechaEntrega;
    }
}