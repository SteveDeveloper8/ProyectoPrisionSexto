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
        public Expediente buscarExpedienteBD(string cedula)
        {
            string sentenciaSQL = "Select * from Expediente e Where e.Cedula_Recluso='" + cedula + "'";
            conexion.Conectar();
            SqlDataReader dr = null;
            Expediente expe = null;
            SqlCommand comando = new SqlCommand();
            try
            {
                comando.Connection = conexion.Cn;
                comando.CommandText = sentenciaSQL;
                dr = comando.ExecuteReader();

                if (dr.Read())
                {
                    expe = new Expediente();
                    expe.Id = Convert.ToInt32(dr["Id_Expediente"]);
                    expe.Codigo = (dr["Codigo"]).ToString();
                }
            }
            catch (SqlException)
            {
                throw new ConsultaFallida();
            }
            conexion.Cerrar();
            return expe;
        }
        //Recibe un objeto Recluso y lo guarda en la base de datos del sistema.
        public void InsertarRecluso(Recluso recluso)
        {
            string sentenciaSQL = "INSERT INTO Recluso(Codigo,Cedula,Nombres,Apellidos,Fecha_Nac,Genero,Id_Expediente)VALUES('" 
                + recluso.Codigo + "','" + recluso.Cedula + "','" + recluso.Nombre + "','" + recluso.Apellidos + "','" 
                + recluso.Fecha.ToString("yyyy-MM-dd") + "','" + recluso.Genero + "'," + recluso.Expediente.Id + ")";
            string RecuperarId = "Select @@identity";
            SqlCommand comando = new SqlCommand();
            try
            {
                    conexion.Conectar();
                    comando.Connection = conexion.Cn;
                    comando.CommandText = sentenciaSQL;
                    comando.ExecuteNonQuery();
                    comando.CommandText = RecuperarId;      
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
            string sentenciaSQL =
                "SELECT c.Delito, c.Descripcion, c.Fecha, l.Nombre_Localidad," +
                "ci.Nombre_Ciudad, p.Nombre_Pais " +
                "FROM Expediente As e , Cargo As c, Localidad As l, Ciudad As ci, Pais As p" +
                " WHERE e.Codigo= '" + codigoExpediente +"' AND " +
                " e.Id_Expediente = c.Id_Expediente AND c.Id_Localidad = l.Id_Localidad" +
                " AND l.Id_Ciudad=ci.Id_Ciudad AND ci.Id_Pais=p.Id_Pais;";
            List<Cargo> cargos = new List<Cargo>();
            SqlDataReader dr = null;
            Cargo cargo= null;
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.Conectar();
                comando.Connection = conexion.Cn;
                comando.CommandText = sentenciaSQL;
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    cargo = new Cargo();
                    cargo.LugarHechos = new Lugar();
                    cargo.Delito = dr["Delito"].ToString();
                    cargo.Descripcion = dr["Descripcion"].ToString();
                    cargo.FechaHechos = Convert.ToDateTime(dr["Fecha"].ToString());
                    cargo.LugarHechos.NombreLocalidad = dr["Nombre_Localidad"].ToString();
                    cargo.LugarHechos.NombreCiudad = dr["Nombre_Ciudad"].ToString();
                    cargo.LugarHechos.NombrePais = dr["Nombre_Pais"].ToString();
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
