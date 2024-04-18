using MySql.Data.MySqlClient;
using Pqrs_C_.App;
using SistemaInventarioNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pqrs_C_.Model
{
    internal class Modelo
    {
       
        public int registro(Usuarios usuarios)
        {
            MySqlConnection conexion = Conexion.conexion();
            try
            {
                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MySqlCommand mySqlCommand = new MySqlCommand();
            mySqlCommand.Connection = conexion;
            mySqlCommand.CommandText = "INSERT INTO usuario (usuario, contraseña, idtipo_usuario, Nombre, Apellido) VALUES(@usuario, @contraseña, @idtipo_usuario, @Nombre, @Apellido)";

            mySqlCommand.Parameters.AddWithValue("@usuario", usuarios.Usuario);
            mySqlCommand.Parameters.AddWithValue("@contraseña", usuarios.Contraseña);
            mySqlCommand.Parameters.AddWithValue("@Nombre", usuarios.nombre);
            mySqlCommand.Parameters.AddWithValue("@Apellido", usuarios.apellido);
            mySqlCommand.Parameters.AddWithValue("@idtipo_usuario", usuarios.rol);

            int result = mySqlCommand.ExecuteNonQuery();
            return result;
        }

        public bool existeuser(string usuario)
        {
            MySqlConnection conexion = Conexion.conexion();
            try
            {
                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MySqlDataReader mySqlDataReader;
            MySqlCommand mySqlCommand = new MySqlCommand();
            mySqlCommand.Connection = conexion;
            mySqlCommand.CommandText = "SELECT idusuario FROM usuario WHERE usuario LIKE @usuario";

            mySqlCommand.Parameters.AddWithValue("@usuario", usuario);
            mySqlDataReader = mySqlCommand.ExecuteReader();

            if (mySqlDataReader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void Inicio_sesion(Usuarios usuarios)
        {
            MySqlConnection conexion = Conexion.conexion();
            try
            {
                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
            MySqlCommand mySqlCommand = new MySqlCommand();
            mySqlCommand.Connection = conexion;
            mySqlCommand.CommandText = "select usuario,contraseña from usuario where usuario = @usuario AND contraseña = @contraseña ";

            mySqlCommand.Parameters.AddWithValue("@usuario", usuarios.Usuario);
            mySqlCommand.Parameters.AddWithValue("@contraseña", usuarios.Contraseña);

            MySqlDataReader dr = mySqlCommand.ExecuteReader();

            if (dr.Read())
            {
                conexion.Close();
                
                try
                {
                    conexion.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                mySqlCommand.CommandText = "select idtipo_usuario,usuario,contraseña from usuario where idtipo_usuario =@idtipo_usuario AND usuario = @usuario AND contraseña = @contraseña ";
                mySqlCommand.Parameters.AddWithValue("@idtipo_usuario", 1);
                MySqlDataReader dr2 = mySqlCommand.ExecuteReader();

                if (dr2.Read())
                {
                    var frmLogin = new FrmLogin();
                    var frmIndex = new FrmIndex();
                    frmIndex.Show();

                    frmLogin.Hide();

                }
                else
                {
                    MessageBox.Show("espere");
                }

            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                

            }
            conexion.Close();
        }

        public int registro_SecreDepe(Usuarios usuarios)
        {
            MySqlConnection conexion = Conexion.conexion();
            try
            {
                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MySqlCommand mySqlCommand = new MySqlCommand();
            mySqlCommand.Connection = conexion;
            mySqlCommand.CommandText = "INSERT INTO usuario (usuario, contraseña, idtipo_usuario, Nombre, Apellido, Dependencia) VALUES(@usuario, @contraseña, @idtipo_usuario, @Nombre, @Apellido, @Secretario)";

            mySqlCommand.Parameters.AddWithValue("@usuario", usuarios.Usuario);
            mySqlCommand.Parameters.AddWithValue("@contraseña", usuarios.Contraseña);
            mySqlCommand.Parameters.AddWithValue("@Nombre", usuarios.nombre);
            mySqlCommand.Parameters.AddWithValue("@Apellido", usuarios.apellido);
            mySqlCommand.Parameters.AddWithValue("@idtipo_usuario", usuarios.rol);
            mySqlCommand.Parameters.AddWithValue("@Secretario", usuarios.Dependencia1);

            int result = mySqlCommand.ExecuteNonQuery();
            return result;
        }


    }
}
