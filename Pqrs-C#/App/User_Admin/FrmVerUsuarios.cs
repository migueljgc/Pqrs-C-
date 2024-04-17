using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Pqrs_C_;
using Pqrs_C_.Controller;
using Control = Pqrs_C_.Controller.Control;

namespace Pqrs_C_.App
{
    public partial class FrmVerUsuarios : Form
    {
        public FrmVerUsuarios()
        {
            InitializeComponent();
          

        }



        

        private void FrmGestionUsuarios_Load(object sender, EventArgs e)
        {
            MySqlConnection conexion = Conexion.conexion();
            DataTable dt = new DataTable();
            MySqlDataReader reader;
            try
            {
                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT idusuario, usuario, Nombre, Apellido, Rol FROM usuario ORDER BY Nombre ASC", conexion);
            reader = mySqlCommand.ExecuteReader();
            dt.Load(reader);
            dgvGestionUsuarios.DataSource = dt;




        }
    }
}
