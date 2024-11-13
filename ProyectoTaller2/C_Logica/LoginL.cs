using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoTaller2.C_Datos;
using ProyectoTaller2.C_Presentacion.Login;

namespace ProyectoTaller2.C_Logica
{
    internal class LoginL
    {
        private DLogin datosUsuario = new DLogin();

        public int IniciarSesion(string nombreUsuario, string contraseña)
        {
            return datosUsuario.VerificarUsuario(nombreUsuario, contraseña);
        }

        public int UsuarioID(string nombreUsuario, string contraseña)
        {
            return datosUsuario.ObtenerID(nombreUsuario, contraseña);
        }
    }
}
