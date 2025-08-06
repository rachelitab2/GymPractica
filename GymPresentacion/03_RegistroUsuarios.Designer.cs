namespace GymPresentacion
{
    partial class RegsitroUsuarios
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
            lblNombreUusario = new Label();
            lblContrasena = new Label();
            lblRolUsuario = new Label();
            cmbRolUsuario = new ComboBox();
            txtNombreUsuario = new TextBox();
            txtContasena = new TextBox();
            dgvUsuarios = new DataGridView();
            btnEliminarUsuario = new Button();
            btnEditarUsuario = new Button();
            btnAgregarUsuario = new Button();
            btnConsultarUsuario = new Button();
            pictureBox1 = new PictureBox();
            PicUsuariosInicio = new PictureBox();
            chkMostrarContrasena1 = new CheckBox();
            btnLimpiar = new Button();
            checkBox1 = new CheckBox();
            btnLimpiar1 = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicUsuariosInicio).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombreUusario
            // 
            lblNombreUusario.AutoSize = true;
            lblNombreUusario.BackColor = Color.Transparent;
            lblNombreUusario.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreUusario.ForeColor = Color.Lavender;
            lblNombreUusario.Location = new Point(648, 138);
            lblNombreUusario.Name = "lblNombreUusario";
            lblNombreUusario.Size = new Size(163, 20);
            lblNombreUusario.TabIndex = 0;
            lblNombreUusario.Text = "Nombre Usuario";
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.BackColor = Color.Transparent;
            lblContrasena.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContrasena.ForeColor = Color.Lavender;
            lblContrasena.Location = new Point(648, 196);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(122, 20);
            lblContrasena.TabIndex = 1;
            lblContrasena.Text = "Contrasena ";
            // 
            // lblRolUsuario
            // 
            lblRolUsuario.AutoSize = true;
            lblRolUsuario.BackColor = Color.Transparent;
            lblRolUsuario.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRolUsuario.ForeColor = Color.Lavender;
            lblRolUsuario.Location = new Point(651, 291);
            lblRolUsuario.Name = "lblRolUsuario";
            lblRolUsuario.Size = new Size(119, 20);
            lblRolUsuario.TabIndex = 2;
            lblRolUsuario.Text = "Rol Usuario";
            // 
            // cmbRolUsuario
            // 
            cmbRolUsuario.BackColor = Color.Lavender;
            cmbRolUsuario.Cursor = Cursors.Hand;
            cmbRolUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRolUsuario.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            cmbRolUsuario.FormattingEnabled = true;
            cmbRolUsuario.Location = new Point(898, 291);
            cmbRolUsuario.Name = "cmbRolUsuario";
            cmbRolUsuario.Size = new Size(293, 35);
            cmbRolUsuario.TabIndex = 3;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Cursor = Cursors.Hand;
            txtNombreUsuario.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            txtNombreUsuario.Location = new Point(898, 138);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(293, 34);
            txtNombreUsuario.TabIndex = 4;
            // 
            // txtContasena
            // 
            txtContasena.Cursor = Cursors.Hand;
            txtContasena.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            txtContasena.Location = new Point(898, 196);
            txtContasena.Name = "txtContasena";
            txtContasena.Size = new Size(293, 34);
            txtContasena.TabIndex = 5;
            txtContasena.UseSystemPasswordChar = true;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.BackgroundColor = Color.Lavender;
            dgvUsuarios.BorderStyle = BorderStyle.None;
            dgvUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Cursor = Cursors.Hand;
            dgvUsuarios.EnableHeadersVisualStyles = false;
            dgvUsuarios.GridColor = Color.DodgerBlue;
            dgvUsuarios.Location = new Point(81, 111);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(517, 423);
            dgvUsuarios.TabIndex = 6;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.BackColor = Color.DodgerBlue;
            btnEliminarUsuario.Cursor = Cursors.Hand;
            btnEliminarUsuario.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarUsuario.ForeColor = Color.Black;
            btnEliminarUsuario.Location = new Point(81, 563);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(152, 52);
            btnEliminarUsuario.TabIndex = 7;
            btnEliminarUsuario.Text = "🗑️ Eliminar";
            btnEliminarUsuario.UseVisualStyleBackColor = false;
            // 
            // btnEditarUsuario
            // 
            btnEditarUsuario.BackColor = Color.DodgerBlue;
            btnEditarUsuario.Cursor = Cursors.Hand;
            btnEditarUsuario.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            btnEditarUsuario.Location = new Point(265, 563);
            btnEditarUsuario.Name = "btnEditarUsuario";
            btnEditarUsuario.Size = new Size(144, 52);
            btnEditarUsuario.TabIndex = 8;
            btnEditarUsuario.Text = "✏️ Editar";
            btnEditarUsuario.UseVisualStyleBackColor = false;
            btnEditarUsuario.Click += btnEditarUsuario_Click;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.BackColor = Color.DodgerBlue;
            btnAgregarUsuario.Cursor = Cursors.Hand;
            btnAgregarUsuario.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            btnAgregarUsuario.Location = new Point(1001, 563);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(149, 52);
            btnAgregarUsuario.TabIndex = 9;
            btnAgregarUsuario.Text = "➕ Agregar";
            btnAgregarUsuario.UseVisualStyleBackColor = false;
            btnAgregarUsuario.Click += BtnAgregar_Click;
            // 
            // btnConsultarUsuario
            // 
            btnConsultarUsuario.BackColor = Color.DodgerBlue;
            btnConsultarUsuario.Cursor = Cursors.Hand;
            btnConsultarUsuario.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            btnConsultarUsuario.Location = new Point(448, 563);
            btnConsultarUsuario.Name = "btnConsultarUsuario";
            btnConsultarUsuario.Size = new Size(150, 52);
            btnConsultarUsuario.TabIndex = 10;
            btnConsultarUsuario.Text = "🔍 Consultar";
            btnConsultarUsuario.UseVisualStyleBackColor = false;
            btnConsultarUsuario.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.image_removebg_preview__4_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(518, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(327, 94);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // PicUsuariosInicio
            // 
            PicUsuariosInicio.BackColor = Color.Transparent;
            PicUsuariosInicio.BackgroundImage = Properties.Resources.image_removebg_preview__7_;
            PicUsuariosInicio.BackgroundImageLayout = ImageLayout.Zoom;
            PicUsuariosInicio.Cursor = Cursors.Hand;
            PicUsuariosInicio.Location = new Point(81, 3);
            PicUsuariosInicio.Name = "PicUsuariosInicio";
            PicUsuariosInicio.Size = new Size(152, 94);
            PicUsuariosInicio.TabIndex = 12;
            PicUsuariosInicio.TabStop = false;
            PicUsuariosInicio.Click += PicUsuarios_Click;
            // 
            // chkMostrarContrasena1
            // 
            chkMostrarContrasena1.AutoSize = true;
            chkMostrarContrasena1.ForeColor = SystemColors.ButtonFace;
            chkMostrarContrasena1.Location = new Point(886, 341);
            chkMostrarContrasena1.Name = "chkMostrarContrasena1";
            chkMostrarContrasena1.Size = new Size(128, 19);
            chkMostrarContrasena1.TabIndex = 14;
            chkMostrarContrasena1.Text = "Mostrar contraseña";
            chkMostrarContrasena1.UseVisualStyleBackColor = true;
            chkMostrarContrasena1.CheckedChanged += chkMostrarContrasena1_CheckedChanged;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(0, 0);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 0;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Black;
            checkBox1.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            checkBox1.ForeColor = SystemColors.ButtonHighlight;
            checkBox1.Location = new Point(1128, 245);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(63, 24);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "Ver";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnLimpiar1
            // 
            btnLimpiar1.BackColor = Color.DodgerBlue;
            btnLimpiar1.Cursor = Cursors.Hand;
            btnLimpiar1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            btnLimpiar1.Location = new Point(802, 563);
            btnLimpiar1.Name = "btnLimpiar1";
            btnLimpiar1.Size = new Size(139, 52);
            btnLimpiar1.TabIndex = 14;
            btnLimpiar1.Text = "Limpiar";
            btnLimpiar1.UseVisualStyleBackColor = false;
            btnLimpiar1.Click += btnLimpiar1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(PicUsuariosInicio);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1348, 100);
            panel1.TabIndex = 15;
            // 
            // RegsitroUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1348, 721);
            Controls.Add(panel1);
            Controls.Add(btnLimpiar1);
            Controls.Add(checkBox1);
            Controls.Add(btnConsultarUsuario);
            Controls.Add(btnAgregarUsuario);
            Controls.Add(btnEditarUsuario);
            Controls.Add(btnEliminarUsuario);
            Controls.Add(dgvUsuarios);
            Controls.Add(txtContasena);
            Controls.Add(txtNombreUsuario);
            Controls.Add(cmbRolUsuario);
            Controls.Add(lblRolUsuario);
            Controls.Add(lblContrasena);
            Controls.Add(lblNombreUusario);
            Name = "RegsitroUsuarios";
            Text = "RegsitroUsuarios";
            Load += RegsitroUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicUsuariosInicio).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreUusario;
        private Label lblContrasena;
        private Label lblRolUsuario;
        private ComboBox cmbRolUsuario;
        private TextBox txtNombreUsuario;
        private TextBox txtContasena;
        private DataGridView dgvUsuarios;
        private Button btnEliminarUsuario;
        private Button btnEditarUsuario;
        private Button btnAgregarUsuario;
        private Button btnConsultarUsuario;
        private PictureBox pictureBox1;
        private PictureBox PicUsuariosInicio;
        private CheckBox chkMostrarContrasena1;
        private Button btnLimpiar;
        private CheckBox checkBox1;
        private Button btnLimpiar1;
        private Panel panel1;
    }
}