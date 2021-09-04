using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Data.Excepciones;
namespace Data
{
    public class DatosRecluso
    {
        Conexion conexion;
        //Inicializa los objetos de cliente SQL necesarios.
        public DatosRecluso()
        {
            conexion = new Conexion();
        }
        //Busca el expediente que tenga el número de cédula del recluso y devuelve un objeto Expediente.
        public Expediente BuscarExpediente(string cedula)
        {
            SqlDataReader dr = null;
            SqlCommand comando = new SqlCommand();
            Expediente expediente = null;
            comando.CommandText = "spr_consultar_expediente";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter parametroCedula = new SqlParameter();
            parametroCedula.ParameterName = "@cedula_recluso";
            parametroCedula.SqlDbType = System.Data.SqlDbType.VarChar;
            parametroCedula.Direction = System.Data.ParameterDirection.Input;
            parametroCedula.Value = cedula;
            comando.Parameters.Add(parametroCedula);
            try
            {
                comando.Connection = conexion.Cn;
                dr = comando.ExecuteReader();

                if (dr.Read())
                {
                    expediente = new Expediente();
                    expediente.Id = Convert.ToInt32(dr["Id_Expediente"]);
                    expediente.Codigo = (dr["Codigo"]).ToString();
                }
            }
            catch (SqlException)
            {
                throw new ConsultaFallida();
            }
            conexion.Cerrar();
            return expediente;
        }
        //Recibe un objeto Recluso y lo guarda en la base de datos del sistema.
        public void InsertarRecluso(Recluso recluso)
        {
            //Crear comando para procedimeitnos almacenados.
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "spr_ingresar_recluso";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            //Lista de parámetros para el procedimeinto almacenado
            SqlParameter parametroCodigo = new SqlParameter();
            parametroCodigo.ParameterName = "@codigo";
            parametroCodigo.SqlDbType = System.Data.SqlDbType.VarChar;
            parametroCodigo.Direction = System.Data.ParameterDirection.Input;
            parametroCodigo.Value = recluso.Codigo;
            comando.Parameters.Add(parametroCodigo);
            SqlParameter parametroCedula = new SqlParameter();
            parametroCedula.ParameterName = "@cedula";
            parametroCedula.SqlDbType = System.Data.SqlDbType.VarChar;
            parametroCedula.Direction = System.Data.ParameterDirection.Input;
            parametroCedula.Value = recluso.Cedula;
            comando.Parameters.Add(parametroCedula);
            SqlParameter parametroNombre = new SqlParameter();
            parametroNombre.ParameterName = "@nombres";
            parametroNombre.SqlDbType = System.Data.SqlDbType.VarChar;
            parametroNombre.Direction = System.Data.ParameterDirection.Input;
            parametroNombre.Value = recluso.Nombre;
            comando.Parameters.Add(parametroNombre);
            SqlParameter parametroApellido = new SqlParameter();
            parametroApellido.ParameterName = "@apellidos";
            parametroApellido.SqlDbType = System.Data.SqlDbType.VarChar;
            parametroApellido.Direction = System.Data.ParameterDirection.Input;
            parametroApellido.Value = recluso.Apellidos;
            comando.Parameters.Add(parametroApellido);
            SqlParameter parametroFecha = new SqlParameter();
            parametroFecha.ParameterName = "@fecha_Nac";
            parametroFecha.SqlDbType = System.Data.SqlDbType.DateTime;
            parametroFecha.Direction = System.Data.ParameterDirection.Input;
            parametroFecha.Value = recluso.Fecha;
            comando.Parameters.Add(parametroFecha);
            SqlParameter parametroGenero = new SqlParameter();
            parametroGenero.ParameterName = "@genero";
            parametroGenero.SqlDbType = System.Data.SqlDbType.VarChar;
            parametroGenero.Direction = System.Data.ParameterDirection.Input;
            parametroGenero.Value = recluso.Genero;
            comando.Parameters.Add(parametroGenero);
            SqlParameter parametroExpediente = new SqlParameter();
            parametroExpediente.ParameterName = "@id_Expediente";
            parametroExpediente.SqlDbType = System.Data.SqlDbType.Int;
            parametroExpediente.Direction = System.Data.ParameterDirection.Input;
            parametroExpediente.Value = recluso.Expediente.Id;
            comando.Parameters.Add(parametroExpediente);

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
        //Consulta la base de datos y devuelve una lista con todos los reclusos registrados en el sistema.
        public List<Object> ConsultarReclusos()
        {
            List<Object> reclusos = ConsultarGeneral();
            return reclusos;
        }
        //Consulta la base de datos y devuelve una lista de cargos que pertenezcan al expediente cuyo código recibe.
        public List<Cargo> ConsultarCargos(string codigoExpediente)
        {
            SqlDataReader dr = null;
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "spr_consultar_cargos";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter parametroCedula = new SqlParameter();
            parametroCedula.ParameterName = "@codigo_expediente";
            parametroCedula.SqlDbType = System.Data.SqlDbType.NChar;
            parametroCedula.Direction = System.Data.ParameterDirection.Input;
            parametroCedula.Value = codigoExpediente;
            comando.Parameters.Add(parametroCedula);
            List<Cargo> cargos = new List<Cargo>();
            Cargo cargo= null;
            try
            {
                conexion.Conectar();
                comando.Connection = conexion.Cn;
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    cargo = new Cargo();
                    cargo.LugarHechos = new Lugar();
                    cargo.Delito = dr["Delito"].ToString();
                    cargo.Descripcion = dr["Descripcion"].ToString();
                    cargo.FechaHechos = Convert.ToDateTime(dr["Fecha"].ToString());
                    cargo.LugarHechos.NombreLocalidad = dr["Localidad"].ToString();
                    cargo.LugarHechos.NombreCiudad = dr["Ciudad"].ToString();
                    cargo.LugarHechos.NombrePais = dr["Pais"].ToString();
                    cargos.Add(cargo);
                }
            }
            catch (SqlException)
            {
                throw new ConsultaFallida();
            }
            return cargos;
        }
        //Consulta la base de datos y devuelve un objeto con los datos de un recluso cuya cédula sea igual al argumento.
        public object BuscarRecluso(string cedula)
        {
            List<Object> reclusos = ConsultarBusqueda(cedula);
            if (reclusos.Count > 0)
                return reclusos[0];
            else
                return null;
        }
        //Ejecuta en la base de datos una sntencia SQL dada por parámetros y devuelve una lista de reclusos correspondiente a los reultados.
        private List<Object> ConsultarGeneral()
        {
            SqlDataReader dr = null;
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "spr_consultar_reclusos";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                conexion.Conectar();
                comando.Connection = conexion.Cn;
                dr = comando.ExecuteReader();

                return LeerResultados(dr);

            }
            catch (SqlException)
            {
                throw new ConsultaFallida();
            }
        }
        //Lee un DataReader lleno con datos de una consulta a la tabla de reclusos y devuelve una lista de Reclusos recuperados.
        private List<Object> LeerResultados(SqlDataReader datos)
        {
            List<Object> reclusos = new List<Object>();
            while (datos.Read())
            {
               Recluso recluso = new Recluso();
               recluso.Expediente = new Expediente();
               recluso.Id = Convert.ToInt32(datos["Id_Recluso"]);
               recluso.Codigo = datos["Codigo"].ToString();
               recluso.Nombre = datos["Nombres"].ToString();
               recluso.Apellidos = datos["Apellidos"].ToString();
               recluso.Cedula = datos["Cedula"].ToString();
               recluso.Fecha = Convert.ToDateTime(datos["Fecha_Nac"].ToString());
               recluso.Genero = datos["Genero"].ToString();
               recluso.Expediente.Id = Convert.ToInt32(datos["Id_Expediente"]);
               reclusos.Add(recluso);
            }
            return reclusos;
        }
        //Busca un recluso por su número de cédula en la base de datos y devuelve un objeto recluso.
        private List<Object> ConsultarBusqueda(string cedula)
        {
            SqlDataReader dr = null;
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "spr_buscar_recluso";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter parametroCedula = new SqlParameter();
            parametroCedula.ParameterName = "@cedula_rec";
            parametroCedula.SqlDbType = System.Data.SqlDbType.VarChar;
            parametroCedula.Direction = System.Data.ParameterDirection.Input;
            parametroCedula.Value = cedula;
            comando.Parameters.Add(parametroCedula);
            try
            {
                conexion.Conectar();
                comando.Connection = conexion.Cn;
                dr = comando.ExecuteReader();

                return LeerResultados(dr);

            }
            catch (SqlException)
            {
                throw new ConsultaFallida();
            }
        }
    }
}
