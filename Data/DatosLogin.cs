using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Excepciones;

namespace Data
{
    public class DatosLogin
    {
        Conexion cn = new Conexion();
        SqlCommand cmd = new SqlCommand();

        //Consulta la base de datos y devuelve una lista con todos los usuarios.
        public List<Usuario> Consultar()
        {
            string sentenciaSQL = "SELECT * from Usuario";
            List<Usuario> nomina = ConsultarGeneral(sentenciaSQL);
            return nomina;
        }
        //Consulta la base de datos y devuelve un usuario cuyo nombre de usuario coincida con el argumento.
        public Usuario ConsultarUsuario(String  usuario)
        {
            string sentenciaSQL = "SELECT * FROM Usuario u INNER JOIN Rol r ON u.Id_Rol=r.Id_Rol  WHERE u.UserName='"+usuario+"'";
            Usuario user= ConsultarUser(sentenciaSQL);
            return user;
        }
        //Ejecuta en la base de datos una sentencia SQL dada por argumento y devuelve un Usuario correspondiente a los resultados.
        private Usuario ConsultarUser(string sentenciaSQL)
        {
            SqlDataReader dr = null;
            Usuario user = null;
           
            try
            {
                cn.Conectar();
                cmd.Connection = cn.Cn;
                cmd.CommandText = sentenciaSQL;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                   
                    user = new Usuario();
                    user.Id = Convert.ToInt32(dr["Id_Usuario"]);
                    user.Nombres = dr["Nombres"].ToString();
                    user.Apellidos = dr["Apellidos"].ToString();
                    user.Username = dr["UserName"].ToString();
                    user.Contrasena = dr["Password"].ToString();
                    user.Rol.Descripcion = dr["Descripcion"].ToString();
                    
                }
            }
            catch (SqlException)
            {
                throw new ConsultaFallida();
            }

            
            return user;
        }
        //Consulta la base de datos y devuelve un rol cuyadescripción coincida con el argumento. 
        public Rol ConsultarRol(string rol)
        {
            string sentenciaSQL = "SELECT * FROM Rol  WHERE Descripcion ='" + rol + "'";
            SqlDataReader dr = null;
            Rol role = null;

            try
            {
                cn.Conectar();
                cmd.Connection = cn.Cn;
                cmd.CommandText = sentenciaSQL;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {

                    role = new Rol();
                    role.Id = Convert.ToInt32(dr["Id_Rol"]);
                    role.Descripcion = dr["Descripcion"].ToString();

                }
            }
            catch (SqlException)
            {
                throw new ConsultaFallida();
            }


            return role;
        }
        //Recibe un usuario  e inserta al usuario en la base de datos del sistema.
        public void InsertarUsuario(Usuario user)
        {
            string sentenciaSQL = "INSERT INTO Usuario(Nombres, Apellidos, UserName,Password,Id_Rol )VALUES('" + 
                user.Nombres + "','" + user.Apellidos + "','" + user.Username + "','" + user.Contrasena + "','" + user.Rol.Id + "')";

            string RecuperarId = "Select @@identity";
            try
            {
                cn.Conectar();
                cmd.Connection = cn.Cn;
                cmd.CommandText = sentenciaSQL;
                cmd.ExecuteNonQuery();
                cmd.CommandText = RecuperarId;
            }
            catch (SqlException)
            {
                throw new ConsultaFallida();
            }
            cn.Cerrar();
        }
        //Ejecuta en la base de datos una sentencia SQL dada como argumento y devuelve una lista con toods los usuarios registrados. 
        private List<Usuario> ConsultarGeneral(string sentenciaSQL)
        {
            List<Usuario> usuarios = new List<Usuario>();
            SqlDataReader dr = null;
            Usuario user = null;

            try
            {
                cn.Conectar();
                cmd.Connection = cn.Cn;
                cmd.CommandText = sentenciaSQL;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
             
                    user = new Usuario();
                    user.Id = Convert.ToInt32(dr["Id_Usuario"]);
                    user.Username = dr["UserName"].ToString();
                    user.Contrasena = dr["Password"].ToString();
                    user.Rol.Descripcion = dr["Descripcion"].ToString();
                    usuarios.Add(user);
                }
            }
            catch (SqlException)
            {
                throw new ConsultaFallida();
            }

            return usuarios;
        }
    }
}
