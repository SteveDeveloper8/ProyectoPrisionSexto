﻿using Model;
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
        Conexion conexion = new Conexion();
        //Inicializa los objetos de cliente SQL necesarios.
        public DatosLogin()
        {
            conexion = new Conexion();
        }
        //Consulta la base de datos y devuelve una lista con todos los usuarios.
        public List<Usuario> Consultar()
        {
            List<Usuario> nomina = ConsultarGeneral();
            return nomina;
        }
        //Consulta la base de datos y devuelve un usuario cuyo nombre de usuario coincida con el argumento.
        public Usuario ConsultarUsuario(String usuario)
        {
            SqlDataReader dr = null;
            Usuario user = null;
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "spr_buscar_usuario";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter parametroUsuario = new SqlParameter();
            parametroUsuario.ParameterName = "@nombre_usuario";
            parametroUsuario.SqlDbType = System.Data.SqlDbType.VarChar;
            parametroUsuario.Direction = System.Data.ParameterDirection.Input;
            parametroUsuario.Value = usuario;
            comando.Parameters.Add(parametroUsuario);
            try
            {
                conexion.Conectar();
                comando.Connection = conexion.Cn;
                dr = comando.ExecuteReader();

                user= LeerResultados(dr)[0];
            }
            catch (SqlException)
            {
                throw new ConsultaFallida();
            }

            
            return user;
        }
        //Lee un DataReader lleno con datos de una consulta a la tabla de usuarios y devuelve una lista de usuarios recuperados.
        private List<Usuario> LeerResultados(SqlDataReader datos)
        {
            Usuario user = null;
            List<Usuario> usuarios = new List<Usuario>();
            while (datos.Read())
            {

                user = new Usuario();
                user.Id = Convert.ToInt32(datos["Id_Usuario"]);
                user.Username = datos["UserName"].ToString();
                user.Contrasena = datos["Password"].ToString();
                user.Rol.Descripcion = datos["Descripcion"].ToString();
                usuarios.Add(user);
            }
            return usuarios;
        }
        //Consulta la base de datos y devuelve un rol cuya descripción coincida con el argumento. 
        public Rol ConsultarRol(string rol)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "spr_buscar_rol";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter parametroRol = new SqlParameter();
            parametroRol.ParameterName = "@nombre_rol";
            parametroRol.SqlDbType = System.Data.SqlDbType.VarChar;
            parametroRol.Direction = System.Data.ParameterDirection.Input;
            parametroRol.Value = rol;
            comando.Parameters.Add(parametroRol);
            SqlDataReader dr = null;
            Rol role = null;
            try
            {
                conexion.Conectar();
                comando.Connection = conexion.Cn;
                dr = comando.ExecuteReader();
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
            //Crear comando para procedimeitnos almacenados.
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "spr_ingresar_usuario";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            //Lista de parámetros para el procedimeinto almacenado
            SqlParameter parametroNombre = new SqlParameter();
            parametroNombre.ParameterName = "@nombres";
            parametroNombre.SqlDbType = System.Data.SqlDbType.VarChar;
            parametroNombre.Direction = System.Data.ParameterDirection.Input;
            parametroNombre.Value = user.Nombres;
            comando.Parameters.Add(parametroNombre);
            SqlParameter parametroApellido = new SqlParameter();
            parametroApellido.ParameterName = "@apellido";
            parametroApellido.SqlDbType = System.Data.SqlDbType.VarChar;
            parametroApellido.Direction = System.Data.ParameterDirection.Input;
            parametroApellido.Value = user.Apellidos;
            comando.Parameters.Add(parametroApellido);
            SqlParameter parametroUsername = new SqlParameter();
            parametroUsername.ParameterName = "@username";
            parametroUsername.SqlDbType = System.Data.SqlDbType.VarChar;
            parametroUsername.Direction = System.Data.ParameterDirection.Input;
            parametroUsername.Value = user.Username;
            comando.Parameters.Add(parametroUsername);
            SqlParameter parametroPassword = new SqlParameter();
            parametroPassword.ParameterName = "@password";
            parametroPassword.SqlDbType = System.Data.SqlDbType.VarChar;
            parametroPassword.Direction = System.Data.ParameterDirection.Input;
            parametroPassword.Value = user.Contrasena;
            comando.Parameters.Add(parametroPassword);
            SqlParameter parametroRol = new SqlParameter();
            parametroRol.ParameterName = "@id_rol";
            parametroRol.SqlDbType = System.Data.SqlDbType.Int;
            parametroRol.Direction = System.Data.ParameterDirection.Input;
            parametroRol.Value = user.Rol.Id;
            comando.Parameters.Add(parametroRol);
            try
            {
                conexion.Conectar();
                comando.Connection = conexion.Cn;
                comando.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw new ConsultaFallida();
            }
            conexion.Cerrar();
        }
        //Ejecuta en la base de datos una sentencia SQL dada como argumento y devuelve una lista con toods los usuarios registrados. 
        private List<Usuario> ConsultarGeneral()
        {
            SqlDataReader dr = null;
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "spr_consultar_usuarios";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                conexion.Conectar();
                comando.Connection = conexion.Cn;
                dr = comando.ExecuteReader();

                usuarios = LeerResultados(dr);
            }
            catch (SqlException)
            {
                throw new ConsultaFallida();
            }

            return usuarios;
        }
    }
}
