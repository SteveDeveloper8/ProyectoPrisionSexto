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

        public void validarLogin(string usuario, string contrasena)
        {

            Usuario user = null;
            user = datosLogin.ConsultarUsuario(usuario);

            if (user == null)
            {
                throw new GeneralExcepcion("Usuario y/o contrasena incorrecta");
            }
            else if (user.Contrasena!=contrasena)
            {
                throw new GeneralExcepcion("Contrasena incorrecta");
            }
        }

       

        public void usuarioRepetido(string usuario)
        {
            Usuario user = null;
            user = datosLogin.ConsultarUsuario(usuario);
            if (user != null)
            {
                throw new Exception("Usuario ya registrado");
            }
        }

        public void GuardarUsuario(string nombre, string apellido, string usuario, string contrasena, string rol)
        {
            role = new Rol(rol);
            user = new Usuario(nombre, apellido,usuario, contrasena, ObtenerRol(rol));
            datosLogin.InsertarUsuario(user);
            
        }
        public Rol ObtenerRol(string rol)
        {
           return datosLogin.ConsultarRol(rol);
        }
    }

}
