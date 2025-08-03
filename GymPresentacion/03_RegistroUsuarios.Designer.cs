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
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicUsuariosInicio).BeginInit();
            SuspendLayout();
            // 
            // lblNombreUusario
            // 
            lblNombreUusario.AutoSize = true;
            lblNombreUusario.BackColor = Color.Transparent;
            lblNombreUusario.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreUusario.ForeColor = Color.Lavender;
            lblNombreUusario.Location = new Point(947, 190);
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
            lblContrasena.Location = new Point(947, 254);
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
            lblRolUsuario.Location = new Point(947, 312);
            lblRolUsuario.Name = "lblRolUsuario";
            lblRolUsuario.Size = new Size(119, 20);
            lblRolUsuario.TabIndex = 2;
            lblRolUsuario.Text = "Rol Usuario";
            // 
            // cmbRolUsuario
            // 
            cmbRolUsuario.FormattingEnabled = true;
            cmbRolUsuario.Location = new Point(1141, 310);
            cmbRolUsuario.Name = "cmbRolUsuario";
            cmbRolUsuario.Size = new Size(293, 28);
            cmbRolUsuario.TabIndex = 3;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Cursor = Cursors.IBeam;
            txtNombreUsuario.Location = new Point(1141, 188);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(252, 27);
            txtNombreUsuario.TabIndex = 4;
            // 
            // txtContasena
            // 
            txtContasena.Cursor = Cursors.IBeam;
            txtContasena.Location = new Point(1141, 252);
            txtContasena.Name = "txtContasena";
            txtContasena.Size = new Size(293, 27);
            txtContasena.TabIndex = 5;
            txtContasena.UseSystemPasswordChar = true;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToOrderColumns = true;
            dgvUsuarios.BackgroundColor = Color.Lavender;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(341, 185);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(530, 423);
            dgvUsuarios.TabIndex = 6;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.BackColor = Color.DodgerBlue;
            btnEliminarUsuario.Cursor = Cursors.Hand;
            btnEliminarUsuario.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarUsuario.ForeColor = Color.Black;
            btnEliminarUsuario.Location = new Point(361, 613);
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
            btnEditarUsuario.Location = new Point(557, 613);
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
            btnAgregarUsuario.Location = new Point(1198, 613);
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
            btnConsultarUsuario.Location = new Point(731, 613);
            btnConsultarUsuario.Name = "btnConsultarUsuario";
            btnConsultarUsuario.Size = new Size(139, 52);
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
            pictureBox1.Location = new Point(361, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(589, 163);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // PicUsuariosInicio
            // 
            PicUsuariosInicio.BackColor = Color.Transparent;
            PicUsuariosInicio.BackgroundImage = Properties.Resources.image_removebg_preview__7_;
            PicUsuariosInicio.BackgroundImageLayout = ImageLayout.Zoom;
            PicUsuariosInicio.Cursor = Cursors.Hand;
            PicUsuariosInicio.Location = new Point(75, 102);
            PicUsuariosInicio.Name = "PicUsuariosInicio";
            PicUsuariosInicio.Size = new Size(125, 61);
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
            checkBox1.ForeColor = SystemColors.ButtonHighlight;
            checkBox1.Location = new Point(966, 386);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(52, 24);
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
            btnLimpiar1.Location = new Point(996, 613);
            btnLimpiar1.Name = "btnLimpiar1";
            btnLimpiar1.Size = new Size(139, 52);
            btnLimpiar1.TabIndex = 14;
            btnLimpiar1.Text = "Limpiar";
            btnLimpiar1.UseVisualStyleBackColor = false;
            btnLimpiar1.Click += btnLimpiar1_Click;
            // 
            // RegsitroUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1730, 981);
            Controls.Add(btnLimpiar1);
            Controls.Add(checkBox1);
            Controls.Add(PicUsuariosInicio);
            Controls.Add(pictureBox1);
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
    }
}