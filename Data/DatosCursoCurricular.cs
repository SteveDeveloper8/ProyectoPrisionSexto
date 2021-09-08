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
    public class DatosCursoCurricular
    {
        Conexion conexion;
        //Inicializa los objetos de cliente SQL necesarios.
        public DatosCursoCurricular()
        {
            conexion = new Conexion();
        }
        public void InsertarEstudio(ActividadCurricular actividad)
        {
            //Crear comando para procedimeitnos almacenados.
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "spr_ingresar_estudio";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            //Lista de parámetros para el procedimeinto almacenado.
            SqlParameter parametroModalidad= new SqlParameter("@modalidad", System.Data.SqlDbType.VarChar);
            parametroModalidad.Direction = System.Data.ParameterDirection.Input;
            parametroModalidad.Value = actividad.Modalidad;
            comando.Parameters.Add(parametroModalidad);
            SqlParameter parametroDescripcion = new SqlParameter("@descripcion", System.Data.SqlDbType.VarChar);
            parametroDescripcion.Direction = System.Data.ParameterDirection.Input;
            parametroDescripcion.Value = actividad.Descripcion;
            comando.Parameters.Add(parametroDescripcion);
            SqlParameter parametroRemision = new SqlParameter("@remisionCondena", System.Data.SqlDbType.Int);
            parametroRemision.Direction = System.Data.ParameterDirection.Input;
            parametroRemision.Value = actividad.RemisionTotal;
            comando.Parameters.Add(parametroRemision);
            SqlParameter parametroCupos = new SqlParameter("@cuposDisponibles", System.Data.SqlDbType.Int);
            parametroCupos.Direction = System.Data.ParameterDirection.Input;
            parametroCupos.Value = actividad.Cupos;
            comando.Parameters.Add(parametroCupos);
            SqlParameter parametroFechaInicio = new SqlParameter("@fechaInicio", System.Data.SqlDbType.DateTime);
            parametroFechaInicio.Direction = System.Data.ParameterDirection.Input;
            parametroFechaInicio.Value = actividad.FechaInicio;
            comando.Parameters.Add(parametroFechaInicio);
            SqlParameter parametroFechaFin = new SqlParameter("@fechaFin", System.Data.SqlDbType.DateTime);
            parametroFechaFin.Direction = System.Data.ParameterDirection.Input;
            parametroFechaFin.Value = actividad.FechaInicio;
            comando.Parameters.Add(parametroFechaFin);

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

        public void EliminarEstudio(string descripcion, string modalidad)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "spr_eliminar_estudios";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter parametroDescripcion = new SqlParameter("@descripcion", System.Data.SqlDbType.VarChar);
            parametroDescripcion.Direction = System.Data.ParameterDirection.Input;
            parametroDescripcion.Value = descripcion;
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
        /// <summary>
        /// Consulta la tabla Estudio y trae los datos de las actividades que coincidan con la <paramref name="descripcion"/>.
        /// </summary>
        /// <param name="descripcion">Es el nombre de la actividad curricular.</param>
        /// <returns>Una lista de obejetos con los datos de cada <seealso cref="ActividadCurricular"/>.</returns>
        public List<ActividadCurricular> BuscarDescripcionEstudio(string descripcion)
        {
            SqlDataReader dr = null;
            List<ActividadCurricular> actividades;
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "spr_buscar_estudio";
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
        
        private List<ActividadCurricular> LeerResultados(SqlDataReader datos)
        {
            ActividadCurricular actividad = null;
            List<ActividadCurricular> actividades = new List<ActividadCurricular>();
            while (datos.Read())
            {
                actividad = new ActividadCurricular();
                actividad.Id = Convert.ToInt32(datos["Id_Estudios"]);
                actividad.Modalidad = datos["MetodoEstudio"].ToString();
                actividad.Descripcion = datos["Descripcion"].ToString();
                actividad.RemisionTotal = Convert.ToInt32(datos["RemisionCondena"]);
                actividad.Cupos = Convert.ToInt32(datos["CuposDisponibles"]);
                actividad.FechaInicio = Convert.ToDateTime(datos["FechaInicia"]);
                actividad.FechaFin = Convert.ToDateTime(datos["FechaFin"]);
                actividades.Add(actividad);
            }
            return actividades;
        }
        public List<ActividadCurricular> ConsultarCursosDistancia()
        {
            SqlDataReader dr = null;
            List<ActividadCurricular> cursos;
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "spr_consultar_estudios_distancia";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                conexion.Conectar();
                comando.Connection = conexion.Cn;
                dr = comando.ExecuteReader();

                cursos = LeerResultados(dr);
            }
            catch (SqlException)
            {
                throw new ConsultaFallida();
            }
            return cursos;
        }

        public List<ActividadCurricular> BuscarModalidadEstudio(string modalidad)
        {
            SqlDataReader dr = null;
            List<ActividadCurricular> actividades;
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "spr_consultar_estudios_modalidad";
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

        public List<ActividadCurricular> BuscarDescripcionModalidadEstudio(string descripcion, string modalidad)
        {
            SqlDataReader dr = null;
            List<ActividadCurricular> actividades;
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "spr_consultar_estudios_descripcion_modalidad";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter parametroDescripcion = new SqlParameter("@descripcion", System.Data.SqlDbType.VarChar);
            parametroDescripcion.Direction = System.Data.ParameterDirection.Input;
            parametroDescripcion.Value = descripcion;
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
    }
}
