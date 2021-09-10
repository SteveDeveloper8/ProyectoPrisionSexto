using Data;
using Data.Excepciones;
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
    /// <summary>
    /// Controlador que gestiona la informaci�n de <see cref="Usuario">.
    /// </summary>
    public class ControladorUsuario
    {
        /// <summary>
        /// Atributo tipo <see cref="DatosLogin"/> que permite el acceso a la capa de Datos.
        /// </summary>
        DatosLogin datosLogin = new DatosLogin();
        /// <summary>
        /// Instancia de <see cref="Usuario"/> sirve como auxiliar para los m�todos de control.
        /// </summary>
        Usuario user = null;
        /// <summary>
        /// Instancia de <see cref="Rol"/> sirve como auxiliar para los m�todos de control.
        /// </summary>
        Rol role = null;
        /// <summary>
        /// Valida que el nombre de usuario(<paramref name="usuario"/>) y la <paramref name="contrasena"/> coincidan con un <see cref="Usuario"> registrado.
        /// </summary>
        /// <param name="usuario">Nombre de usuario ingresado.</param>
        /// <param name="contrasena">Contrase�a ingresada.</param>
        /// <exception cref="GeneralExcepcion">Cuando el <paramref name="usuario"/> y la <paramref name="contrasena"/> son incorrectos, o cuando solo la <paramref name="contrasena"/> lo es.</exception>
        public bool validarLogin(string usuario, string contrasena)
        {

            Usuario user = null;
            user = datosLogin.ConsultarUsuario(usuario);

            if (user == null)
            {
                throw new GeneralExcepcion("Usuario y/o contrasena incorrecta");
                return false;
            }
            else if (user.Contrasena!=contrasena)
            {
                throw new GeneralExcepcion("Contrasena incorrecta");
                return false;
            }
            return true;
        }
        /// <summary>
        /// Lista a todos los datos de usuarios del sistema.
        /// </summary>
        /// <returns>Una lista con la informaci�n de cada <see cref="Usuario"/> registrado en el sistema.</returns>
        /// <exception cref="GeneralExcepcion">Cuando no se encontr� ning�n <see cref="Usuario"/> registrado en el sistema.</exception>
        public List<Object> ListarUsuarios()
        {
            List<Usuario> usuarios = datosLogin.Consultar();

            if (usuarios.Count <= 0)
                throw new GeneralExcepcion("No se encontraron usuarios registrados");
            else
                return GetListaDatosUsuarios(usuarios);
        }
        /// <summary>
        /// Convierte una lista de <seealso cref=Usuario"/>s en una lista de objetos an�nimos(<seealso cref="Object"/>) que la capa de vista pueda entender.
        /// </summary>
        /// <param name="usuarios">Lista de usuarios a convertir.</param>
        /// <returns>Una lista de objetos an�nimos(<seealso cref="Object"/>).</returns>
        private List<Object> GetListaDatosUsuarios(List<Usuario> usuarios)
        {
            List<Object> cargosDatos = new List<object>();
            foreach(Usuario usuario in usuarios)
            {
                cargosDatos.Add(ConvertirAnonimo(usuario));
            }
            return cargosDatos;
        }
        /// <summary>
        /// Convierte un objeto <seealso cref="Usuario"/> en un objeto an�nimo(<seealso cref="Object"/>) que la capa de Vista puede entender.
        /// </summary>
        /// <param name="usuario">Usuario a convertir.</param>
        /// <returns>Un <seealso cref="Object"/> con los datos del <paramref name="usuario"/>.</returns>
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
        /// <summary>
        /// Busca un <see cref="Recluso"/> cuyo nombre de usuario coincida con <paramref name="user"/>.
        /// </summary>
        /// <param name="user">Nombre de usuario del <see cref="Usuario"/> a buscar.</param>
        /// <returns>Un <see cref="Object"/> con los datos del <see cref="Usuario"/>.</returns>
        public Object BuscarUsuario(string user)
        {
            
            return ConvertirAnonimo(datosLogin.ConsultarUsuario(user));

        }
        /// <summary>
        /// Actualiza los datos de un <see cref="Usuario"/> en espec�fico.
        /// </summary>
        /// <param name="nombre">Nuevo nombre del <see cref="Usuario"/>.</param>
        /// <param name="apellido">Nuevo apellido del <see cref="Usuario"/>.</param>
        /// <param name="usuario">Nombre de usuario para identificar el <see cref="Usuario"/> a actualizar.</param>
        /// <param name="contrasena">Nueva contrase�a del <see cref="Usuario"/>.</param>
        /// <param name="rol">Nuevo <see cref="Rol"/> del <see cref="Usuario"/>.</param>
        /// <returns>True si se actualiz� correctamente, caso contrario devuelver false.</returns>
        public bool ActualizarUsuario(string nombre, string apellido, string usuario, string contrasena, string rol)
        {
            role = new Rol(rol);
            user = new Usuario(nombre, apellido, usuario, contrasena, ObtenerRol(rol));
            try
            {
                datosLogin.ActualizarUsuario(user);
                return true;
            }
            catch (ConsultaFallida)
            {
                return false;
            }
        }

        /// <summary>
        /// Busca un el rol de un usuario espec�fico que coincida con el <paramref name="usuario"/> ingresado.
        /// </summary>
        /// <param name="usuario">Nombre de usuario del <see cref="Usuario"/> a buscar.</param>
        /// <returns>El <see cref="Rol"/> del <see cref="Usuario"/> espec�fico.</returns>
        public string RetornaRol(string usuario)
        {
            user = null;
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
        /// <param name="contrasena">Contrase�a del nuevo <see cref="Usuario"/>.</param>
        /// <param name="rol">Rol del nuevo <see cref="Usuario"/>.</param>
        /// <returns>True si se insert� correctamente, caso contrario devuelver false.</returns>
        public bool GuardarUsuario(string nombre, string apellido, string usuario, string contrasena, string rol)
        {
            role = new Rol(rol);
            user = new Usuario(nombre, apellido,usuario, contrasena, ObtenerRol(rol));
            try
            {
                datosLogin.InsertarUsuario(user);
                return true;
            }
            catch (ConsultaFallida)
            {
                return false;
            }
        }
        /// <summary>
        /// Busca un rol cuya descripci�n coincida con <paramref name="rol"/>.
        /// </summary>
        /// <param name="rol"></param>
        /// <returns>Un <see cref="Rol"/>.</returns>
        public Rol ObtenerRol(string rol)
        {
           return datosLogin.ConsultarRol(rol);
        }
    }

}
