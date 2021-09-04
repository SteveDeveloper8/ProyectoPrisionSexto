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
    public class Conexion
    {
        private static string cadena = "Data Source=sql5059.site4now.net;Initial Catalog=db_a7961c_prision2p;Persist Security Info=True;User ID=db_a7961c_prision2p_admin;Password=prision123";

        private SqlConnection cn = null;
        public SqlConnection Cn { get => cn; set => cn = value; }

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
