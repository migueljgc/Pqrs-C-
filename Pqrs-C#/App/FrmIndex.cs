using Pqrs_C_;
using Pqrs_C_.App;
using Pqrs_C_.App.User_Admin;

namespace SistemaInventarioNet
{
    public partial class FrmIndex : Form
    {
        private bool draggable;
        private int mouseX;
        private int mouseY;
        public FrmIndex()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                draggable = true;
                mouseX = Cursor.Position.X - this.Left;
                mouseY = Cursor.Position.Y - this.Top;
            }
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (draggable && e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Top = Cursor.Position.Y - mouseY;
                this.Left = Cursor.Position.X - mouseX;
            }
        }

        private void btnGestionUsuarios_Click(object sender, EventArgs e)
        {
            var frmGestionUsuario = new FrmVerUsuarios();
            frmGestionUsuario.TopLevel = false;
            panel4.Controls.Add(frmGestionUsuario);
            frmGestionUsuario.BringToFront();
            frmGestionUsuario.Show();
        }

        private void btncerrarsesion_Click(object sender, EventArgs e)
        {
            var frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void btnActualizarUsuario_Click(object sender, EventArgs e)
        {
            var frmActualizarUsuario = new FrmGestionUsuario();
            frmActualizarUsuario.TopLevel = false;
            panel4.Controls.Add(frmActualizarUsuario);
            frmActualizarUsuario.BringToFront();
            frmActualizarUsuario.Show();
        }

        private void btnCrearAdmin_Click(object sender, EventArgs e)
        {
            var frmRegistroAdministradores = new FrmRegistroUsu() ;
            frmRegistroAdministradores.TopLevel = false;
            panel4.Controls.Add(frmRegistroAdministradores);
            frmRegistroAdministradores.BringToFront();
            frmRegistroAdministradores.Show();
        }
    }
}
