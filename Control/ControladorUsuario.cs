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

        public List<Object> ListarUsuarios()
        {
            List<Usuario> usuarios = datosLogin.Consultar();

            if (usuarios.Count <= 0)
                throw new GeneralExcepcion("No se encontraron usuarios registrados");
            else
                return GetListaDatosUsuarios(usuarios);
        }

        private List<Object> GetListaDatosUsuarios(List<Usuario> usuarios)
        {
            List<Object> cargosDatos = new List<object>();
            foreach(Usuario usuario in usuarios)
            {
                cargosDatos.Add(ConvertirAnonimo(usuario));
            }
            return cargosDatos;
        }

        private Object ConvertirAnonimo(Usuario usuario)
        {
            return new
            {
                nombres = usuario.Nombres,
                apellidos = usuario.Apellidos,
                usuario = usuario.Username,
                contrasena = usuario.Contrasena,
                rol = usuario.Rol.Descripcion
            };
        }

        public Object BuscarUsuario(string user)
        {
            return datosLogin.BuscarUsuario(user);
        }

        public void ActualizarUsuario(string nombre, string apellido, string usuario, string contrasena, string rol, string username)
        {
            role = new Rol(rol);
            user = new Usuario(nombre, apellido, usuario, contrasena, ObtenerRol(rol));
            datosLogin.ActualizarUsuario(user,username);// username va en el where del sp
        }

        public string RetornaRol(string usuario)
        {
            Usuario user = null;
            user = datosLogin.ConsultarUsuario(usuario);

            return user.Rol.Descripcion;
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
