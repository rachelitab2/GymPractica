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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            ((ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Black;
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
            lblName.BackColor = Color.Black;
            lblName.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(1053, 148);
            lblName.Name = "lblName";
            lblName.Size = new Size(94, 25);
            lblName.TabIndex = 1;
            lblName.Text = "Nombre";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.BackColor = Color.Black;
            lblCliente.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCliente.ForeColor = Color.White;
            lblCliente.Location = new Point(1053, 224);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(82, 25);
            lblCliente.TabIndex = 2;
            lblCliente.Text = "Cliente";
            lblCliente.Click += label3_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Black;
            btnEditar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            btnEliminar.BackColor = Color.Black;
            btnEliminar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.ScrollBar;
            dataGridView1.Location = new Point(31, 105);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(974, 453);
            dataGridView1.TabIndex = 5;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.BackColor = Color.White;
            txtNombreCliente.Location = new Point(1216, 146);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(296, 27);
            txtNombreCliente.TabIndex = 6;
            txtNombreCliente.TextChanged += txtNombreCliente_TextChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Black;
            btnAgregar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(1372, 650);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(177, 62);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.BackColor = Color.Black;
            lblFechaInicio.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaInicio.ForeColor = Color.White;
            lblFechaInicio.Location = new Point(1053, 310);
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
            dateTimePickerInicio.Location = new Point(1255, 310);
            dateTimePickerInicio.Name = "dateTimePickerInicio";
            dateTimePickerInicio.Size = new Size(257, 27);
            dateTimePickerInicio.TabIndex = 12;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.BackColor = Color.Black;
            lblTelefono.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefono.ForeColor = Color.White;
            lblTelefono.Location = new Point(1053, 394);
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
            cmbTipoMembresia.FormattingEnabled = true;
            cmbTipoMembresia.Location = new Point(1255, 221);
            cmbTipoMembresia.Name = "cmbTipoMembresia";
            cmbTipoMembresia.Size = new Size(257, 28);
            cmbTipoMembresia.TabIndex = 18;
            cmbTipoMembresia.SelectedIndexChanged += cmbTipoMembresia_SelectedIndexChanged;
            // 
            // mtxtTelefono
            // 
            mtxtTelefono.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtxtTelefono.Location = new Point(1224, 398);
            mtxtTelefono.Name = "mtxtTelefono";
            mtxtTelefono.Size = new Size(288, 25);
            mtxtTelefono.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2025_06_04_at_12_01_16_AM;
            ClientSize = new Size(1628, 842);
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
    }

 
}
