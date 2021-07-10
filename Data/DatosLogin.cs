using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data
{
    public class DatosLogin
    {
        Conexion cn = new Conexion();
        SqlCommand cmd = new SqlCommand();


        public List<Usuario> Consultar()
        {
            string sentenciaSQL = "SELECT * from Usuario";
            List<Usuario> nomina = ConsultarGeneral(sentenciaSQL);
            return nomina;
        }

        public Usuario ConsultarUsuario(String  usuario)
        {
            string sentenciaSQL = "SELECT * FROM Usuario u INNER JOIN Rol r ON u.Id_Rol=r.Id_Rol  WHERE u.UserName='"+usuario+"'";
            Usuario user= ConsultarUser(sentenciaSQL);
            return user;
        }

        private Usuario ConsultarUser(string sentenciaSQL)
        {
            string msj = cn.conectar();
            SqlDataReader dr = null;
            Usuario user = null;
           
            try
            {
                cmd.Connection = cn.Cn;
                cmd.CommandText = sentenciaSQL;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Entro a leer");
                    user = new Usuario();
                    user.Id = Convert.ToInt32(dr["Id_Usuario"]);
                    user.Nombres = dr["Nombres"].ToString();
                    user.Apellidos = dr["Apellidos"].ToString();
                    user.Username = dr["UserName"].ToString();
                    user.Contrasena = dr["Password"].ToString();
                    user.Rol.Descripcion = dr["Descripcion"].ToString();
                    
                }
            }
            catch (Exception ex)
            {
                msj = "0 " + ex.Message;
            }

            
            return user;
        }
        private List<Usuario> ConsultarGeneral(string sentenciaSQL)
        {
            string msj = cn.conectar();
     
            List<Usuario> usuarios = new List<Usuario>();
            SqlDataReader dr = null;
            Usuario user = null;

            try
            {
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
            catch (SqlException ex)
            {
                msj = "0 " + ex.Message;
            }

            return usuarios;
        }
        /*
        public string Insertar(Login login)
        {
            Conexion cn = new Conexion();
            string msj = cn.conectar();

            string sentenciaSQL = "INSERT INTO Usuario(Nombres,Apellidos,Usuario,Contrasena)VALUES('" + login.Nombres + "','" + login.Apellidos + "','" + login.Usuario + "','" + login.Contrasena + "')";
            string RecuperarId = "Select @@identity";

            try
            {
                if (msj[0] == '1')
                {
                    cmd.Connection = cn.Cn;
                    cmd.CommandText = sentenciaSQL;
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = RecuperarId;
                    msj = "1";
                    MessageBox.Show("Insertado con exito");
                }
                else
                {
                    MessageBox.Show("Error: " + msj);
                }
                cn.cerrar();
            }
            catch (SqlException ex)
            {
                msj = "0 " + ex.Message;
            }
            return msj;
        }

        public List<Login> ConsultarApellido(string apellidos)
        {
            string sentenciaSQL = "SELECT * from Usuario Where Usuario.Apellidos Like '%" + apellidos + "%'";
            List<Login> nomina = ConsultarGeneral(sentenciaSQL);
            return nomina;
        }

        public string Actualizar(Login login, int id)
        {
            Conexion cn = new Conexion();
            string msj = cn.conectar();


            string sentenciaSQL = "UPDATE Usuario SET Usuario.Nombres='" + login.Nombres + "', Usuario.Apellidos='" + login.Apellidos + "', Usuario.Usuario= '" + login.Usuario + "', Usuario.Contrasena= '" + login.Contrasena + "' WHERE Usuario.Id='" + id + "'";

            try
            {
                cmd.Connection = cn.Cn;
                cmd.CommandText = sentenciaSQL;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Actualizado Usuario");
                msj = "1";
            }
            catch (SqlException ex)
            {
                msj = "0 " + ex.Message;
                cn.cerrar();
            }
            return msj;
        }



        public string Eliminar(int id)
        {
            Conexion cn = new Conexion();
            string sentenciaSQL = "DELETE FROM Usuario WHERE Id=" + id;
            string msj = cn.conectar();
            try
            {
                if (msj[0] == '1')
                {
                    cmd.Connection = cn.Cn;
                    cmd.CommandText = sentenciaSQL;
                    cmd.ExecuteNonQuery();
                    msj = "1";
                    MessageBox.Show("Eliminado con exito");
                }
                else
                {
                    cn.cerrar();
                }
            }
            catch (SqlException ex)
            {
                msj = "0 " + ex.Message;
            }
            return msj;
        }

       */

    }
}
