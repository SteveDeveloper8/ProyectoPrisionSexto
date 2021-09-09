using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Data.Excepciones;
using Model;

namespace Data
{
    public class DatosActividadPractica
    {
        Conexion conexion;
        //Inicializa los objetos de cliente SQL necesarios.
        public DatosActividadPractica()
        {
            conexion = new Conexion();
        }
        public void InsertarActividad(ActividadPractica actividad)
        {
            //Crear comando para procedimeitnos almacenados.
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "spr_ingresar_oficio";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            //Lista de parámetros para el procedimeinto almacenado.
            SqlParameter parametroModalidad = new SqlParameter("@modalidad", System.Data.SqlDbType.VarChar);
            parametroModalidad.Direction = System.Data.ParameterDirection.Input;
            parametroModalidad.Value = actividad.Modalidad;
            comando.Parameters.Add(parametroModalidad);
            SqlParameter parametroDescripcion = new SqlParameter("@descripcion", System.Data.SqlDbType.VarChar);
            parametroDescripcion.Direction = System.Data.ParameterDirection.Input;
            parametroDescripcion.Value = actividad.Descripcion;
            comando.Parameters.Add(parametroDescripcion);
            SqlParameter parametroRemision = new SqlParameter("@remisionCondena", System.Data.SqlDbType.Int);
            parametroRemision.Direction = System.Data.ParameterDirection.Input;
            parametroRemision.Value = actividad.RemisionDiaria;
            comando.Parameters.Add(parametroRemision);
            SqlParameter parametroCupos = new SqlParameter("@cuposDisponibles", System.Data.SqlDbType.Int);
            parametroCupos.Direction = System.Data.ParameterDirection.Input;
            parametroCupos.Value = actividad.Cupos;
            comando.Parameters.Add(parametroCupos);

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

        public void EliminarActividad(string descripcion, string modalidad)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "spr_eliminar_oficio";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter parametroDescripcion = new SqlParameter("@descripcion", System.Data.SqlDbType.VarChar);
            parametroDescripcion.Direction = System.Data.ParameterDirection.Input;
            parametroDescripcion.Value = descripcion;
            comando.Parameters.Add(parametroDescripcion);
            SqlParameter parametroModalidad = new SqlParameter("@modalidad", System.Data.SqlDbType.VarChar);
            parametroModalidad.Direction = System.Data.ParameterDirection.Input;
            parametroModalidad.Value = modalidad;
            comando.Parameters.Add(parametroModalidad);

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

        public List<ActividadPractica> ConsultarActvidadPractica()
        {
            SqlDataReader dr = null;
            List<ActividadPractica> actividades;
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "spr_consultar_oficios";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                conexion.Conectar();
                comando.Connection = conexion.Cn;
                dr = comando.ExecuteReader();

                actividades = LeerResultados(dr);
            }
            catch (SqlException)
            {
                throw new ConsultaFallida();
            }
            return actividades;
        }

        public List<ActividadPractica> BuscarDescripcionActividad(string descripcion)
        {
            SqlDataReader dr = null;
            List<ActividadPractica> actividades;
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "spr_buscar_oficio";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter parametroDescripcion = new SqlParameter("@descripcion", System.Data.SqlDbType.VarChar);
            parametroDescripcion.Direction = System.Data.ParameterDirection.Input;
            parametroDescripcion.Value = descripcion;
            comando.Parameters.Add(parametroDescripcion);
            try
            {
                conexion.Conectar();
                comando.Connection = conexion.Cn;
                dr = comando.ExecuteReader();

                actividades = LeerResultados(dr);
            }
            catch (SqlException)
            {
                throw new ConsultaFallida();
            }
            return actividades;
        }

        public List<ActividadPractica> BuscarModalidadActividad(string modalidad)
        {
            SqlDataReader dr = null;
            List<ActividadPractica> actividades;
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "spr_buscar_oficio_modalidad";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter parametroModalidad = new SqlParameter("@modalidad", System.Data.SqlDbType.VarChar);
            parametroModalidad.Direction = System.Data.ParameterDirection.Input;
            parametroModalidad.Value = modalidad;
            comando.Parameters.Add(parametroModalidad);
            try
            {
                conexion.Conectar();
                comando.Connection = conexion.Cn;
                dr = comando.ExecuteReader();

                actividades = LeerResultados(dr);
            }
            catch (SqlException)
            {
                throw new ConsultaFallida();
            }
            return actividades;
        }

        public List<ActividadPractica> BuscarDescripcionModalidadActividad(string descripcion, string modalidad)
        {
            SqlDataReader dr = null;
            List<ActividadPractica> actividades;
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "spr_consultar_oficio_descripcion_modalidad";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter parametroDescripcion = new SqlParameter("@descripcion", System.Data.SqlDbType.VarChar);
            parametroDescripcion.Direction = System.Data.ParameterDirection.Input;
            parametroDescripcion.Value = descripcion;
            comando.Parameters.Add(parametroDescripcion);
            SqlParameter parametroModalidad = new SqlParameter("@modalidad", System.Data.SqlDbType.VarChar);
            parametroModalidad.Direction = System.Data.ParameterDirection.Input;
            parametroModalidad.Value = modalidad;
            comando.Parameters.Add(parametroModalidad);
            try
            {
                conexion.Conectar();
                comando.Connection = conexion.Cn;
                dr = comando.ExecuteReader();

                actividades = LeerResultados(dr);
            }
            catch (SqlException)
            {
                throw new ConsultaFallida();
            }
            return actividades;
        }
        private List<ActividadPractica> LeerResultados(SqlDataReader datos)
        {
            ActividadPractica actividad = null;
            List<ActividadPractica> actividades = new List<ActividadPractica>();
            while (datos.Read())
            {
                actividad = new ActividadPractica();
                actividad.Id = Convert.ToInt32(datos["Id_Oficio"]);
                actividad.Modalidad = datos["Metodo_Oficio"].ToString();
                actividad.Descripcion = datos["Descripcion"].ToString();
                actividad.RemisionDiaria = Convert.ToInt32(datos["RemisionCondena"]);
                actividad.Cupos = Convert.ToInt32(datos["CuposDisponibles"]);
                actividades.Add(actividad);
            }
            return actividades;
        }
    }
}
