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
            dgvEquipo = new DataGridView();
            lblNombreEquipo = new Label();
            lblDescripcionEquipo = new Label();
            lblAreaUsoEquipo = new Label();
            lblFechaEntrega = new Label();
            lblPrecioEquipo = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btnAgregarEquipo = new Button();
            btnEliminarEquipo = new Button();
            btnEditarEquipo = new Button();
            btnConsultarEquipo = new Button();
            PicEquipoInicio = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEquipo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicEquipoInicio).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.image_removebg_preview__4_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(470, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(589, 162);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dgvEquipo
            // 
            dgvEquipo.AllowUserToAddRows = false;
            dgvEquipo.AllowUserToDeleteRows = false;
            dgvEquipo.BackgroundColor = Color.Black;
            dgvEquipo.BorderStyle = BorderStyle.None;
            dgvEquipo.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvEquipo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipo.EnableHeadersVisualStyles = false;
            dgvEquipo.GridColor = Color.DodgerBlue;
            dgvEquipo.Location = new Point(76, 201);
            dgvEquipo.MultiSelect = false;
            dgvEquipo.Name = "dgvEquipo";
            dgvEquipo.ReadOnly = true;
            dgvEquipo.RowHeadersVisible = false;
            dgvEquipo.RowHeadersWidth = 51;
            dgvEquipo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEquipo.Size = new Size(768, 372);
            dgvEquipo.TabIndex = 1;
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
            lblDescripcionEquipo.Click += lblDescripcionEquipo_Click;
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
            // textBox1
            // 
            textBox1.Location = new Point(1101, 279);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(199, 27);
            textBox1.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1048, 376);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(253, 28);
            comboBox1.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(1051, 426);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1048, 474);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(253, 27);
            textBox2.TabIndex = 10;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1032, 323);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(269, 27);
            textBox3.TabIndex = 11;
            // 
            // btnAgregarEquipo
            // 
            btnAgregarEquipo.BackColor = Color.DodgerBlue;
            btnAgregarEquipo.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold);
            btnAgregarEquipo.ForeColor = Color.Black;
            btnAgregarEquipo.Location = new Point(703, 590);
            btnAgregarEquipo.Name = "btnAgregarEquipo";
            btnAgregarEquipo.Size = new Size(141, 58);
            btnAgregarEquipo.TabIndex = 12;
            btnAgregarEquipo.Text = "Agregar";
            btnAgregarEquipo.UseVisualStyleBackColor = false;
            // 
            // btnEliminarEquipo
            // 
            btnEliminarEquipo.BackColor = Color.DodgerBlue;
            btnEliminarEquipo.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold);
            btnEliminarEquipo.ForeColor = Color.Black;
            btnEliminarEquipo.Location = new Point(536, 590);
            btnEliminarEquipo.Name = "btnEliminarEquipo";
            btnEliminarEquipo.Size = new Size(149, 56);
            btnEliminarEquipo.TabIndex = 13;
            btnEliminarEquipo.Text = "Eliminar";
            btnEliminarEquipo.UseVisualStyleBackColor = false;
            // 
            // btnEditarEquipo
            // 
            btnEditarEquipo.BackColor = Color.DodgerBlue;
            btnEditarEquipo.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold);
            btnEditarEquipo.Location = new Point(363, 590);
            btnEditarEquipo.Name = "btnEditarEquipo";
            btnEditarEquipo.Size = new Size(153, 56);
            btnEditarEquipo.TabIndex = 14;
            btnEditarEquipo.Text = "Editar";
            btnEditarEquipo.UseVisualStyleBackColor = false;
            // 
            // btnConsultarEquipo
            // 
            btnConsultarEquipo.BackColor = Color.DodgerBlue;
            btnConsultarEquipo.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold);
            btnConsultarEquipo.Location = new Point(195, 590);
            btnConsultarEquipo.Name = "btnConsultarEquipo";
            btnConsultarEquipo.Size = new Size(147, 56);
            btnConsultarEquipo.TabIndex = 15;
            btnConsultarEquipo.Text = "Consultar";
            btnConsultarEquipo.UseVisualStyleBackColor = false;
            // 
            // PicEquipoInicio
            // 
            PicEquipoInicio.BackColor = Color.Transparent;
            PicEquipoInicio.BackgroundImage = Properties.Resources.image_removebg_preview__7_;
            PicEquipoInicio.BackgroundImageLayout = ImageLayout.Zoom;
            PicEquipoInicio.Location = new Point(79, 130);
            PicEquipoInicio.Name = "PicEquipoInicio";
            PicEquipoInicio.Size = new Size(125, 62);
            PicEquipoInicio.TabIndex = 16;
            PicEquipoInicio.TabStop = false;
            PicEquipoInicio.Click += PicEquipoInicio_Click;
            // 
            // RegistroEquipo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design__13_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1415, 741);
            Controls.Add(PicEquipoInicio);
            Controls.Add(btnConsultarEquipo);
            Controls.Add(btnEditarEquipo);
            Controls.Add(btnEliminarEquipo);
            Controls.Add(btnAgregarEquipo);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(lblPrecioEquipo);
            Controls.Add(lblFechaEntrega);
            Controls.Add(lblAreaUsoEquipo);
            Controls.Add(lblDescripcionEquipo);
            Controls.Add(lblNombreEquipo);
            Controls.Add(dgvEquipo);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "RegistroEquipo";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEquipo).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicEquipoInicio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView dgvEquipo;
        private Label lblNombreEquipo;
        private Label lblDescripcionEquipo;
        private Label lblAreaUsoEquipo;
        private Label lblFechaEntrega;
        private Label lblPrecioEquipo;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnAgregarEquipo;
        private Button btnEliminarEquipo;
        private Button btnEditarEquipo;
        private Button btnConsultarEquipo;
        private PictureBox PicEquipoInicio;
    }
}