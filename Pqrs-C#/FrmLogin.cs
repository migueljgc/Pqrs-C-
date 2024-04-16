using Microsoft.VisualBasic.Devices;
using System.Drawing.Drawing2D;

namespace Pqrs_C_
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private bool draggable;
        private int mouseX;
        private int mouseY;

        private void btnIniciar_Sesion_Click(object sender, EventArgs e)
        {
            var Inicio_Sesion = new FrmInicio_Sesion();
            Inicio_Sesion.TopLevel = false;

            foreach (Control control in panel3.Controls)
            {
                if (control is Form)
                {
                    (control as Form).Close();
                }
            }
            panel2.Controls.Add(Inicio_Sesion);
            Inicio_Sesion.BringToFront();
            Inicio_Sesion.Show();

        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {

            var Registro = new FrmRegistro();
            Registro.TopLevel = false;
            foreach (Control control in panel2.Controls)
            {
                if (control is Form)
                {
                    (control as Form).Close();
                }
            }
            panel3.Controls.Add(Registro);
            Registro.BringToFront();
            Registro.Show();


        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                draggable = true;
                mouseX = Cursor.Position.X - this.Left;
                mouseY = Cursor.Position.Y - this.Top;
            }
        }

        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (draggable && e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Top = Cursor.Position.Y - mouseY;
                this.Left = Cursor.Position.X - mouseX;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                draggable = true;
                mouseX = Cursor.Position.X - this.Left;
                mouseY = Cursor.Position.Y - this.Top;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (draggable && e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Top = Cursor.Position.Y - mouseY;
                this.Left = Cursor.Position.X - mouseX;
            }
        }
    }

}
