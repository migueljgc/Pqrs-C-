using Pqrs_C_.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pqrs_C_.Controller
{
    internal class Control
    {
        string respuesta = "1";

        public string Respuesta { get => respuesta; set => respuesta = value; }

        public string ControlRegistro(Usuarios usuarios)
        {
            Modelo modelo = new Modelo();
            
            if (string.IsNullOrEmpty(usuarios.Usuario) || string.IsNullOrEmpty(usuarios.Contraseña))
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else
            {
                if (!modelo.existeuser(usuarios.Usuario))
                {
                    modelo.registro(usuarios);

                    Respuesta = "Registro exitoso";
                    
                }
                else if (modelo.existeuser(usuarios.Usuario))
                {
                    Respuesta = "";
                }
                
                
            }
            return Respuesta;
            
        }
    }
}
