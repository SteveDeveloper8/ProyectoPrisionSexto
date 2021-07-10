using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

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
            MessageBox.Show(recluso.Nombre + recluso.Apellidos);
            string sentenciaSQL = "INSERT INTO Recluso(Codigo,Cedula,Nombres,Apellidos,Fecha_Nac,Genero,Id_Expediente)VALUES('" + recluso.Codigo + "','" + recluso.Cedula + "','" + recluso.Nombre + "','" + recluso.Apellidos + "','" + recluso.Fecha.ToString("yyyy-MM-dd") + "','" + recluso.Genero + "','" + recluso.Expediente + "')";
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
                    MessageBox.Show("Error: " + msj);
                }
                
            }
            catch (SqlException xe)
            {
               MessageBox.Show(xe.Message);
            }
            cn.cerrar();

            return mensaje;
        }
    }
}
