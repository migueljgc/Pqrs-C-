using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pqrs_C_.App.User_Admin
{
    public partial class FrmRegistroSecreDepen : Form
    {
        public FrmRegistroSecreDepen()
        {
            InitializeComponent();
        }

        private void BtnRegistar2_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.Usuario = TxtUsuario.Text;
            usuarios.Contraseña = TxtContraseña.Text;
            usuarios.nombre = txtNombre.Text;
            usuarios.apellido = txtApellido.Text;
            usuarios.Dependencia1 = this.cbDependencia.Text;
            usuarios.rol = "3";


            Controller.Control control = new Controller.Control();
            control.ControlRegistroUsu(usuarios);
            string respuesta = control.Respuesta;

            try
            {
                if (respuesta == "Registro exitoso")
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK);
                }
                else if (respuesta == "")
                {
                    MessageBox.Show("Usuario existente", "Aviso", MessageBoxButtons.OK);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
