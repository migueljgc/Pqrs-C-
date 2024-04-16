namespace Pqrs_C_
{
    partial class FrmInicio_Sesion
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
            label1 = new Label();
            TxtUsuario = new TextBox();
            TxtContraseña = new TextBox();
            BtnIniciar_Sesion2 = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(70, 162, 253);
            label1.Location = new Point(69, 9);
            label1.Name = "label1";
            label1.Size = new Size(166, 26);
            label1.TabIndex = 0;
            label1.Text = "INICIO DE SESION";
            // 
            // TxtUsuario
            // 
            TxtUsuario.BackColor = Color.White;
            TxtUsuario.BorderStyle = BorderStyle.FixedSingle;
            TxtUsuario.Location = new Point(87, 69);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(138, 23);
            TxtUsuario.TabIndex = 1;
            // 
            // TxtContraseña
            // 
            TxtContraseña.BackColor = Color.White;
            TxtContraseña.BorderStyle = BorderStyle.FixedSingle;
            TxtContraseña.Location = new Point(86, 130);
            TxtContraseña.Name = "TxtContraseña";
            TxtContraseña.PasswordChar = '*';
            TxtContraseña.Size = new Size(139, 23);
            TxtContraseña.TabIndex = 2;
            // 
            // BtnIniciar_Sesion2
            // 
            BtnIniciar_Sesion2.BackColor = Color.FromArgb(70, 162, 253);
            BtnIniciar_Sesion2.FlatAppearance.BorderSize = 0;
            BtnIniciar_Sesion2.FlatStyle = FlatStyle.Flat;
            BtnIniciar_Sesion2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnIniciar_Sesion2.ForeColor = Color.White;
            BtnIniciar_Sesion2.Location = new Point(95, 177);
            BtnIniciar_Sesion2.Name = "BtnIniciar_Sesion2";
            BtnIniciar_Sesion2.Size = new Size(123, 31);
            BtnIniciar_Sesion2.TabIndex = 3;
            BtnIniciar_Sesion2.Text = "Iniciar Sesion";
            BtnIniciar_Sesion2.UseVisualStyleBackColor = false;
            BtnIniciar_Sesion2.Click += BtnIniciar_Sesion2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 51);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 4;
            label2.Text = "USUARIO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 112);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 5;
            label3.Text = "CONTRASEÑA";
            // 
            // FrmInicio_Sesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(324, 230);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BtnIniciar_Sesion2);
            Controls.Add(TxtContraseña);
            Controls.Add(TxtUsuario);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmInicio_Sesion";
            Text = "Inicio_Sesion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtUsuario;
        private TextBox TxtContraseña;
        private Button BtnIniciar_Sesion2;
        private Label label2;
        private Label label3;
    }
}