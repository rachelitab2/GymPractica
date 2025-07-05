using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymNegocio;

namespace GymPresentacion

{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            lblName = new Label();
            lblCliente = new Label();
            btnEditar = new Button();
            btnEliminar = new Button();
            dataGridView1 = new DataGridView();
            txtNombreCliente = new TextBox();
            btnAgregar = new Button();
            lblFechaInicio = new Label();
            dateTimePickerInicio = new DateTimePicker();
            lblTelefono = new Label();
            cmbTipoMembresia = new ComboBox();
            mtxtTelefono = new MaskedTextBox();
            btnConsultar = new Button();
            PicEntrenadores = new PictureBox();
            PicRutinas = new PictureBox();
            pictureBox1 = new PictureBox();
            PicMemInicio = new PictureBox();
            ((ISupportInitialize)dataGridView1).BeginInit();
            ((ISupportInitialize)PicEntrenadores).BeginInit();
            ((ISupportInitialize)PicRutinas).BeginInit();
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)PicMemInicio).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.IndianRed;
            lblTitulo.Font = new Font("Perpetua Titling MT", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(701, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(304, 56);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GYMNASIO";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.IndianRed;
            lblName.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(1071, 224);
            lblName.Name = "lblName";
            lblName.Size = new Size(94, 25);
            lblName.TabIndex = 1;
            lblName.Text = "Nombre";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.BackColor = Color.IndianRed;
            lblCliente.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCliente.ForeColor = Color.White;
            lblCliente.Location = new Point(1071, 304);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(82, 25);
            lblCliente.TabIndex = 2;
            lblCliente.Text = "Cliente";
            lblCliente.Click += label3_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.IndianRed;
            btnEditar.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(607, 650);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(174, 62);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(831, 650);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(174, 62);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.IndianRed;
            dataGridViewCellStyle6.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.IndianRed;
            dataGridView1.Location = new Point(41, 191);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(974, 453);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.BackColor = Color.White;
            txtNombreCliente.Location = new Point(1216, 222);
            txtNombreCliente.MaxLength = 30;
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(296, 27);
            txtNombreCliente.TabIndex = 6;
            txtNombreCliente.TextChanged += txtNombreCliente_TextChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.IndianRed;
            btnAgregar.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(1224, 648);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(177, 62);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.BackColor = Color.IndianRed;
            lblFechaInicio.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaInicio.ForeColor = Color.White;
            lblFechaInicio.Location = new Point(1071, 389);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(129, 25);
            lblFechaInicio.TabIndex = 10;
            lblFechaInicio.Text = "FechaInicio";
            lblFechaInicio.Click += label4_Click;
            // 
            // dateTimePickerInicio
            // 
            dateTimePickerInicio.CalendarFont = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerInicio.CalendarMonthBackground = SystemColors.ActiveBorder;
            dateTimePickerInicio.Format = DateTimePickerFormat.Short;
            dateTimePickerInicio.Location = new Point(1216, 387);
            dateTimePickerInicio.Name = "dateTimePickerInicio";
            dateTimePickerInicio.Size = new Size(296, 27);
            dateTimePickerInicio.TabIndex = 12;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.BackColor = Color.IndianRed;
            lblTelefono.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefono.ForeColor = Color.White;
            lblTelefono.Location = new Point(1071, 472);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(97, 25);
            lblTelefono.TabIndex = 15;
            lblTelefono.Text = "Telefono";
            lblTelefono.Click += lblTelefono_Click;
            // 
            // cmbTipoMembresia
            // 
            cmbTipoMembresia.BackColor = Color.RosyBrown;
            cmbTipoMembresia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoMembresia.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbTipoMembresia.FormattingEnabled = true;
            cmbTipoMembresia.Location = new Point(1216, 304);
            cmbTipoMembresia.Name = "cmbTipoMembresia";
            cmbTipoMembresia.Size = new Size(296, 25);
            cmbTipoMembresia.TabIndex = 18;
            cmbTipoMembresia.SelectedIndexChanged += cmbTipoMembresia_SelectedIndexChanged;
            // 
            // mtxtTelefono
            // 
            mtxtTelefono.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtxtTelefono.Location = new Point(1224, 472);
            mtxtTelefono.Name = "mtxtTelefono";
            mtxtTelefono.Size = new Size(288, 25);
            mtxtTelefono.TabIndex = 19;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.IndianRed;
            btnConsultar.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultar.ForeColor = Color.White;
            btnConsultar.Location = new Point(374, 648);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(174, 64);
            btnConsultar.TabIndex = 20;
            btnConsultar.Text = "Consulta ";
            btnConsultar.UseVisualStyleBackColor = false;
            // 
            // PicEntrenadores
            // 
            PicEntrenadores.BackColor = Color.Transparent;
            PicEntrenadores.BackgroundImageLayout = ImageLayout.Stretch;
            PicEntrenadores.Cursor = Cursors.Hand;
            PicEntrenadores.Image = Properties.Resources._8;
            PicEntrenadores.Location = new Point(147, 101);
            PicEntrenadores.Name = "PicEntrenadores";
            PicEntrenadores.Size = new Size(96, 84);
            PicEntrenadores.SizeMode = PictureBoxSizeMode.Zoom;
            PicEntrenadores.TabIndex = 21;
            PicEntrenadores.TabStop = false;
            PicEntrenadores.Click += PicEntrenadores_Click;
            // 
            // PicRutinas
            // 
            PicRutinas.BackColor = Color.Transparent;
            PicRutinas.BackgroundImageLayout = ImageLayout.None;
            PicRutinas.Cursor = Cursors.Hand;
            PicRutinas.Image = Properties.Resources._9;
            PicRutinas.Location = new Point(249, 101);
            PicRutinas.Name = "PicRutinas";
            PicRutinas.Size = new Size(96, 84);
            PicRutinas.SizeMode = PictureBoxSizeMode.Zoom;
            PicRutinas.TabIndex = 22;
            PicRutinas.TabStop = false;
            PicRutinas.Click += PicRutinas_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Untitled_design__7_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(637, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(589, 162);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // PicMemInicio
            // 
            PicMemInicio.BackColor = Color.Transparent;
            PicMemInicio.BackgroundImage = Properties.Resources.Untitled_design__9_;
            PicMemInicio.BackgroundImageLayout = ImageLayout.Zoom;
            PicMemInicio.Cursor = Cursors.Hand;
            PicMemInicio.Location = new Point(41, 101);
            PicMemInicio.Name = "PicMemInicio";
            PicMemInicio.Size = new Size(100, 84);
            PicMemInicio.TabIndex = 24;
            PicMemInicio.TabStop = false;
            PicMemInicio.Click += PicMemInicio_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            BackgroundImage = Properties.Resources.Untitled_design__6_;
            ClientSize = new Size(1615, 810);
            Controls.Add(PicMemInicio);
            Controls.Add(pictureBox1);
            Controls.Add(PicRutinas);
            Controls.Add(PicEntrenadores);
            Controls.Add(btnConsultar);
            Controls.Add(mtxtTelefono);
            Controls.Add(cmbTipoMembresia);
            Controls.Add(lblTelefono);
            Controls.Add(dateTimePickerInicio);
            Controls.Add(lblFechaInicio);
            Controls.Add(btnAgregar);
            Controls.Add(txtNombreCliente);
            Controls.Add(dataGridView1);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(lblCliente);
            Controls.Add(lblName);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((ISupportInitialize)dataGridView1).EndInit();
            ((ISupportInitialize)PicEntrenadores).EndInit();
            ((ISupportInitialize)PicRutinas).EndInit();
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)PicMemInicio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblName;
        private Label lblCliente;
        private Button btnEditar;
        private Button btnEliminar;
        private DataGridView dataGridView1;
        private TextBox txtNombreCliente;
        private Button btnAgregar;
        private Label lblFechaInicio;
        private DateTimePicker dateTimePickerInicio;
        private Label lblTelefono;
        private TextBox txtTipoMembresia;
        private ComboBox cmbTipoMembresia;
        private MaskedTextBox mtxtTelefono;
        private Button btnConsultar;
        private PictureBox PicEntrenadores;
        private PictureBox PicRutinas;
        private PictureBox pictureBox1;
        private PictureBox PicMemInicio;
    }

 
}
