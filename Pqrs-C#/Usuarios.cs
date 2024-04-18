using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pqrs_C_
{
    internal class Usuarios
    {
        int idusuario, idtipo_usuario;
        string usuario, contraseña, Nombre, Apellido, Rol, Dependencia;

        
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public int Id { get => idusuario; set => idusuario = value; }
        public int Idtipo_usuario { get => idtipo_usuario; set => idtipo_usuario = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string nombre { get => Nombre; set => Nombre = value; }
        public string apellido { get => Apellido; set => Apellido = value; }
        public string rol { get => Rol; set => Rol = value; }
        public string Dependencia1 { get => Dependencia; set => Dependencia = value; }
    }

}
