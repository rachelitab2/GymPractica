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
            lblTitulo = new Label();
            lblName = new Label();
            lblCliente = new Label();
            btnEditar = new Button();
            btnEliminar = new Button();
            dataGridView1 = new DataGridView();
            txtNombreCliente = new TextBox();
            txtTipoMembresia = new TextBox();
            txtFechaInicio = new TextBox();
            btnAgregar = new Button();
            lblFechaInicio = new Label();
            txtCostoTotal = new TextBox();
            ((ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(389, 41);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(74, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gymnasio";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(462, 108);
            lblName.Name = "lblName";
            lblName.Size = new Size(64, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Nombre";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(462, 154);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(85, 20);
            lblCliente.TabIndex = 2;
            lblCliente.Text = "TipoCliente";
            lblCliente.Click += label3_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(74, 362);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(98, 28);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(208, 361);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(65, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(374, 265);
            dataGridView1.TabIndex = 5;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(553, 105);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(125, 27);
            txtNombreCliente.TabIndex = 6;
            // 
            // txtTipoMembresia
            // 
            txtTipoMembresia.Location = new Point(553, 147);
            txtTipoMembresia.Name = "txtTipoMembresia";
            txtTipoMembresia.Size = new Size(125, 27);
            txtTipoMembresia.TabIndex = 7;
            // 
            // txtFechaInicio
            // 
            txtFechaInicio.Location = new Point(553, 202);
            txtFechaInicio.Name = "txtFechaInicio";
            txtFechaInicio.Size = new Size(125, 27);
            txtFechaInicio.TabIndex = 8;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(516, 313);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Location = new Point(462, 202);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(83, 20);
            lblFechaInicio.TabIndex = 10;
            lblFechaInicio.Text = "FechaInicio";
            lblFechaInicio.Click += label4_Click;
            // 
            // txtCostoTotal
            // 
            txtCostoTotal.Location = new Point(553, 252);
            txtCostoTotal.Name = "txtCostoTotal";
            txtCostoTotal.Size = new Size(125, 27);
            txtCostoTotal.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCostoTotal);
            Controls.Add(lblFechaInicio);
            Controls.Add(btnAgregar);
            Controls.Add(txtFechaInicio);
            Controls.Add(txtTipoMembresia);
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
        private TextBox txtTipoMembresia;
        private TextBox txtFechaInicio;
        private Button btnAgregar;
        private Label lblFechaInicio;
        private TextBox txtCostoTotal;
    }

 
}
