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
        Conexion cn = new Conexion();
        SqlCommand cmd = new SqlCommand();

        public Expediente buscarExpedienteBD(string cedula)
        {
            string sentenciaSQL = "Select * from Expediente e Where e.Cedula_Recluso='" + cedula + "'";
            string msj = cn.conectar();
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
                    expe.Codigo = Convert.ToInt32(dr["Codigo"]);
                    expe.Cedula_recluso = dr["Cedula_Recluso"].ToString();
                    expe.Cargos.Add(null);
                }
            }
            catch (Exception ex)
            {
                msj = "0 " + ex.Message;
            }
            cn.cerrar();
            return expe;
        }

        public string InsertarRecluso(Recluso recluso)
        {
            Conexion cn = new Conexion();
            string msj = cn.conectar(),mensaje="";
            
            string sentenciaSQL = "INSERT INTO Recluso(Codigo,Cedula,Nombres,Apellidos,Fecha_Nac,Genero,Id_Expediente)VALUES('" 
                + recluso.Codigo + "','" + recluso.Cedula + "','" + recluso.Nombre + "','" + recluso.Apellidos + "','" 
                + recluso.Fecha.ToString("yyyy-MM-dd") + "','" + recluso.Genero + "','" + recluso.Expediente.Id + "')";
            string RecuperarId = "Select @@identity";

            try
            {
                if (msj[0] == '1')
                {
                    cmd.Connection = cn.Cn;
                    cmd.CommandText = sentenciaSQL;
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = RecuperarId;
                }
                else
                {
                    throw new ConsultaFallida();
                }
                
            }
            catch (SqlException xe)
            {
                mensaje = "fallido";
            }
            cn.cerrar();

            return mensaje;
        }

        public List<Object> ConsultarReclusos()
        {
            string sentenciaSQL = "SELECT * from Recluso";
            List<Object> reclusos = ConsultarGeneral(sentenciaSQL);
            return reclusos;
        }

        private List<Object> ConsultarGeneral(string sentenciaSQL)
        {
            List<Object> reclusos = new List<Object>();
            string msj = cn.conectar(),mensaje="";
            SqlDataReader dr = null;
            Recluso recluso = null;

            try
            {
                cmd.Connection = cn.Cn;
                cmd.CommandText = sentenciaSQL;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    
                    recluso = new Recluso();
                    recluso.Id = Convert.ToInt32(dr["Id_Recluso"]);
                    recluso.Codigo = dr["Codigo"].ToString();
                    recluso.Nombre = dr["Nombres"].ToString();
                    recluso.Apellidos = dr["Apellidos"].ToString();
                    recluso.Cedula = dr["Cedula"].ToString();
                    recluso.Fecha= Convert.ToDateTime(dr["Fecha_Nac"].ToString());
                    recluso.Genero = dr["Genero"].ToString();
                    //recluso.Expediente.Id= Convert.ToInt32(dr["Id_Expediente"]);
                    reclusos.Add(recluso);
                }
            }
            catch (Exception ex)
            {
                mensaje = "fallido";
            }


            return reclusos;
        }
    }
}
