using MySql.Data.MySqlClient;
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

namespace Pqrs_C_.App
{
    public partial class FrmGestionUsuario : Form
    {

        public FrmGestionUsuario()
        {
            InitializeComponent();
        }
        


        public void llenartabla()
        {
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            DataTable dt = new DataTable();
            MySqlDataReader reader;
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT idusuario, usuario, Nombre, Apellido, Rol FROM usuario ORDER BY Nombre ASC", conexion);
            reader = mySqlCommand.ExecuteReader();
            dt.Load(reader);
            dgvGestionUsuarios.DataSource = dt;
        }

        private void FrmActualizarUsuario_Load(object sender, EventArgs e)
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

        private void dgvGestionUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUsuario.Text = dgvGestionUsuarios.SelectedCells[1].Value.ToString();
            txtNombre.Text = dgvGestionUsuarios.SelectedCells[2].Value.ToString();
            txtApellido.Text = dgvGestionUsuarios.SelectedCells[3].Value.ToString();
        }



        private void btnModificar_Click(object sender, EventArgs e)
        {

            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();

            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand("update usuario set usuario = @usuario, Nombre = @Nombre, Apellido = @Apellido WHERE idusuario LIKE @id ", conexion);
                mySqlCommand.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                mySqlCommand.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                mySqlCommand.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                mySqlCommand.Parameters.AddWithValue("@id", dgvGestionUsuarios.SelectedCells[0].Value.ToString());
                mySqlCommand.ExecuteReader();
                MessageBox.Show("Actualizacion Exitosa");

            }
            catch
            {
                MessageBox.Show("No ha selccionado nada");
            }
            llenartabla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            

            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand("delete from usuario where usuario = @usuario", conexion);
                mySqlCommand.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                mySqlCommand.ExecuteReader();
                MessageBox.Show("Eliminacion Exitosa");

            }
            catch 
            {
                MessageBox.Show("No ha selccionado nada");
            } 
            llenartabla();

        }
            
    }
}
