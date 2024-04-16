namespace Pqrs_C_
{
    partial class FrmLogin
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
            panel1 = new Panel();
            btnexit = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnIniciar_Sesion = new Button();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            BtnRegistrar = new Button();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.BlanchedAlmond;
            panel1.Controls.Add(btnexit);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(649, 67);
            panel1.TabIndex = 4;
            panel1.MouseDown += panel1_MouseDown_1;
            panel1.MouseMove += panel1_MouseMove_1;
            // 
            // btnexit
            // 
            btnexit.FlatAppearance.BorderSize = 0;
            btnexit.FlatStyle = FlatStyle.Flat;
            btnexit.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnexit.ForeColor = Color.White;
            btnexit.Location = new Point(605, 3);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(41, 49);
            btnexit.TabIndex = 1;
            btnexit.Text = "X";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pqrspng;
            pictureBox1.Location = new Point(191, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(259, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(70, 162, 253);
            panel2.Controls.Add(btnIniciar_Sesion);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(324, 230);
            panel2.TabIndex = 5;
            // 
            // btnIniciar_Sesion
            // 
            btnIniciar_Sesion.BackColor = Color.FromArgb(70, 162, 253);
            btnIniciar_Sesion.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciar_Sesion.ForeColor = Color.White;
            btnIniciar_Sesion.Location = new Point(87, 139);
            btnIniciar_Sesion.Name = "btnIniciar_Sesion";
            btnIniciar_Sesion.Size = new Size(127, 38);
            btnIniciar_Sesion.TabIndex = 2;
            btnIniciar_Sesion.Text = "Iniciar Sesion";
            btnIniciar_Sesion.UseVisualStyleBackColor = false;
            btnIniciar_Sesion.Click += btnIniciar_Sesion_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(36, 99);
            label2.Name = "label2";
            label2.Size = new Size(248, 19);
            label2.TabIndex = 1;
            label2.Text = "Inicia sesion para entrar al programa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(48, 42);
            label1.Name = "label1";
            label1.Size = new Size(221, 33);
            label1.TabIndex = 0;
            label1.Text = "¿Ya tienes cuenta?";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(70, 162, 253);
            panel3.Controls.Add(BtnRegistrar);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(324, 67);
            panel3.Name = "panel3";
            panel3.Size = new Size(325, 230);
            panel3.TabIndex = 6;
            // 
            // BtnRegistrar
            // 
            BtnRegistrar.BackColor = Color.FromArgb(70, 162, 253);
            BtnRegistrar.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRegistrar.ForeColor = Color.White;
            BtnRegistrar.Location = new Point(92, 139);
            BtnRegistrar.Name = "BtnRegistrar";
            BtnRegistrar.Size = new Size(149, 38);
            BtnRegistrar.TabIndex = 5;
            BtnRegistrar.Text = "Registrar";
            BtnRegistrar.UseVisualStyleBackColor = false;
            BtnRegistrar.Click += BtnRegistrar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(45, 99);
            label3.Name = "label3";
            label3.Size = new Size(234, 19);
            label3.TabIndex = 4;
            label3.Text = "Registrate para entrar al programa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(27, 42);
            label4.Name = "label4";
            label4.Size = new Size(276, 33);
            label4.TabIndex = 3;
            label4.Text = "¿Aun no tienes cuenta?";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.White;
            ClientSize = new Size(649, 297);
            ControlBox = false;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "FrmLogin";
            RightToLeft = RightToLeft.No;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Button btnIniciar_Sesion;
        private Label label2;
        private Label label1;
        private Button BtnRegistrar;
        private Label label3;
        private Label label4;
        private Button btnexit;
    }
}
