using MySql.Data.MySqlClient;
using Pqrs_C_.App;
using Pqrs_C_.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pqrs_C_
{
    public partial class FrmInicio_Sesion : Form
    {

        public FrmInicio_Sesion()
        {
            InitializeComponent();
        }
        MySqlConnection conexion = Conexion.conexion();

        private void BtnIniciar_Sesion2_Click(object sender, EventArgs e)
        {
            Modelo modelo = new Modelo();
            Usuarios usuarios = new Usuarios();
            usuarios.Usuario = TxtUsuario.Text;
            usuarios.Contraseña = TxtContraseña.Text;
            modelo.Inicio_sesion(usuarios);


        }

        
    }
}
