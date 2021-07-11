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
        Conexion cn;
        SqlCommand cmd;
        public DatosRecluso()
        {
            cn = new Conexion();
            cmd = new SqlCommand();
        }
        public Expediente buscarExpedienteBD(string cedula)
        {
            string sentenciaSQL = "Select * from Expediente e Where e.Cedula_Recluso='" + cedula + "'";
            cn.conectar();
            SqlDataReader dr = null;
            Expediente expe = null;
            try
            {
                cmd.Connection = cn.Cn;
                cmd.CommandText = sentenciaSQL;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    expe = new Expediente();
                    expe.Id = Convert.ToInt32(dr["Id_Expediente"]);
                    expe.Codigo = (dr["Codigo"]).ToString();
                }
            }
            catch (Exception ex)
            {
                //msj = "0 " + ex.Message;
            }
            cn.cerrar();
            return expe;
        }

        public void InsertarRecluso(Recluso recluso)
        {
            string sentenciaSQL = "INSERT INTO Recluso(Codigo,Cedula,Nombres,Apellidos,Fecha_Nac,Genero,Id_Expediente)VALUES('" 
                + recluso.Codigo + "','" + recluso.Cedula + "','" + recluso.Nombre + "','" + recluso.Apellidos + "','" 
                + recluso.Fecha.ToString("yyyy-MM-dd") + "','" + recluso.Genero + "','" + recluso.Expediente.Id + "')";
            string RecuperarId = "Select @@identity";

            try
            {   
                    cn.conectar();
                    cmd.Connection = cn.Cn;
                    cmd.CommandText = sentenciaSQL;
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = RecuperarId;      
            }
            catch (SqlException)
            {
                throw new ConsultaFallida();
            }
            cn.cerrar();
        }

        public List<Object> ConsultarReclusos()
        {
            string sentenciaSQL = "SELECT * from Recluso";
            List<Object> reclusos = ConsultarGeneral(sentenciaSQL);
            return reclusos;
        }
        public List<Cargo> ConsultarCargos(string codigoExpediente)
        {
            string sentenciaSQL =
                "SELECT c.Delito, c.Descripcion, c.Fecha, l.Nombre_Localidad," +
                "ci.Nombre_Ciudad, p.Nombre_Pais " +
                "FROM Expediente As e , CArgo As c, Localidad As l, Ciudad As ci, Pais As p" +
                " WHERE e.Codigo= '" + codigoExpediente +"' AND " +
                " e.Id_Expediente = c.Id_Expediente AND c.Id_Localidad = l.Id_Localidad" +
                " AND l.Id_Ciudad=ci.Id_Ciudad AND ci.Id_Pais=p.Id_Pais;";
            List<Cargo> cargos = new List<Cargo>();
            SqlDataReader dr = null;
            Cargo cargo= null;

            try
            {
                cn.conectar();
                cmd.Connection = cn.Cn;
                cmd.CommandText = sentenciaSQL;
                dr = cmd.ExecuteReader();

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return cargos;
        }
        public object BuscarRecluso(string cedula)
        {
            string sentenciaSQL = "SELECT * from Recluso WHERE Cedula='"+cedula+"';";
            Object recluso = ConsultarGeneral(sentenciaSQL)[0];
            return recluso;
        }

        private List<Object> ConsultarGeneral(string sentenciaSQL)
        {
            List<Object> reclusos = new List<Object>();
            SqlDataReader dr = null;
            Recluso recluso = null;

            try
            {
                cn.conectar();
                cmd.Connection = cn.Cn;
                cmd.CommandText = sentenciaSQL;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {   
                    recluso = new Recluso();
                    recluso.Expediente = new Expediente();
                    recluso.Id = Convert.ToInt32(dr["Id_Recluso"]);
                    recluso.Codigo = dr["Codigo"].ToString();
                    recluso.Nombre = dr["Nombres"].ToString();
                    recluso.Apellidos = dr["Apellidos"].ToString();
                    recluso.Cedula = dr["Cedula"].ToString();
                    recluso.Fecha= Convert.ToDateTime(dr["Fecha_Nac"].ToString());
                    recluso.Genero = dr["Genero"].ToString();
                    recluso.Expediente.Id= Convert.ToInt32(dr["Id_Expediente"]);
                    reclusos.Add(recluso);
                }
            }
            catch (Exception ex)
            {
               
            }
            return reclusos;
        }
    }
}
