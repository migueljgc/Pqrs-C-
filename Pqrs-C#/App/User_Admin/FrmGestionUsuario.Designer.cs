namespace Pqrs_C_.App
{
    partial class FrmGestionUsuario
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
            panel1 = new Panel();
            txtUsuario = new TextBox();
            label3 = new Label();
            txtApellido = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            btnModificar = new Button();
            dgvGestionUsuarios = new DataGridView();
            btnEliminar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGestionUsuarios).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(70, 162, 253);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtApellido);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(582, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 247);
            panel1.TabIndex = 3;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.White;
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Location = new Point(18, 143);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(179, 23);
            txtUsuario.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 125);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 4;
            label3.Text = "Usuario:";
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.White;
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.Location = new Point(18, 87);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(179, 23);
            txtApellido.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 69);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Apellido:";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.White;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(18, 32);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(179, 23);
            txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 14);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(18, 203);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(118, 28);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // dgvGestionUsuarios
            // 
            dgvGestionUsuarios.BackgroundColor = Color.White;
            dgvGestionUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGestionUsuarios.Location = new Point(3, 12);
            dgvGestionUsuarios.Name = "dgvGestionUsuarios";
            dgvGestionUsuarios.ReadOnly = true;
            dgvGestionUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGestionUsuarios.Size = new Size(542, 403);
            dgvGestionUsuarios.TabIndex = 2;
            dgvGestionUsuarios.CellClick += dgvGestionUsuarios_CellClick;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(12, 443);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(118, 28);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FrmActualizarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 513);
            Controls.Add(btnEliminar);
            Controls.Add(panel1);
            Controls.Add(dgvGestionUsuarios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmActualizarUsuario";
            Text = "FrmActualizarUsuario";
            Load += FrmActualizarUsuario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGestionUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnModificar;
        private TextBox txtUsuario;
        private Label label3;
        private TextBox txtApellido;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private DataGridView dgvGestionUsuarios;
        private Button btnEliminar;

    }
}