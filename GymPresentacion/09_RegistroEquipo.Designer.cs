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
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            AreaUso = new DataGridViewTextBoxColumn();
            FechaEntrega = new DataGridViewTextBoxColumn();
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
            pictureBox1.Location = new Point(411, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(515, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dgvEquipos
            // 
            dgvEquipos.AllowUserToAddRows = false;
            dgvEquipos.AllowUserToDeleteRows = false;
            dgvEquipos.BackgroundColor = Color.Lavender;
            dgvEquipos.BorderStyle = BorderStyle.None;
            dgvEquipos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipos.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Descripcion, Precio, AreaUso, FechaEntrega });
            dgvEquipos.EnableHeadersVisualStyles = false;
            dgvEquipos.GridColor = Color.DodgerBlue;
            dgvEquipos.Location = new Point(66, 151);
            dgvEquipos.Margin = new Padding(3, 2, 3, 2);
            dgvEquipos.MultiSelect = false;
            dgvEquipos.Name = "dgvEquipos";
            dgvEquipos.ReadOnly = true;
            dgvEquipos.RowHeadersVisible = false;
            dgvEquipos.RowHeadersWidth = 51;
            dgvEquipos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEquipos.Size = new Size(672, 279);
            dgvEquipos.TabIndex = 1;
            dgvEquipos.CellContentClick += dgvEquipos_CellContentClick;
            // 
            // lblNombreEquipo
            // 
            lblNombreEquipo.AutoSize = true;
            lblNombreEquipo.BackColor = Color.Transparent;
            lblNombreEquipo.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            lblNombreEquipo.ForeColor = Color.Lavender;
            lblNombreEquipo.Location = new Point(778, 211);
            lblNombreEquipo.Name = "lblNombreEquipo";
            lblNombreEquipo.Size = new Size(168, 22);
            lblNombreEquipo.TabIndex = 2;
            lblNombreEquipo.Text = "Nombre del Equipo";
            // 
            // lblDescripcionEquipo
            // 
            lblDescripcionEquipo.AutoSize = true;
            lblDescripcionEquipo.BackColor = Color.Transparent;
            lblDescripcionEquipo.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            lblDescripcionEquipo.ForeColor = Color.Lavender;
            lblDescripcionEquipo.Location = new Point(778, 244);
            lblDescripcionEquipo.Name = "lblDescripcionEquipo";
            lblDescripcionEquipo.Size = new Size(107, 22);
            lblDescripcionEquipo.TabIndex = 3;
            lblDescripcionEquipo.Text = "Descripcion";
            // 
            // lblAreaUsoEquipo
            // 
            lblAreaUsoEquipo.AutoSize = true;
            lblAreaUsoEquipo.BackColor = Color.Transparent;
            lblAreaUsoEquipo.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            lblAreaUsoEquipo.ForeColor = Color.Lavender;
            lblAreaUsoEquipo.Location = new Point(778, 282);
            lblAreaUsoEquipo.Name = "lblAreaUsoEquipo";
            lblAreaUsoEquipo.Size = new Size(110, 22);
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
            lblFechaEntrega.Location = new Point(778, 321);
            lblFechaEntrega.Name = "lblFechaEntrega";
            lblFechaEntrega.Size = new Size(126, 22);
            lblFechaEntrega.TabIndex = 5;
            lblFechaEntrega.Text = "FechaEntrega";
            // 
            // lblPrecioEquipo
            // 
            lblPrecioEquipo.AutoSize = true;
            lblPrecioEquipo.BackColor = Color.Transparent;
            lblPrecioEquipo.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            lblPrecioEquipo.ForeColor = Color.Lavender;
            lblPrecioEquipo.Location = new Point(778, 357);
            lblPrecioEquipo.Name = "lblPrecioEquipo";
            lblPrecioEquipo.Size = new Size(126, 22);
            lblPrecioEquipo.TabIndex = 6;
            lblPrecioEquipo.Text = "Precio Equipo";
            lblPrecioEquipo.Click += lblPrecioEquipo_Click;
            // 
            // txtNombreEquipo
            // 
            txtNombreEquipo.Cursor = Cursors.Hand;
            txtNombreEquipo.Location = new Point(963, 209);
            txtNombreEquipo.Margin = new Padding(3, 2, 3, 2);
            txtNombreEquipo.Name = "txtNombreEquipo";
            txtNombreEquipo.Size = new Size(175, 23);
            txtNombreEquipo.TabIndex = 7;
            txtNombreEquipo.TextChanged += txtNombreEquipo_TextChanged;
            // 
            // cmbAreaUso
            // 
            cmbAreaUso.Cursor = Cursors.Hand;
            cmbAreaUso.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAreaUso.FormattingEnabled = true;
            cmbAreaUso.Items.AddRange(new object[] { "Área de Pesas Libres", "Máquinas de Musculación", "Cardio", "Sala de Spinning", "Zona Funcional", "Área de Estiramiento", "Salón de Clases Grupales", "Yoga / Pilates", "Piscina", "Sanitario / Baños" });
            cmbAreaUso.Location = new Point(917, 282);
            cmbAreaUso.Margin = new Padding(3, 2, 3, 2);
            cmbAreaUso.Name = "cmbAreaUso";
            cmbAreaUso.Size = new Size(222, 23);
            cmbAreaUso.TabIndex = 8;
            cmbAreaUso.SelectedIndexChanged += cmbAreaUso_SelectedIndexChanged;
            // 
            // dtpFechaEntrega
            // 
            dtpFechaEntrega.Cursor = Cursors.Hand;
            dtpFechaEntrega.Location = new Point(920, 320);
            dtpFechaEntrega.Margin = new Padding(3, 2, 3, 2);
            dtpFechaEntrega.Name = "dtpFechaEntrega";
            dtpFechaEntrega.Size = new Size(219, 23);
            dtpFechaEntrega.TabIndex = 9;
            dtpFechaEntrega.ValueChanged += dtpFechaEntrega_ValueChanged;
            // 
            // txtPrecioEquipo
            // 
            txtPrecioEquipo.Cursor = Cursors.Hand;
            txtPrecioEquipo.Location = new Point(917, 356);
            txtPrecioEquipo.Margin = new Padding(3, 2, 3, 2);
            txtPrecioEquipo.Name = "txtPrecioEquipo";
            txtPrecioEquipo.Size = new Size(222, 23);
            txtPrecioEquipo.TabIndex = 10;
            txtPrecioEquipo.TextChanged += textBox2_TextChanged;
            txtPrecioEquipo.KeyPress += textBox2_KeyPress;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Cursor = Cursors.Hand;
            txtDescripcion.Location = new Point(903, 242);
            txtDescripcion.Margin = new Padding(3, 2, 3, 2);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(236, 23);
            txtDescripcion.TabIndex = 11;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // btnAgregarEquipo
            // 
            btnAgregarEquipo.BackColor = Color.DodgerBlue;
            btnAgregarEquipo.Cursor = Cursors.Hand;
            btnAgregarEquipo.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold);
            btnAgregarEquipo.ForeColor = Color.Black;
            btnAgregarEquipo.Location = new Point(615, 442);
            btnAgregarEquipo.Margin = new Padding(3, 2, 3, 2);
            btnAgregarEquipo.Name = "btnAgregarEquipo";
            btnAgregarEquipo.Size = new Size(123, 44);
            btnAgregarEquipo.TabIndex = 12;
            btnAgregarEquipo.Text = "Agregar";
            btnAgregarEquipo.UseVisualStyleBackColor = false;
            btnAgregarEquipo.Click += btnAgregarEquipo_Click;
            // 
            // btnEliminarEquipo
            // 
            btnEliminarEquipo.BackColor = Color.DodgerBlue;
            btnEliminarEquipo.Cursor = Cursors.Hand;
            btnEliminarEquipo.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold);
            btnEliminarEquipo.ForeColor = Color.Black;
            btnEliminarEquipo.Location = new Point(469, 442);
            btnEliminarEquipo.Margin = new Padding(3, 2, 3, 2);
            btnEliminarEquipo.Name = "btnEliminarEquipo";
            btnEliminarEquipo.Size = new Size(130, 42);
            btnEliminarEquipo.TabIndex = 13;
            btnEliminarEquipo.Text = "Eliminar";
            btnEliminarEquipo.UseVisualStyleBackColor = false;
            btnEliminarEquipo.Click += btnEliminarEquipo_Click;
            // 
            // btnEditarEquipo
            // 
            btnEditarEquipo.BackColor = Color.DodgerBlue;
            btnEditarEquipo.Cursor = Cursors.Hand;
            btnEditarEquipo.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold);
            btnEditarEquipo.Location = new Point(318, 442);
            btnEditarEquipo.Margin = new Padding(3, 2, 3, 2);
            btnEditarEquipo.Name = "btnEditarEquipo";
            btnEditarEquipo.Size = new Size(134, 42);
            btnEditarEquipo.TabIndex = 14;
            btnEditarEquipo.Text = "Editar";
            btnEditarEquipo.UseVisualStyleBackColor = false;
            btnEditarEquipo.Click += btnEditarEquipo_Click;
            // 
            // btnConsultarEquipo
            // 
            btnConsultarEquipo.BackColor = Color.DodgerBlue;
            btnConsultarEquipo.Cursor = Cursors.Hand;
            btnConsultarEquipo.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold);
            btnConsultarEquipo.Location = new Point(171, 442);
            btnConsultarEquipo.Margin = new Padding(3, 2, 3, 2);
            btnConsultarEquipo.Name = "btnConsultarEquipo";
            btnConsultarEquipo.Size = new Size(129, 42);
            btnConsultarEquipo.TabIndex = 15;
            btnConsultarEquipo.Text = "Consultar";
            btnConsultarEquipo.UseVisualStyleBackColor = false;
            btnConsultarEquipo.Click += btnConsultarEquipo_Click;
            // 
            // PicEquipoInicio
            // 
            PicEquipoInicio.BackColor = Color.Transparent;
            PicEquipoInicio.BackgroundImageLayout = ImageLayout.None;
            PicEquipoInicio.Cursor = Cursors.Hand;
            PicEquipoInicio.Image = Properties.Resources.image_removebg_preview__7_;
            PicEquipoInicio.Location = new Point(69, 98);
            PicEquipoInicio.Margin = new Padding(3, 2, 3, 2);
            PicEquipoInicio.Name = "PicEquipoInicio";
            PicEquipoInicio.Size = new Size(109, 46);
            PicEquipoInicio.SizeMode = PictureBoxSizeMode.Zoom;
            PicEquipoInicio.TabIndex = 16;
            PicEquipoInicio.TabStop = false;
            PicEquipoInicio.Click += PicEquipoInicio_Click;
            // 
            // Id
            // 
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripción\n";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // AreaUso
            // 
            AreaUso.HeaderText = "Área de Uso\n";
            AreaUso.Name = "AreaUso";
            AreaUso.ReadOnly = true;
            // 
            // FechaEntrega
            // 
            FechaEntrega.HeaderText = "Fecha de Entrega\n\n";
            FechaEntrega.Name = "FechaEntrega";
            FechaEntrega.ReadOnly = true;
            // 
            // RegistroEquipo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1238, 556);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "RegistroEquipo";
            Text = "Form1";
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