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
        /// <summary>
        /// Controlador que gestiona la información de <see cref="Usuario">.
        /// </summary>
        List<Usuario> usuarios = new List<Usuario>();
        DatosLogin datosLogin = new DatosLogin();
        Usuario user = null;
        Rol role = null;
        /// <summary>
        /// Valida que el nombre de usuario(<paramref name="usuario"/>) y la <paramref name="contrasena"/> coincidan con un <see cref="Usuario"> registrado.
        /// </summary>
        /// <param name="usuario">Nombre de usuario ingresado.</param>
        /// <param name="contrasena">Contraseña ingresada.</param>
        /// <exception cref="GeneralExcepcion">Cuando el <paramref name="usuario"/> y la <paramref name="contrasena"/> son incorrectos, o cuando solo la <paramref name="contrasena"/> lo es.</exception>
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
            
            return ConvertirAnonimo(datosLogin.BuscarUsuario(user));

        }

        public void ActualizarUsuario(string nombre, string apellido, string usuario, string contrasena, string rol, string username)
        {
            role = new Rol(rol);
            user = new Usuario(nombre, apellido, usuario, contrasena, ObtenerRol(rol));
            datosLogin.ActualizarUsuario(user,username);// username va en el where del sp
        }

        /// <summary>
        /// Busca un el rol de un usuario específico que coincida con el <paramref name="usuario"/> ingresado.
        /// </summary>
        /// <param name="usuario">Nombre de usuario del <see cref="Usuario"/> a buscar.</param>
        /// <returns>El <see cref="Rol"/> del <see cref="Usuario"/> específico.</returns>
        public string RetornaRol(string usuario)
        {
            Usuario user = null;
            user = datosLogin.ConsultarUsuario(usuario);

            return user.Rol.Descripcion;
        }
        /// <summary>
        /// Valida que no exista un usuario con el mismo nombre de usuario(<paramref name="usuario"/>) registrado.
        /// </summary>
        /// <param name="usuario">Nombre de usuario del nuevo <see cref="Usuario"/> a insertar.</param>
        /// <exception cref="Exception">Cuando un <see cref="Usuario"/> con el mismo nombre de usuario ya se encuentra registrado.</exception>
        public void usuarioRepetido(string usuario)
        {
            Usuario user = null;
            user = datosLogin.ConsultarUsuario(usuario);
            if (user != null)
            {
                throw new Exception("Usuario ya registrado");
            }
        }
        /// <summary>
        /// Guarda los datos de un nuevo <see cref="Usuario"/>.
        /// </summary>
        /// <param name="nombre">Nombre del nuevo <see cref="Usuario"/>.</param>
        /// <param name="apellido">Apellido del nuevo <see cref="Usuario"/>.</param>
        /// <param name="usuario">Nombre de suario del nuevo <see cref="Usuario"/>.</param>
        /// <param name="contrasena">Contraseña del nuevo <see cref="Usuario"/>.</param>
        /// <param name="rol">Rol del nuevo <see cref="Usuario"/>.</param>
        public void GuardarUsuario(string nombre, string apellido, string usuario, string contrasena, string rol)
        {
            role = new Rol(rol);
            user = new Usuario(nombre, apellido,usuario, contrasena, ObtenerRol(rol));
            datosLogin.InsertarUsuario(user);
            
        }
        /// <summary>
        /// Busca un rol cuya descripción coincida con <paramref name="rol"/>.
        /// </summary>
        /// <param name="rol"></param>
        /// <returns>Un <see cref="Rol"/>.</returns>
        public Rol ObtenerRol(string rol)
        {
           return datosLogin.ConsultarRol(rol);
        }
    }

}
