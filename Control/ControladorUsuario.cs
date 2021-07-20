using Data;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control
{
    public class ControladorUsuario
    {
        List<Usuario> usuarios = new List<Usuario>();
        DatosLogin datosLogin = new DatosLogin();
        Usuario user = null;
        Rol role = null;

        public ControladorUsuario()
        {
        }

        public bool validarLogin(string usuario, string contrasena)
        {

            Usuario user = null;
            user = datosLogin.ConsultarUsuario(usuario);

            if (user == null)
            {
                return false;
                throw new GeneralExcepcion("Usuario y/o contrasena incorrecta");
            }
            else { 
                if (user.Contrasena!=contrasena)
                {
                    return false;
                    throw new GeneralExcepcion("Contrasena incorrecta");
                }
            }
            return true;
        }

       

        public Object BuscarUsuario(string usuario)
        {
            return datosLogin.ConsultarUsuario(usuario);
        }

        public bool prueba()
        {
            return true;
        }

        public bool GuardarUsuario(string nombre, string apellido, string usuario, string contrasena, string rol)
        {
            bool guarda = false;
            if (BuscarUsuario(usuario) == null)
            {
                role = new Rol(rol);
                user = new Usuario(nombre, apellido, usuario, contrasena, ObtenerRol(rol));
                datosLogin.InsertarUsuario(user);
                guarda = true;
            }else
            {
                throw new Exception("Usuario ya existe");
            }
            return guarda;

        }
        public Rol ObtenerRol(string rol)
        {
           return datosLogin.ConsultarRol(rol);
        }
    }

}
