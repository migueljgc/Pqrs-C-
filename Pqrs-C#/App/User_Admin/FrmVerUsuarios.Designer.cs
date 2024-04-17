namespace Pqrs_C_.App
{
    partial class FrmVerUsuarios
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
            dgvGestionUsuarios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvGestionUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgvGestionUsuarios
            // 
            dgvGestionUsuarios.BackgroundColor = Color.White;
            dgvGestionUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGestionUsuarios.Location = new Point(152, 12);
            dgvGestionUsuarios.Name = "dgvGestionUsuarios";
            dgvGestionUsuarios.ReadOnly = true;
            dgvGestionUsuarios.Size = new Size(543, 489);
            dgvGestionUsuarios.TabIndex = 3;
            // 
            // FrmGestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(844, 513);
            Controls.Add(dgvGestionUsuarios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGestionUsuarios";
            Text = "FrmGestionUsuarios";
            Load += FrmGestionUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGestionUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvGestionUsuarios;
    }
}