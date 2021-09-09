using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Excepciones;

namespace Data
{
    /// <summary>
    /// Es la clase que se encarga de establecer una conexión entre la aplicación y la base de datos.
    /// </summary>
    public class Conexion
    {
        /// <summary>
        /// Es la cadena de conexión , contiene las credenciales y la dirección del servidor de base de datos.
        /// </summary>
        private static string cadena = "Data Source=sql5059.site4now.net;Initial Catalog=db_a7961c_prision2p;Persist Security Info=True;User ID=db_a7961c_prision2p_admin;Password=prision123";
        /// <summary>
        /// Es el atributo d ela librería de MySql que usamos. 
        /// </summary>
        private SqlConnection cn = null;
        public SqlConnection Cn { get => cn; set => cn = value; }
        /// <summary>
        /// Abre la conexión con la base de datos.
        /// </summary>
        public void Conectar()
        {
            try
            {
                Cn = new SqlConnection();
                Cn.ConnectionString = cadena;
                Cn.Open();
            }
            catch (SqlException)
            {
                throw new ConexionFallida();
            }
        }
        /// <summary>
        /// Cierra la conexión con la base de datos.
        /// </summary>
        public string Cerrar()
        {
            string x = "";
            try
            {
                Cn.Close();
                x = "1";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                x = "0" + ex.Message;
            }
            return x;
        }
    }
}
