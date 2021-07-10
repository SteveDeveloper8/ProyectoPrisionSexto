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
        DatosLogin loginBD = new DatosLogin();


        public void validarLogin(string usuario, string contrasena)
        {

            Usuario user = null;
            user = loginBD.ConsultarUsuario(usuario);

            if (user == null)
            {
                throw new GeneralExcepcion("Usuario y/o contrasena incorrecta");
            }
            else { 
                if (user.Contrasena!=contrasena)
                {
                throw new GeneralExcepcion("Contrasena incorrecta");
                }
            }
        }


    }

}
