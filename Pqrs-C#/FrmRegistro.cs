using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pqrs_C_.Controller;
using Pqrs_C_.Model;

namespace Pqrs_C_
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
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

            Controller.Control control = new Controller.Control();
            control.ControlRegistro(usuarios);
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

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
