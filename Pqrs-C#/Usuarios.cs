using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pqrs_C_
{
    internal class Usuarios
    {
        int id, idtipo_usuario;
        string usuario, contraseña;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public int Id { get => id; set => id = value; }
        public int Idtipo_usuario { get => idtipo_usuario; set => idtipo_usuario = value; }
    }

}
